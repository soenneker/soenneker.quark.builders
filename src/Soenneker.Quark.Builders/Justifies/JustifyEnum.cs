using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class JustifyEnum
{
    public static readonly JustifyEnum Normal = new("justify-normal");
    public static readonly JustifyEnum Start = new("justify-start");
    public static readonly JustifyEnum End = new("justify-end");
    public static readonly JustifyEnum Center = new("justify-center");
    public static readonly JustifyEnum Between = new("justify-between");
    public static readonly JustifyEnum Around = new("justify-around");
    public static readonly JustifyEnum Evenly = new("justify-evenly");
    public static readonly JustifyEnum Stretch = new("justify-stretch");
}
