
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified transition builder with fluent API for chaining transition rules.
/// </summary>
[TailwindPrefix("transition-", Responsive = true)]
public sealed class TransitionBuilder : CssBuilderBase<TransitionBuilder>
{
    private readonly List<TransitionRule> _rules = new(4);

    internal TransitionBuilder()
    {
    }

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
    public TransitionBuilder Default => ChainWithTransition(TransitionEnum.Default);
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
    public TransitionBuilder Token(string token) => ChainWithTransition(token.StartsWith("transition") ? token : $"transition-{token}");

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TransitionBuilder ChainWithTransition(TransitionEnum transition)
    {
        return ChainWithTransition(transition.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TransitionBuilder ChainWithTransition(string transition)
    {
        _rules.Add(new TransitionRule(transition, null, ConsumePendingModifierChain()));
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

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
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
