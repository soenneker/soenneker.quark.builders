using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class JustifyEnum
{
    public static readonly JustifyEnum Normal = new("normal");
    public static readonly JustifyEnum Start = new("start");
    public static readonly JustifyEnum End = new("end");
    public static readonly JustifyEnum Center = new("center");
    public static readonly JustifyEnum Between = new("between");
    public static readonly JustifyEnum Around = new("around");
    public static readonly JustifyEnum Evenly = new("evenly");
    public static readonly JustifyEnum Stretch = new("stretch");
}
