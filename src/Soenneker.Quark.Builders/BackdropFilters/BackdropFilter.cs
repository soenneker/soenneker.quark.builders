namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for complete backdrop filter expressions.
/// </summary>
[TailwindModifiers(typeof(BackdropFilterBuilder))]
public static partial class BackdropFilter
{
    /// <summary>Adds <c>backdrop-filter-none</c>.</summary>
    public static BackdropFilterBuilder None => new("backdrop-filter-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropFilterBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-filter-"));
}
