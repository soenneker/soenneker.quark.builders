using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the animation enum.
/// </summary>
[EnumValue<string>]
public sealed partial class AnimationEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly AnimationEnum None = new("animate-none");
    /// <summary>
    /// The spin.
    /// </summary>
    public static readonly AnimationEnum Spin = new("animate-spin");
    /// <summary>
    /// The ping.
    /// </summary>
    public static readonly AnimationEnum Ping = new("animate-ping");
    /// <summary>
    /// The pulse.
    /// </summary>
    public static readonly AnimationEnum Pulse = new("animate-pulse");
    /// <summary>
    /// The bounce.
    /// </summary>
    public static readonly AnimationEnum Bounce = new("animate-bounce");
}
