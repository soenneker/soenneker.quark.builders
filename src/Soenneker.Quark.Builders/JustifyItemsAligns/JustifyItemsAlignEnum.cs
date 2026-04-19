using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class JustifyItemsAlignEnum
{
    public static readonly JustifyItemsAlignEnum Normal = new("normal");
    public static readonly JustifyItemsAlignEnum Start = new("start");
    public static readonly JustifyItemsAlignEnum End = new("end");
    public static readonly JustifyItemsAlignEnum Center = new("center");
    public static readonly JustifyItemsAlignEnum Stretch = new("stretch");
}
