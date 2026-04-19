using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DecorationStyleEnum
{
    public static readonly DecorationStyleEnum Solid = new("decoration-solid");
    public static readonly DecorationStyleEnum Double = new("decoration-double");
    public static readonly DecorationStyleEnum Dotted = new("decoration-dotted");
    public static readonly DecorationStyleEnum Dashed = new("decoration-dashed");
    public static readonly DecorationStyleEnum Wavy = new("decoration-wavy");
}
