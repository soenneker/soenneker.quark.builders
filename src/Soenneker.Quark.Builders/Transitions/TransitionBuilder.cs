
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified transition builder with fluent API for chaining transition rules.
/// </summary>
[TailwindPrefix("transition-", Responsive = true)]
public sealed class TransitionBuilder : CssBuilderBase
{
    private readonly List<TransitionRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal TransitionBuilder(TransitionEnum transition, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TransitionRule(transition.Value, breakpoint));
    }

    internal TransitionBuilder(string transition, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TransitionRule(transition, breakpoint));
    }

    internal TransitionBuilder(List<TransitionRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the transition to none.
    /// </summary>
    public TransitionBuilder None => ChainWithTransition(TransitionEnum.None);
    /// <summary>
    /// Sets the transition to all.
    /// </summary>
    public TransitionBuilder All => ChainWithTransition(TransitionEnum.All);
    /// <summary>
    /// Sets the transition to colors.
    /// </summary>
    public TransitionBuilder Colors => ChainWithTransition(TransitionEnum.Colors);
    /// <summary>
    /// Sets the transition to opacity.
    /// </summary>
    public TransitionBuilder Opacity => ChainWithTransition(TransitionEnum.Opacity);
    /// <summary>
    /// Sets the transition to shadow.
    /// </summary>
    public TransitionBuilder Shadow => ChainWithTransition(TransitionEnum.Shadow);
    /// <summary>
    /// Sets the transition to transform.
    /// </summary>
    public TransitionBuilder Transform => ChainWithTransition(TransitionEnum.Transform);

    /// <summary>
    /// Applies an exact Tailwind transition utility token, e.g. "transition-[left,right,width]".
    /// </summary>
    public TransitionBuilder Token(string token) => ChainWithTransition(token);

    /// <summary>
    /// Applies the transition on phone breakpoint.
    /// </summary>
    public TransitionBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the transition on small breakpoint (≥640px).
    /// </summary>
    public TransitionBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the transition on tablet breakpoint.
    /// </summary>
    public TransitionBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the transition on laptop breakpoint.
    /// </summary>
    public TransitionBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the transition on desktop breakpoint.
    /// </summary>
    public TransitionBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the transition on the 2xl breakpoint.
    /// </summary>
    public TransitionBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TransitionBuilder ChainWithTransition(TransitionEnum transition)
    {
        return ChainWithTransition(transition.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TransitionBuilder ChainWithTransition(string transition)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new TransitionRule(transition, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TransitionBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
            TransitionRule rule = _rules[i];
            string cls = rule.Transition;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this transition builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
