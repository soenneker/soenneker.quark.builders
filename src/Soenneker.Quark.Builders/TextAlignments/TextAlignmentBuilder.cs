
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance text alignment builder with fluent API for chaining text alignment rules.
/// </summary>
[TailwindPrefix("text-", Responsive = true)]
public sealed class TextAlignmentBuilder : ICssBuilder
{
    private readonly List<TextAlignmentRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal TextAlignmentBuilder(TextAlignmentEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextAlignmentRule(value.Value, breakpoint));
    }

    internal TextAlignmentBuilder(List<TextAlignmentRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the text alignment to start.
    /// </summary>
    public TextAlignmentBuilder Start => Chain(TextAlignmentEnum.Start);
    /// <summary>
    /// Sets the text alignment to center.
    /// </summary>
    public TextAlignmentBuilder Center => Chain(TextAlignmentEnum.Center);
    /// <summary>
    /// Sets the text alignment to end.
    /// </summary>
    public TextAlignmentBuilder End => Chain(TextAlignmentEnum.End);

    /// <summary>
    /// Applies the text alignment on phone breakpoint.
    /// </summary>
    public TextAlignmentBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the text alignment on small breakpoint (≥640px).
    /// </summary>
    public TextAlignmentBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the text alignment on tablet breakpoint.
    /// </summary>
    public TextAlignmentBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the text alignment on laptop breakpoint.
    /// </summary>
    public TextAlignmentBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the text alignment on desktop breakpoint.
    /// </summary>
    public TextAlignmentBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the text alignment on the 2xl breakpoint.
    /// </summary>
    public TextAlignmentBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextAlignmentBuilder Chain(TextAlignmentEnum value)
    {
        _rules.Add(new TextAlignmentRule(value.Value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextAlignmentBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            TextAlignmentRule rule = _rules[i];

            string baseClass = rule.Value;
            if (baseClass.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                baseClass = BreakpointUtil.ApplyTailwindBreakpoint(baseClass, bp);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(baseClass);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
