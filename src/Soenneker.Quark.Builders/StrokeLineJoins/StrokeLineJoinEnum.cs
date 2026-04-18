using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class StrokeLineJoinEnum
{
    public static readonly StrokeLineJoinEnum Auto = new("stroke-join-auto");
    public static readonly StrokeLineJoinEnum Round = new("stroke-join-round");
    public static readonly StrokeLineJoinEnum Bevel = new("stroke-join-bevel");
    public static readonly StrokeLineJoinEnum Miter = new("stroke-join-miter");
}
