using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BackgroundImageEnum
{
    public static readonly BackgroundImageEnum None = new("bg-none");
    public static readonly BackgroundImageEnum LinearToT = new("bg-linear-to-t");
    public static readonly BackgroundImageEnum LinearToR = new("bg-linear-to-r");
    public static readonly BackgroundImageEnum LinearToB = new("bg-linear-to-b");
    public static readonly BackgroundImageEnum LinearToL = new("bg-linear-to-l");
    public static readonly BackgroundImageEnum Radial = new("bg-radial");
    public static readonly BackgroundImageEnum Conic = new("bg-conic");
}
