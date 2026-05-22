using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TransitionEnum
{
    public static readonly TransitionEnum Default = new("transition");
    public static readonly TransitionEnum None = new("transition-none");
    public static readonly TransitionEnum All = new("transition-all");
    public static readonly TransitionEnum Colors = new("transition-colors");
    public static readonly TransitionEnum Opacity = new("transition-opacity");
    public static readonly TransitionEnum Shadow = new("transition-shadow");
    public static readonly TransitionEnum Transform = new("transition-transform");
}
