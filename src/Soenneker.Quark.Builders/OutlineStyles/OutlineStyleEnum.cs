using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OutlineStyleEnum
{
    public static readonly OutlineStyleEnum None = new("outline-none");
    public static readonly OutlineStyleEnum Hidden = new("outline-hidden");
    public static readonly OutlineStyleEnum Solid = new("outline");
    public static readonly OutlineStyleEnum Dashed = new("outline-dashed");
    public static readonly OutlineStyleEnum Dotted = new("outline-dotted");
    public static readonly OutlineStyleEnum Double = new("outline-double");
}
