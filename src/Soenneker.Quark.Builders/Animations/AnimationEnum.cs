using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class AnimationEnum
{
    public static readonly AnimationEnum None = new("animate-none");
    public static readonly AnimationEnum Spin = new("animate-spin");
    public static readonly AnimationEnum Ping = new("animate-ping");
    public static readonly AnimationEnum Pulse = new("animate-pulse");
    public static readonly AnimationEnum Bounce = new("animate-bounce");
}
