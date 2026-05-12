
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified vertical alignment builder with fluent API for chaining vertical alignment rules.
/// </summary>
[TailwindPrefix("align-", Responsive = true)]
public sealed class VerticalAlignBuilder : CssBuilderBase<VerticalAlignBuilder>
{
    private readonly List<VerticalAlignRule> _rules = new(6);

    internal VerticalAlignBuilder()
    {
    }

    internal VerticalAlignBuilder(VerticalAlignEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new VerticalAlignRule(value.Value, breakpoint));
    }

    internal VerticalAlignBuilder(List<VerticalAlignRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the vertical alignment to baseline.
    /// </summary>
    public VerticalAlignBuilder Baseline => Chain(VerticalAlignEnum.Baseline);

    /// <summary>
    /// Sets the vertical alignment to top.
    /// </summary>
    public VerticalAlignBuilder Top => Chain(VerticalAlignEnum.Top);

    /// <summary>
    /// Sets the vertical alignment to middle.
    /// </summary>
    public VerticalAlignBuilder Middle => Chain(VerticalAlignEnum.Middle);

    /// <summary>
    /// Sets the vertical alignment to bottom.
    /// </summary>
    public VerticalAlignBuilder Bottom => Chain(VerticalAlignEnum.Bottom);

    /// <summary>
    /// Sets the vertical alignment to text-top.
    /// </summary>
    public VerticalAlignBuilder TextTop => Chain(VerticalAlignEnum.TextTop);

    /// <summary>
    /// Sets the vertical alignment to text-bottom.
    /// </summary>
    public VerticalAlignBuilder TextBottom => Chain(VerticalAlignEnum.TextBottom);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private VerticalAlignBuilder Chain(VerticalAlignEnum value)
    {
        _rules.Add(new VerticalAlignRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            VerticalAlignRule rule = _rules[i];
            string cls = rule.Value;
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
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;
    public override string ToString() => ToClass();
}
