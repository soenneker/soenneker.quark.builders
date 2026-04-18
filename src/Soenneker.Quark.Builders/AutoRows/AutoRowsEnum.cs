using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class AutoRowsEnum
{
    public static readonly AutoRowsEnum Auto = new("auto-rows-auto");
    public static readonly AutoRowsEnum Min = new("auto-rows-min");
    public static readonly AutoRowsEnum Max = new("auto-rows-max");
    public static readonly AutoRowsEnum Fr = new("auto-rows-fr");
}
