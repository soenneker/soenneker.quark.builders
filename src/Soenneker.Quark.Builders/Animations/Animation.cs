namespace Soenneker.Quark;

/// <summary>
/// Simplified animation utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(AnimationBuilder))]
public static partial class Animation
{
    /// <summary>
    /// No animation (none).
    /// </summary>
    public static AnimationBuilder None => new(AnimationEnum.NoneValue);

    /// <summary>
    /// Spin animation (spin).
    /// </summary>
    public static AnimationBuilder Spin => new(AnimationEnum.SpinValue);

    /// <summary>
    /// Ping animation (ping).
    /// </summary>
    public static AnimationBuilder Ping => new(AnimationEnum.PingValue);

    /// <summary>
    /// Pulse animation (pulse).
    /// </summary>
    public static AnimationBuilder Pulse => new(AnimationEnum.PulseValue);

    /// <summary>
    /// Bounce animation (bounce).
    /// </summary>
    public static AnimationBuilder Bounce => new(AnimationEnum.BounceValue);
}
