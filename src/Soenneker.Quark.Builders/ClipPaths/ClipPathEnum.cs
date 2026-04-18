using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ClipPathEnum
{
    public static readonly ClipPathEnum None = new("clip-path-none");
    public static readonly ClipPathEnum Circle = new("clip-path-circle");
    public static readonly ClipPathEnum Ellipse = new("clip-path-ellipse");
    public static readonly ClipPathEnum Inset = new("clip-path-inset");
    public static readonly ClipPathEnum Polygon = new("clip-path-polygon");
}
