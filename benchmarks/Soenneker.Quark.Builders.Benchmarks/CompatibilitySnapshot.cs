using System.Reflection;
using System.Text.Json;
using Soenneker.Quark;

internal static class CompatibilitySnapshot
{
    public static void Write(string path)
    {
        var results = new SortedDictionary<string, string>(StringComparer.Ordinal);
        foreach (Type type in typeof(ICssBuilder).Assembly.GetExportedTypes())
        {
            if (!type.IsAbstract || !type.IsSealed)
                continue;
            foreach (PropertyInfo factory in type.GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                if (!typeof(ICssBuilder).IsAssignableFrom(factory.PropertyType))
                    continue;
                string key = $"{type.Name}.{factory.Name}";
                Capture(key, () => (ICssBuilder)factory.GetValue(null)!);
                PropertyInfo[] steps = factory.PropertyType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.PropertyType == factory.PropertyType && p.GetIndexParameters().Length == 0)
                    .OrderBy(p => p.Name, StringComparer.Ordinal).ToArray();
                // Exercise every fluent property, including modifier ordering and side retargeting.
                foreach (PropertyInfo step in steps)
                    Capture($"{key}/{step.Name}", () => (ICssBuilder)step.GetValue(factory.GetValue(null))!);
                // Cross both overflow-array growth boundaries, with renders during mutation.
                Capture($"{key}/growth", () =>
                {
                    var builder = (ICssBuilder)factory.GetValue(null)!;
                    for (int i = 0; i < 20 && steps.Length != 0; i++)
                    {
                        builder = (ICssBuilder)steps[i % steps.Length].GetValue(builder)!;
                        _ = builder.ToClass();
                    }
                    return builder;
                });
            }
        }
        AuditCases.Add(results);
        File.WriteAllText(path, JsonSerializer.Serialize(results));
        Console.WriteLine($"Wrote {results.Count} compatibility cases to {path}");

        void Capture(string key, Func<ICssBuilder> create)
        {
            try
            {
                ICssBuilder builder = create();
                results.Add(key, builder.ToClass() + "|" + builder.ToClass() + "|" + builder.ToStyle());
            }
            catch (Exception exception)
            {
                results.Add(key, "EXCEPTION:" + (exception is TargetInvocationException ? exception.InnerException!.GetType().FullName : exception.GetType().FullName));
            }
        }
    }
}
