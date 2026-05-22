using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BorderStyleEnum
{
    public static readonly BorderStyleEnum Solid = new("border-solid");
    public static readonly BorderStyleEnum Dashed = new("border-dashed");
    public static readonly BorderStyleEnum Dotted = new("border-dotted");
    public static readonly BorderStyleEnum Double = new("border-double");
    public static readonly BorderStyleEnum Hidden = new("border-hidden");
    public static readonly BorderStyleEnum None = new("border-none");
}
