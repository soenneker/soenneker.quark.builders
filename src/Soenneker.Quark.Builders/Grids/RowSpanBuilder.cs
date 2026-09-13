using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the row span builder.
/// </summary>
[TailwindPrefix("row-span", Responsive = true)]
public sealed class RowSpanBuilder : CssBuilderBase<RowSpanBuilder>
{
    private RuleList<GridRule> _rules;

    internal RowSpanBuilder()
    {
    }

    internal RowSpanBuilder(RowSpanEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new GridRule(value.Value, breakpoint));
    }

    internal RowSpanBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length > 0)
            _rules.Add(new GridRule(value, breakpoint));
    }

    internal RowSpanBuilder(List<GridRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public RowSpanBuilder Is1 => Chain(RowSpanEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public RowSpanBuilder Is2 => Chain(RowSpanEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public RowSpanBuilder Is3 => Chain(RowSpanEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public RowSpanBuilder Is4 => Chain(RowSpanEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public RowSpanBuilder Is5 => Chain(RowSpanEnum.Is5);
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public RowSpanBuilder Is6 => Chain(RowSpanEnum.Is6);
    /// <summary>
    /// “Full” extremum for this utility. For border radius this is `rounded-full` (`border-radius: 9999px`), producing pills/circles; for width/height often `100%` (`w-full` / `h-full`).
    /// </summary>
    public RowSpanBuilder Full => Chain(RowSpanEnum.Full);

    /// <summary>
    /// Adds the span Row Span utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RowSpanBuilder Span(int value) => ChainClass($"row-span-{value}");

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RowSpanBuilder Chain(RowSpanEnum value)
    {
        _rules.Add(new GridRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RowSpanBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new GridRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            GridRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                GridRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
