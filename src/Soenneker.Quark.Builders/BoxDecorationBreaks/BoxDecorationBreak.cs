namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for decoration across fragmented boxes.
/// </summary>
[TailwindModifiers(typeof(BoxDecorationBreakBuilder))]
public static partial class BoxDecorationBreak
{
    /// <summary>Adds <c>box-decoration-clone</c>.</summary>
    public static BoxDecorationBreakBuilder Clone => new("box-decoration-clone");

    /// <summary>Adds <c>box-decoration-slice</c>.</summary>
    public static BoxDecorationBreakBuilder Slice => new("box-decoration-slice");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BoxDecorationBreakBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "box-decoration-"));
}
