using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public partial class FloatEnum
{
    public static readonly FloatEnum None = new("float-none");
    public static readonly FloatEnum Left = new("float-left");
    public static readonly FloatEnum Right = new("float-right");
    public static readonly FloatEnum Start = new("float-start");
    public static readonly FloatEnum End = new("float-end");
}
