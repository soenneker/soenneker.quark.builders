
namespace Soenneker.Quark;

/// <summary>
/// Simplified resize utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(ResizeBuilder))]
public static partial class Resize
{
    /// <summary>
    /// No resize (none).
    /// </summary>
    public static ResizeBuilder None => new(ResizeEnum.None);

    /// <summary>
    /// Resize both (both).
    /// </summary>
    public static ResizeBuilder Both => new(ResizeEnum.Both);

    /// <summary>
    /// Resize horizontally (horizontal).
    /// </summary>
    public static ResizeBuilder Horizontal => new(ResizeEnum.Horizontal);

    /// <summary>
    /// Resize vertically (vertical).
    /// </summary>
    public static ResizeBuilder Vertical => new(ResizeEnum.Vertical);
}
