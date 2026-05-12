
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
    private readonly List<ScrollBehaviorRule> _rules = new(4);

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
    public ScrollBehaviorBuilder Auto => ChainWithBehavior(ScrollBehaviorEnum.Auto);
    /// <summary>
    /// Sets the scroll behavior to smooth.
    /// </summary>
    public ScrollBehaviorBuilder Smooth => ChainWithBehavior(ScrollBehaviorEnum.Smooth);

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
            ScrollBehaviorRule rule = _rules[i];
            string cls = rule.Behavior;
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
