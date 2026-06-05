using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the background repeat enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BackgroundRepeatEnum
{
    /// <summary>
    /// The repeat.
    /// </summary>
    public static readonly BackgroundRepeatEnum Repeat = new("bg-repeat");
    /// <summary>
    /// The no repeat.
    /// </summary>
    public static readonly BackgroundRepeatEnum NoRepeat = new("bg-no-repeat");
    /// <summary>
    /// The repeat x.
    /// </summary>
    public static readonly BackgroundRepeatEnum RepeatX = new("bg-repeat-x");
    /// <summary>
    /// The repeat y.
    /// </summary>
    public static readonly BackgroundRepeatEnum RepeatY = new("bg-repeat-y");
    /// <summary>
    /// The repeat round.
    /// </summary>
    public static readonly BackgroundRepeatEnum RepeatRound = new("bg-repeat-round");
    /// <summary>
    /// The repeat space.
    /// </summary>
    public static readonly BackgroundRepeatEnum RepeatSpace = new("bg-repeat-space");
}
