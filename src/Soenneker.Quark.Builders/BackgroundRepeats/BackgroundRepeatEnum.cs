using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BackgroundRepeatEnum
{
    public static readonly BackgroundRepeatEnum Repeat = new("bg-repeat");
    public static readonly BackgroundRepeatEnum NoRepeat = new("bg-no-repeat");
    public static readonly BackgroundRepeatEnum RepeatX = new("bg-repeat-x");
    public static readonly BackgroundRepeatEnum RepeatY = new("bg-repeat-y");
    public static readonly BackgroundRepeatEnum RepeatRound = new("bg-repeat-round");
    public static readonly BackgroundRepeatEnum RepeatSpace = new("bg-repeat-space");
}
