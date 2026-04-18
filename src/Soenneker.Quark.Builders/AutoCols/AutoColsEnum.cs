using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class AutoColsEnum
{
    public static readonly AutoColsEnum Auto = new("auto-cols-auto");
    public static readonly AutoColsEnum Min = new("auto-cols-min");
    public static readonly AutoColsEnum Max = new("auto-cols-max");
    public static readonly AutoColsEnum Fr = new("auto-cols-fr");
}
