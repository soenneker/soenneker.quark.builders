
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance font weight builder with fluent API for chaining font weight rules.
/// </summary>
[TailwindPrefix("font-", Responsive = true)]
public sealed class FontWeightBuilder : ICssBuilder
{
    private readonly List<FontWeightRule> _rules = new(6);
    private BreakpointType? _pendingBreakpoint;

    internal FontWeightBuilder(FontWeightEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontWeightRule(value, breakpoint));
    }

    internal FontWeightBuilder(List<FontWeightRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the font weight to extralight.
    /// </summary>
    public FontWeightBuilder Extralight => Chain(FontWeightEnum.Extralight);
    /// <summary>
    /// Sets the font weight to light.
    /// </summary>
    public FontWeightBuilder Light => Chain(FontWeightEnum.Light);
    /// <summary>
    /// Sets the font weight to normal.
    /// </summary>
    public FontWeightBuilder Normal => Chain(FontWeightEnum.Normal);
    /// <summary>
    /// Sets the font weight to medium.
    /// </summary>
    public FontWeightBuilder Medium => Chain(FontWeightEnum.Medium);
    /// <summary>
    /// Sets the font weight to semibold.
    /// </summary>
    public FontWeightBuilder Semibold => Chain(FontWeightEnum.Semibold);
    /// <summary>
    /// Sets the font weight to bold.
    /// </summary>
    public FontWeightBuilder Bold => Chain(FontWeightEnum.Bold);
    /// <summary>
    /// Sets the font weight to extrabold.
    /// </summary>
    public FontWeightBuilder Extrabold => Chain(FontWeightEnum.Extrabold);
    /// <summary>
    /// Applies the font weight on phone breakpoint.
    /// </summary>
    public FontWeightBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);

    /// <summary>
    /// Applies the font weight on small breakpoint (≥640px).
    /// </summary>
    public FontWeightBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);

    /// <summary>
    /// Applies the font weight on tablet breakpoint.
    /// </summary>
    public FontWeightBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);

    /// <summary>
    /// Applies the font weight on laptop breakpoint.
    /// </summary>
    public FontWeightBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);

    /// <summary>
    /// Applies the font weight on desktop breakpoint.
    /// </summary>
    public FontWeightBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);

    /// <summary>
    /// Applies the font weight on the 2xl breakpoint.
    /// </summary>
    public FontWeightBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontWeightBuilder Chain(FontWeightEnum value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new FontWeightRule(value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontWeightBuilder SetPendingBreakpoint(BreakpointType bp)
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
            FontWeightRule rule = _rules[i];
            string cls = rule.Value.Value;
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
