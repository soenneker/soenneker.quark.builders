using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PositionOffsetEnum
{
    public static readonly PositionOffsetEnum Top0 = new("top-0");
    public static readonly PositionOffsetEnum Top50 = new("top-50");
    public static readonly PositionOffsetEnum Top100 = new("top-100");
    public static readonly PositionOffsetEnum Bottom0 = new("bottom-0");
    public static readonly PositionOffsetEnum Bottom50 = new("bottom-50");
    public static readonly PositionOffsetEnum Bottom100 = new("bottom-100");
    public static readonly PositionOffsetEnum Start0 = new("start-0");
    public static readonly PositionOffsetEnum Start50 = new("start-50");
    public static readonly PositionOffsetEnum Start100 = new("start-100");
    public static readonly PositionOffsetEnum End0 = new("end-0");
    public static readonly PositionOffsetEnum End50 = new("end-50");
    public static readonly PositionOffsetEnum End100 = new("end-100");
    public static readonly PositionOffsetEnum TranslateMiddle = new("translate-middle");
    public static readonly PositionOffsetEnum TranslateMiddleX = new("translate-middle-x");
    public static readonly PositionOffsetEnum TranslateMiddleY = new("translate-middle-y");
}
