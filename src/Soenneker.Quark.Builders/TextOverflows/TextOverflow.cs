namespace Soenneker.Quark;

/// <summary>
/// Simplified text overflow utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(TextOverflowBuilder))]
public static partial class TextOverflow
{
    /// <summary>
    /// Clips the overflowing text at the content area boundary.
    /// </summary>
    public static TextOverflowBuilder Clip => new(TextOverflowEnum.Clip);

    /// <summary>
    /// Displays an ellipsis ('…') to represent clipped text.
    /// </summary>
    public static TextOverflowBuilder Ellipsis => new(TextOverflowEnum.Ellipsis);
}
