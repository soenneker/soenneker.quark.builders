
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// High-performance font style builder with fluent API for chaining font style rules.
/// </summary>
[TailwindPrefix("italic", Responsive = true)]
public sealed class FontStyleBuilder : ICssBuilder
{
    private readonly List<FontStyleRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal FontStyleBuilder(FontStyleEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontStyleRule(value, breakpoint));
    }

    internal FontStyleBuilder(List<FontStyleRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the font style to italic.
    /// </summary>
    public FontStyleBuilder Italic => Chain(FontStyleEnum.Italic);
    /// <summary>
    /// Sets the font style to normal.
    /// </summary>
    public FontStyleBuilder Normal => Chain(FontStyleEnum.Normal);
    /// <summary>
    /// Applies the font style on phone breakpoint.
    /// </summary>
    public FontStyleBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the font style on small breakpoint (≥640px).
    /// </summary>
    public FontStyleBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the font style on tablet breakpoint.
    /// </summary>
    public FontStyleBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the font style on laptop breakpoint.
    /// </summary>
    public FontStyleBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the font style on desktop breakpoint.
    /// </summary>
    public FontStyleBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the font style on the 2xl breakpoint.
    /// </summary>
    public FontStyleBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontStyleBuilder Chain(FontStyleEnum value)
    {
        _rules.Add(new FontStyleRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontStyleBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            FontStyleRule rule = _rules[i];
            string cls;
            if (ReferenceEquals(rule.Value, FontStyleEnum.Italic))
                cls = FontStyleEnum.ItalicValue;
            else if (ReferenceEquals(rule.Value, FontStyleEnum.Normal))
                cls = FontStyleEnum.NormalValue;
            else
                cls = string.Empty;
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
