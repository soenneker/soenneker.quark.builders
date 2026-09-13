
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified scroll behavior builder with fluent API for chaining scroll behavior rules.
/// </summary>
[TailwindPrefix("scroll-", Responsive = true)]
public sealed class ScrollBehaviorBuilder : CssBuilderBase<ScrollBehaviorBuilder>
{
    private RuleList<ScrollBehaviorRule> _rules;

    internal ScrollBehaviorBuilder()
    {
    }

    internal ScrollBehaviorBuilder(string behavior, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollBehaviorRule(behavior, breakpoint));
    }

    internal ScrollBehaviorBuilder(ScrollBehaviorEnum behavior, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollBehaviorRule(behavior.Value, breakpoint));
    }

    internal ScrollBehaviorBuilder(List<ScrollBehaviorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the scroll behavior to auto.
    /// </summary>
    public ScrollBehaviorBuilder Auto => ChainWithBehavior(ScrollBehaviorEnum.AutoValue);
    /// <summary>
    /// Sets the scroll behavior to smooth.
    /// </summary>
    public ScrollBehaviorBuilder Smooth => ChainWithBehavior(ScrollBehaviorEnum.SmoothValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollBehaviorBuilder ChainWithBehavior(string behavior)
    {
        _rules.Add(new ScrollBehaviorRule(behavior, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollBehaviorBuilder ChainWithBehavior(ScrollBehaviorEnum behavior)
    {
        _rules.Add(new ScrollBehaviorRule(behavior.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ScrollBehaviorRule rule = _rules[0];
            return ClassWriter.Render(rule.Behavior, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ScrollBehaviorRule rule = _rules[i];
                writer.Add(rule.Behavior, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// Returns the CSS class string representation of this scroll behavior builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
