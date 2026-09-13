
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
    private RuleList<TransitionRule> _rules;

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
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
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

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            TransitionRule rule = _rules[0];
            return ClassWriter.Render(rule.Transition, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                TransitionRule rule = _rules[i];
                writer.Add(rule.Transition, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
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
