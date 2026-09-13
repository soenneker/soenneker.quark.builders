using System.Reflection;
using Soenneker.Quark;

internal static class PublicApi
{
    public static void Write(string path)
    {
        var members = new SortedSet<string>(StringComparer.Ordinal);
        foreach (Type type in typeof(ICssBuilder).Assembly.GetExportedTypes())
        {
            members.Add($"TYPE {type} : {type.BaseType}; sealed={type.IsSealed}; abstract={type.IsAbstract}");
            foreach (MemberInfo member in type.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                bool visible = member switch
                {
                    MethodBase method => method.IsPublic || method.IsFamily || method.IsFamilyOrAssembly,
                    FieldInfo field => field.IsPublic || field.IsFamily || field.IsFamilyOrAssembly,
                    PropertyInfo property => (property.GetMethod ?? property.SetMethod) is { } getter && (getter.IsPublic || getter.IsFamily || getter.IsFamilyOrAssembly),
                    _ => false
                };
                if (visible) members.Add($"{type} | {member.MemberType} | {member}");
            }
        }
        File.WriteAllLines(path, members);
        Console.WriteLine($"Wrote {members.Count} public/protected API entries");
    }
}
