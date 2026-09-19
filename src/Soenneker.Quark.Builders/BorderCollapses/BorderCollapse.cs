namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for table border collapsing.
/// </summary>
[TailwindModifiers(typeof(BorderCollapseBuilder))]
public static partial class BorderCollapse
{
    /// <summary>Adds <c>border-collapse</c>.</summary>
    public static BorderCollapseBuilder Collapse => new("border-collapse");

    /// <summary>Adds <c>border-separate</c>.</summary>
    public static BorderCollapseBuilder Separate => new("border-separate");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BorderCollapseBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "border-"));
}
