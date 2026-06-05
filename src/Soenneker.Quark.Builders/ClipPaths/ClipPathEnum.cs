using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the clip path enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ClipPathEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ClipPathEnum None = new("clip-path-none");
    /// <summary>
    /// The circle.
    /// </summary>
    public static readonly ClipPathEnum Circle = new("clip-path-circle");
    /// <summary>
    /// The ellipse.
    /// </summary>
    public static readonly ClipPathEnum Ellipse = new("clip-path-ellipse");
    /// <summary>
    /// The inset.
    /// </summary>
    public static readonly ClipPathEnum Inset = new("clip-path-inset");
    /// <summary>
    /// The polygon.
    /// </summary>
    public static readonly ClipPathEnum Polygon = new("clip-path-polygon");
}
