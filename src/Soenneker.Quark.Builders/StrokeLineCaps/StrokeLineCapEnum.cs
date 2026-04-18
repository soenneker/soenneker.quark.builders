using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class StrokeLineCapEnum
{
    public static readonly StrokeLineCapEnum Auto = new("stroke-cap-auto");
    public static readonly StrokeLineCapEnum Round = new("stroke-cap-round");
    public static readonly StrokeLineCapEnum Square = new("stroke-cap-square");
    public static readonly StrokeLineCapEnum Butt = new("stroke-cap-butt");
}
