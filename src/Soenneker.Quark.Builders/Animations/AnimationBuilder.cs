
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified animation builder with fluent API for chaining animation rules.
/// </summary>
[TailwindPrefix("animate-", Responsive = true)]
public sealed class AnimationBuilder : CssBuilderBase<AnimationBuilder>
{
    /// <summary>Adds <c>animate-in</c>.</summary>
    public AnimationBuilder In => ChainWithAnimation("animate-in");

    /// <summary>Adds <c>animate-out</c>.</summary>
    public AnimationBuilder Out => ChainWithAnimation("animate-out");

    /// <summary>Adds a <c>fade-in-*</c> animation utility.</summary>
    public AnimationBuilder FadeIn(int percent) => ChainAnimationAmount("fade-in-", percent);

    /// <summary>Adds a <c>fade-out-*</c> animation utility.</summary>
    public AnimationBuilder FadeOut(int percent) => ChainAnimationAmount("fade-out-", percent);

    /// <summary>Adds a <c>zoom-in-*</c> animation utility.</summary>
    public AnimationBuilder ZoomIn(int percent) => ChainAnimationAmount("zoom-in-", percent);

    /// <summary>Adds a <c>zoom-out-*</c> animation utility.</summary>
    public AnimationBuilder ZoomOut(int percent) => ChainAnimationAmount("zoom-out-", percent);

    /// <summary>Adds a <c>slide-in-from-top-*</c> animation utility.</summary>
    public AnimationBuilder SlideInFromTop(int distance) => ChainAnimationAmount("slide-in-from-top-", distance);

    /// <summary>Adds a <c>slide-in-from-right-*</c> animation utility.</summary>
    public AnimationBuilder SlideInFromRight(int distance) => ChainAnimationAmount("slide-in-from-right-", distance);

    /// <summary>Adds a <c>slide-in-from-bottom-*</c> animation utility.</summary>
    public AnimationBuilder SlideInFromBottom(int distance) => ChainAnimationAmount("slide-in-from-bottom-", distance);

    /// <summary>Adds a <c>slide-in-from-left-*</c> animation utility.</summary>
    public AnimationBuilder SlideInFromLeft(int distance) => ChainAnimationAmount("slide-in-from-left-", distance);

    /// <summary>Adds a <c>slide-out-to-top-*</c> animation utility.</summary>
    public AnimationBuilder SlideOutToTop(int distance) => ChainAnimationAmount("slide-out-to-top-", distance);

    /// <summary>Adds a <c>slide-out-to-right-*</c> animation utility.</summary>
    public AnimationBuilder SlideOutToRight(int distance) => ChainAnimationAmount("slide-out-to-right-", distance);

    /// <summary>Adds a <c>slide-out-to-bottom-*</c> animation utility.</summary>
    public AnimationBuilder SlideOutToBottom(int distance) => ChainAnimationAmount("slide-out-to-bottom-", distance);

    /// <summary>Adds a <c>slide-out-to-left-*</c> animation utility.</summary>
    public AnimationBuilder SlideOutToLeft(int distance) => ChainAnimationAmount("slide-out-to-left-", distance);

    private AnimationBuilder ChainAnimationAmount(string prefix, int amount)
    {
        System.ArgumentOutOfRangeException.ThrowIfNegative(amount);
        return ChainWithAnimation(prefix + amount.ToString(System.Globalization.CultureInfo.InvariantCulture));
    }

    private RuleList<AnimationRule> _rules;

    internal AnimationBuilder()
    {
    }

    internal AnimationBuilder(AnimationEnum animation, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AnimationRule(animation.Value, breakpoint));
    }

    internal AnimationBuilder(string animation, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AnimationRule(animation, breakpoint));
    }

    internal AnimationBuilder(List<AnimationRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the animation to none.
    /// </summary>
    public AnimationBuilder None => ChainWithAnimation(AnimationEnum.None);

    /// <summary>
    /// Sets the animation to spin.
    /// </summary>
    public AnimationBuilder Spin => ChainWithAnimation(AnimationEnum.Spin);

    /// <summary>
    /// Sets the animation to ping.
    /// </summary>
    public AnimationBuilder Ping => ChainWithAnimation(AnimationEnum.Ping);

    /// <summary>
    /// Sets the animation to pulse.
    /// </summary>
    public AnimationBuilder Pulse => ChainWithAnimation(AnimationEnum.Pulse);

    /// <summary>
    /// Sets the animation to bounce.
    /// </summary>
    public AnimationBuilder Bounce => ChainWithAnimation(AnimationEnum.Bounce);

    /// <summary>
    /// Applies an exact Tailwind animation utility token, e.g. "animate-in".
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public AnimationBuilder Token(string token) => ChainWithAnimation(token);







    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AnimationBuilder ChainWithAnimation(AnimationEnum animation)
    {
        return ChainWithAnimation(animation.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AnimationBuilder ChainWithAnimation(string animation)
    {
        BreakpointType? bp = null;
        _rules.Add(new AnimationRule(animation, bp, ConsumePendingModifierChain()));
        return this;
    }


    public override string ToClass() => _rules.CachedClass ??= BuildClass();

    private string BuildClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            AnimationRule rule = _rules[0];
            return ClassWriter.Render(rule.Animation, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                AnimationRule rule = _rules[i];
                writer.Add(rule.Animation, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }


    /// <summary>
    /// Returns the CSS class string representation of this animation builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
