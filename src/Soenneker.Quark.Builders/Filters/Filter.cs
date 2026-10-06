namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for complete filter expressions.
/// </summary>
[TailwindModifiers(typeof(FilterBuilder))]
public static partial class Filter
{
    /// <summary>Adds <c>filter-none</c>.</summary>
    public static FilterBuilder None => new("filter-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static FilterBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "filter-"));
}
