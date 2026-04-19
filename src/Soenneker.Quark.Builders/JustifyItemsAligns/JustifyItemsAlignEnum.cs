using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class JustifyItemsAlignEnum
{
    public static readonly JustifyItemsAlignEnum Normal = new("justify-items-normal");
    public static readonly JustifyItemsAlignEnum Start = new("justify-items-start");
    public static readonly JustifyItemsAlignEnum End = new("justify-items-end");
    public static readonly JustifyItemsAlignEnum Center = new("justify-items-center");
    public static readonly JustifyItemsAlignEnum Stretch = new("justify-items-stretch");
}
