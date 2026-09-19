namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for mask positioning.
/// </summary>
[TailwindModifiers(typeof(MaskPositionBuilder))]
public static partial class MaskPosition
{
    /// <summary>Adds <c>mask-center</c>.</summary>
    public static MaskPositionBuilder Center => new("mask-center");

    /// <summary>Adds <c>mask-top</c>.</summary>
    public static MaskPositionBuilder Top => new("mask-top");

    /// <summary>Adds <c>mask-top-right</c>.</summary>
    public static MaskPositionBuilder TopRight => new("mask-top-right");

    /// <summary>Adds <c>mask-right</c>.</summary>
    public static MaskPositionBuilder Right => new("mask-right");

    /// <summary>Adds <c>mask-bottom-right</c>.</summary>
    public static MaskPositionBuilder BottomRight => new("mask-bottom-right");

    /// <summary>Adds <c>mask-bottom</c>.</summary>
    public static MaskPositionBuilder Bottom => new("mask-bottom");

    /// <summary>Adds <c>mask-bottom-left</c>.</summary>
    public static MaskPositionBuilder BottomLeft => new("mask-bottom-left");

    /// <summary>Adds <c>mask-left</c>.</summary>
    public static MaskPositionBuilder Left => new("mask-left");

    /// <summary>Adds <c>mask-top-left</c>.</summary>
    public static MaskPositionBuilder TopLeft => new("mask-top-left");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskPositionBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-"));
}
