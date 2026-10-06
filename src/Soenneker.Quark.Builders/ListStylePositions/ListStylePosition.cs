namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for list marker positioning.
/// </summary>
[TailwindModifiers(typeof(ListStylePositionBuilder))]
public static partial class ListStylePosition
{
    /// <summary>Adds <c>list-inside</c>.</summary>
    public static ListStylePositionBuilder Inside => new("list-inside");

    /// <summary>Adds <c>list-outside</c>.</summary>
    public static ListStylePositionBuilder Outside => new("list-outside");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ListStylePositionBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "list-"));
}
