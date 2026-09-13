using Soenneker.Quark;

internal static class MatrixBenchmarks
{
    public static (string Name, Func<string> Run)[] Create()
    {
        var cases = new List<(string, Func<string>)>();
        foreach (int length in new[] { 1, 2, 4, 8, 16, 64 })
        {
            string[] tokens = Enumerable.Range(0, length).Select(i => $"w-{i}").ToArray();
            var existing = Width.Token(tokens[0]);
            for (var i = 1; i < length; i++) existing.Token(tokens[i]);
            cases.Add(($"Width construct {length}", () =>
            {
                var builder = Width.Token(tokens[0]);
                for (var i = 1; i < tokens.Length; i++) builder.Token(tokens[i]);
                return builder.ToClass();
            }));
            cases.Add(($"Width render {length}", existing.ToClass));
            var responsive = ColStart.At(0);
            for (var i = 1; i < length; i++) responsive.Token(tokens[i]);
            cases.Add(($"Responsive base render {length}", responsive.ToClass));
        }
        foreach (int tokenCount in new[] { 1, 4, 16 })
            foreach (int modifierCount in new[] { 1, 4, 16 })
            {
                string group = string.Join(" ", Enumerable.Repeat("w-auto", tokenCount));
                string[] modifiers = Enumerable.Repeat("hover", modifierCount).ToArray();
                cases.Add(($"Modifier matrix {tokenCount}x{modifierCount}", () => BreakpointUtil.ApplyTailwindModifiers(group, modifiers)));
            }
        return cases.ToArray();
    }
}
