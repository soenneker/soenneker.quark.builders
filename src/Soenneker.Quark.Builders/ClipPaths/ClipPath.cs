
namespace Soenneker.Quark;

/// <summary>
/// Simplified clip path utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(ClipPathBuilder))]
public static partial class ClipPath
{
    /// <summary>
    /// No clip path (none).
    /// </summary>
    public static ClipPathBuilder None => new(ClipPathEnum.None);

    /// <summary>
    /// Circle clip path (circle).
    /// </summary>
    public static ClipPathBuilder Circle => new(ClipPathEnum.Circle);

    /// <summary>
    /// Ellipse clip path (ellipse).
    /// </summary>
    public static ClipPathBuilder Ellipse => new(ClipPathEnum.Ellipse);

    /// <summary>
    /// Inset clip path (inset).
    /// </summary>
    public static ClipPathBuilder Inset => new(ClipPathEnum.Inset);

    /// <summary>
    /// Polygon clip path (polygon).
    /// </summary>
    public static ClipPathBuilder Polygon => new(ClipPathEnum.Polygon);
}
