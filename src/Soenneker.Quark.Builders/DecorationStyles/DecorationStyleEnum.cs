using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DecorationStyleEnum
{
    public static readonly DecorationStyleEnum Solid = new("solid");
    public static readonly DecorationStyleEnum Double = new("double");
    public static readonly DecorationStyleEnum Dotted = new("dotted");
    public static readonly DecorationStyleEnum Dashed = new("dashed");
    public static readonly DecorationStyleEnum Wavy = new("wavy");
}
