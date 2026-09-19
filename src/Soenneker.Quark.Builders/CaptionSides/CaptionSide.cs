namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for table caption positioning.
/// </summary>
[TailwindModifiers(typeof(CaptionSideBuilder))]
public static partial class CaptionSide
{
    /// <summary>Adds <c>caption-top</c>.</summary>
    public static CaptionSideBuilder Top => new("caption-top");

    /// <summary>Adds <c>caption-bottom</c>.</summary>
    public static CaptionSideBuilder Bottom => new("caption-bottom");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static CaptionSideBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "caption-"));
}
