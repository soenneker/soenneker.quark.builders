using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("col-span", Responsive = true)]
public sealed class ColumnSpanBuilder : CssBuilderBase<ColumnSpanBuilder>
{
    private readonly List<GridRule> _rules = new(8);

    internal ColumnSpanBuilder()
    {
    }

    internal ColumnSpanBuilder(ColumnSpanEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new GridRule(value.Value, breakpoint));
    }

    internal ColumnSpanBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length > 0)
            _rules.Add(new GridRule(value, breakpoint));
    }

    internal ColumnSpanBuilder(List<GridRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is1 => Chain(ColumnSpanEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is2 => Chain(ColumnSpanEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is3 => Chain(ColumnSpanEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is4 => Chain(ColumnSpanEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is5 => Chain(ColumnSpanEnum.Is5);
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is6 => Chain(ColumnSpanEnum.Is6);
    /// <summary>
    /// Spacing/sizing scale step `7` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 7` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is7 => Chain(ColumnSpanEnum.Is7);
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is8 => Chain(ColumnSpanEnum.Is8);
    /// <summary>
    /// Spacing/sizing scale step `9` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 9` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is9 => Chain(ColumnSpanEnum.Is9);
    /// <summary>
    /// Spacing/sizing scale step `10` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 10` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is10 => Chain(ColumnSpanEnum.Is10);
    /// <summary>
    /// Spacing/sizing scale step `11` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 11` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is11 => Chain(ColumnSpanEnum.Is11);
    /// <summary>
    /// Spacing/sizing scale step `12` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 12` for integer spacing utilities unless overridden).
    /// </summary>
    public ColumnSpanBuilder Is12 => Chain(ColumnSpanEnum.Is12);
    /// <summary>
    /// “Full” extremum for this utility. For border radius this is `rounded-full` (`border-radius: 9999px`), producing pills/circles; for width/height often `100%` (`w-full` / `h-full`).
    /// </summary>
    public ColumnSpanBuilder Full => Chain(ColumnSpanEnum.Full);

    public ColumnSpanBuilder Span(int value) => ChainClass($"col-span-{value}");

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ColumnSpanBuilder Chain(ColumnSpanEnum value)
    {
        _rules.Add(new GridRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ColumnSpanBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new GridRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            GridRule rule = _rules[i];
            string cls = rule.Value;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
