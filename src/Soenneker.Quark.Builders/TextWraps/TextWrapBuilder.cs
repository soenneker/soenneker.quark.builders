
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance text wrap builder with fluent API for chaining text wrap rules.
/// </summary>
[TailwindPrefix("text-", Responsive = true)]
public sealed class TextWrapBuilder : ICssBuilder
{
    private readonly List<TextWrapRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal TextWrapBuilder(TextWrapEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextWrapRule(value.Value, breakpoint));
    }

    internal TextWrapBuilder(List<TextWrapRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the text wrap to wrap.
    /// </summary>
    public TextWrapBuilder Wrap => Chain(TextWrapEnum.Wrap);
    /// <summary>
    /// Sets the text wrap to balance.
    /// </summary>
    public TextWrapBuilder Balance => Chain(TextWrapEnum.Balance);
    /// <summary>
    /// Sets the text wrap to pretty.
    /// </summary>
    public TextWrapBuilder Pretty => Chain(TextWrapEnum.Pretty);
    /// <summary>
    /// Applies the text wrap on phone breakpoint.
    /// </summary>
    public TextWrapBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the text wrap on small breakpoint (≥640px).
    /// </summary>
    public TextWrapBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the text wrap on tablet breakpoint.
    /// </summary>
    public TextWrapBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the text wrap on laptop breakpoint.
    /// </summary>
    public TextWrapBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the text wrap on desktop breakpoint.
    /// </summary>
    public TextWrapBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the text wrap on the 2xl breakpoint.
    /// </summary>
    public TextWrapBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextWrapBuilder Chain(TextWrapEnum value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new TextWrapRule(value.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextWrapBuilder SetPendingBreakpoint(BreakpointType bp)
    {
        _pendingBreakpoint = bp;
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            TextWrapRule rule = _rules[i];
            string cls = rule.Value;

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

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
