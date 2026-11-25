namespace Soenneker.Quark;

/// <summary>
/// Simplified animation utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(AnimationBuilder))]
public static partial class Animation
{
    /// <summary>Adds <c>animate-in</c>.</summary>
    public static AnimationBuilder In => new("animate-in");

    /// <summary>Adds <c>animate-out</c>.</summary>
    public static AnimationBuilder Out => new("animate-out");

    /// <summary>Adds a <c>fade-in-*</c> animation utility.</summary>
    public static AnimationBuilder FadeIn(int percent) => new AnimationBuilder().FadeIn(percent);

    /// <summary>Adds a <c>fade-out-*</c> animation utility.</summary>
    public static AnimationBuilder FadeOut(int percent) => new AnimationBuilder().FadeOut(percent);

    /// <summary>Adds a <c>zoom-in-*</c> animation utility.</summary>
    public static AnimationBuilder ZoomIn(int percent) => new AnimationBuilder().ZoomIn(percent);

    /// <summary>Adds a <c>zoom-out-*</c> animation utility.</summary>
    public static AnimationBuilder ZoomOut(int percent) => new AnimationBuilder().ZoomOut(percent);

    /// <summary>Adds a <c>slide-in-from-top-*</c> animation utility.</summary>
    public static AnimationBuilder SlideInFromTop(int distance) => new AnimationBuilder().SlideInFromTop(distance);

    /// <summary>Adds a <c>slide-in-from-right-*</c> animation utility.</summary>
    public static AnimationBuilder SlideInFromRight(int distance) => new AnimationBuilder().SlideInFromRight(distance);

    /// <summary>Adds a <c>slide-in-from-bottom-*</c> animation utility.</summary>
    public static AnimationBuilder SlideInFromBottom(int distance) => new AnimationBuilder().SlideInFromBottom(distance);

    /// <summary>Adds a <c>slide-in-from-left-*</c> animation utility.</summary>
    public static AnimationBuilder SlideInFromLeft(int distance) => new AnimationBuilder().SlideInFromLeft(distance);

    /// <summary>Adds a <c>slide-out-to-top-*</c> animation utility.</summary>
    public static AnimationBuilder SlideOutToTop(int distance) => new AnimationBuilder().SlideOutToTop(distance);

    /// <summary>Adds a <c>slide-out-to-right-*</c> animation utility.</summary>
    public static AnimationBuilder SlideOutToRight(int distance) => new AnimationBuilder().SlideOutToRight(distance);

    /// <summary>Adds a <c>slide-out-to-bottom-*</c> animation utility.</summary>
    public static AnimationBuilder SlideOutToBottom(int distance) => new AnimationBuilder().SlideOutToBottom(distance);

    /// <summary>Adds a <c>slide-out-to-left-*</c> animation utility.</summary>
    public static AnimationBuilder SlideOutToLeft(int distance) => new AnimationBuilder().SlideOutToLeft(distance);

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
