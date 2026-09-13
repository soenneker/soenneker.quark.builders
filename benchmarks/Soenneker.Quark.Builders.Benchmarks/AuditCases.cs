using System.Globalization;
using System.Reflection;
using Soenneker.Quark;

internal static class AuditCases
{
    public static void Add(SortedDictionary<string, string> results)
    {
        string?[] tokens = [null, "", " ", "\t\u2003", "2", "-2", "m-2", "-m-2", "p-2", "a b", "a\tb", "[calc(100%-1rem)]", "(--size)", "red-500/50", "invalid", new('x', 600)];
        CultureInfo originalCulture = CultureInfo.CurrentCulture;
        try
        {
            foreach (string culture in new[] { "", "en-US", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                foreach (Type type in typeof(ICssBuilder).Assembly.GetExportedTypes().Where(t => t.IsAbstract && t.IsSealed))
                {
                    foreach (MethodInfo factory in type.GetMethods(BindingFlags.Public | BindingFlags.Static))
                    {
                        if (!typeof(ICssBuilder).IsAssignableFrom(factory.ReturnType) || factory.GetParameters().Length != 1)
                            continue;
                        Type argument = factory.GetParameters()[0].ParameterType;
                        object?[] values = argument == typeof(string) ? tokens : argument == typeof(int) ? [int.MinValue, -1, 0, 2, 299, 12345, int.MaxValue] : [];
                        for (var i = 0; i < values.Length; i++)
                        {
                            object? value = values[i];
                            Capture($"input/{culture}/{type.Name}/{factory.Name}/{argument.Name}/{i}", () =>
                            {
                                var builder = (ICssBuilder)factory.Invoke(null, [value])!;
                                string first = builder.ToClass();
                                PropertyInfo? modifier = builder.GetType().GetProperty("OnMd");
                                modifier?.GetValue(builder);
                                MethodInfo? token = builder.GetType().GetMethod("Token", [typeof(string)]);
                                token?.Invoke(builder, ["3"]);
                                return first + "|" + builder.ToClass() + "|" + builder.ToStyle();
                            });
                        }
                    }
                    foreach (PropertyInfo palette in type.GetProperties(BindingFlags.Public | BindingFlags.Static)
                                 .Where(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(ColorPaletteBuilder<>)))
                    {
                        foreach (PropertyInfo shade in palette.PropertyType.GetProperties())
                            Capture($"palette/{culture}/{type.Name}/{palette.Name}/{shade.Name}", () => ((ICssBuilder)shade.GetValue(palette.GetValue(null))!).ToClass());
                    }
                }
            }
        }
        finally
        {
            CultureInfo.CurrentCulture = originalCulture;
        }

        for (var i = 0; i < tokens.Length; i++)
        {
            string? group = tokens[i];
            for (var j = 0; j < tokens.Length; j++)
            {
                string? modifier = tokens[j];
                Capture($"modifiers/{i}/{j}/chain", () => BreakpointUtil.ApplyTailwindModifiers(group!, modifier!));
                Capture($"modifiers/{i}/{j}/list", () => BreakpointUtil.ApplyTailwindModifiers(group!, new[] { modifier!, "", null!, "hover" }));
            }
        }

        var random = new Random(7419);
        for (var sample = 0; sample < 100; sample++)
        {
            var variant = Variant.Of(new StyledBuilder(" a\tb ", ""));
            for (var step = 0; step < 24; step++)
            {
                variant = random.Next(9) switch
                {
                    0 => variant.OnSm,
                    1 => variant.OnMd,
                    2 => variant.OnBase,
                    3 => variant.OnHover,
                    4 => variant.OnFocus,
                    5 => variant.Modifier(""),
                    6 => variant.Modifier(null!),
                    7 => variant.Modifiers("", "hover", "focus"),
                    _ => variant.Custom("data-[state=open]")
                };
                Capture($"variant/{sample}/{step}", variant.ToClass);
            }
        }

        object?[] contributors = [null, "", "  ", " a ", "b", 12, -12, (CssValue<WidthBuilder>)" a ",
            ((CssValue<WidthBuilder>)"a").WithSelector(".x"), ((CssValue<WidthBuilder>)"b").WithSelector(".y"),
            ((CssValue<WidthBuilder>)"b").WithSelector(".x", true), new StyledBuilder(" a ", " color:red;; "),
            new StyledBuilder("", " ; "), new StyledBuilder("b", "height:1px; ;")];
        for (var i = 0; i < contributors.Length; i++)
            for (var j = 0; j < contributors.Length; j++)
            {
                object? first = contributors[i];
                object? second = contributors[j];
                // Explicit arrays keep this harness binary-compatible with the pre-audit API.
                Capture($"css/{i}/{j}", () => Describe(CssValue<WidthBuilder>.For(new[] { first, second })));
                Capture($"css-add/{i}/{j}", () => Describe(((CssValue<WidthBuilder>)" base ").Add(new[] { first, second })));
                Capture($"css-single/{i}/{j}", () => Describe(CssValue<WidthBuilder>.For(new[] { first }).Add(new[] { second })));
            }

        void Capture(string key, Func<string> run)
        {
            try { results.Add(key, run()); }
            catch (Exception exception) { results.Add(key, "EXCEPTION:" + exception.GetBaseException().GetType().FullName); }
        }
    }

    private static string Describe(CssValue<WidthBuilder> value) => $"{value}|{value.StyleValue}|{value.CssSelector}|{value.SelectorIsAbsolute}|{value.IsCssStyle}|{value.IsEmpty}";

    private sealed class StyledBuilder(string classes, string style) : CssBuilderBase
    {
        public override string ToClass() => classes;
        public override string ToStyle() => style;
    }
}
