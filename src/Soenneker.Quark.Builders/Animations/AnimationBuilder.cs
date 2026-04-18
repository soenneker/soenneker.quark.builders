
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified animation builder with fluent API for chaining animation rules.
/// </summary>
[TailwindPrefix("animate-", Responsive = true)]
public sealed class AnimationBuilder : CssBuilderBase
{
    private readonly List<AnimationRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

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
    public AnimationBuilder Token(string token) => ChainWithAnimation(token);

    /// <summary>
    /// Applies the animation on phone breakpoint.
    /// </summary>
    public AnimationBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);

    /// <summary>
    /// Applies the animation on small breakpoint (≥640px).
    /// </summary>
    public AnimationBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);

    /// <summary>
    /// Applies the animation on tablet breakpoint.
    /// </summary>
    public AnimationBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);

    /// <summary>
    /// Applies the animation on laptop breakpoint.
    /// </summary>
    public AnimationBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);

    /// <summary>
    /// Applies the animation on desktop breakpoint.
    /// </summary>
    public AnimationBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);

    /// <summary>
    /// Applies the animation on the 2xl breakpoint.
    /// </summary>
    public AnimationBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AnimationBuilder ChainWithAnimation(AnimationEnum animation)
    {
        return ChainWithAnimation(animation.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AnimationBuilder ChainWithAnimation(string animation)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new AnimationRule(animation, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AnimationBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            AnimationRule rule = _rules[i];
            string cls = rule.Animation;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointClass(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this animation builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
