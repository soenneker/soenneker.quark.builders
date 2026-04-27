
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance shadow builder with fluent API for chaining shadow rules.
/// </summary>
[TailwindPrefix("shadow-", Responsive = true)]
public sealed class ShadowBuilder : CssBuilderBase
{
    private readonly List<ShadowRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal ShadowBuilder(ShadowKeyword value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ShadowRule(value.Value, breakpoint));
    }

    internal ShadowBuilder(List<ShadowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the shadow to none.
    /// </summary>
    public ShadowBuilder None => Chain(ShadowKeyword.None);

    /// <summary>
    /// Sets the shadow to extra small.
    /// </summary>
    public ShadowBuilder Xs => Chain(ShadowKeyword.Xs);

    /// <summary>
    /// Sets the shadow to small.
    /// </summary>
    public ShadowBuilder Sm => Chain(ShadowKeyword.Sm);

    /// <summary>
    /// Sets the shadow to the default value.
    /// </summary>
    public ShadowBuilder Default => Chain(ShadowKeyword.Default);

    /// <summary>
    /// Sets the shadow to medium.
    /// </summary>
    public ShadowBuilder Md => Chain(ShadowKeyword.Md);

    /// <summary>
    /// Sets the shadow to large.
    /// </summary>
    public ShadowBuilder Lg => Chain(ShadowKeyword.Lg);

    /// <summary>
    /// Sets the shadow to extra large.
    /// </summary>
    public ShadowBuilder Xl => Chain(ShadowKeyword.Xl);

    /// <summary>
    /// Sets the shadow to 2x extra large.
    /// </summary>
    public ShadowBuilder TwoXl => Chain(ShadowKeyword.TwoXl);

    /// <summary>
    /// Sets the shadow to inner.
    /// </summary>
    public ShadowBuilder Inner => Chain(ShadowKeyword.Inner);

    /// <summary>
    /// Applies the shadow on phone breakpoint.
    /// </summary>
    public ShadowBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);

    /// <summary>
    /// Applies the shadow on small breakpoint (≥640px).
    /// </summary>
    public ShadowBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);

    /// <summary>
    /// Applies the shadow on tablet breakpoint.
    /// </summary>
    public ShadowBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);

    /// <summary>
    /// Applies the shadow on laptop breakpoint.
    /// </summary>
    public ShadowBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);

    /// <summary>
    /// Applies the shadow on desktop breakpoint.
    /// </summary>
    public ShadowBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);

    /// <summary>
    /// Applies the shadow on the 2xl breakpoint.
    /// </summary>
    public ShadowBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ShadowBuilder Chain(ShadowKeyword value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new ShadowRule(value.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ShadowBuilder SetPendingBreakpoint(BreakpointType bp)
    {
        _pendingBreakpoint = bp;
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
            ShadowRule rule = _rules[i];
            string cssClass = rule.Value;

            if (cssClass.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cssClass = BreakpointUtil.ApplyTailwindBreakpoint(cssClass, bp);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cssClass);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// Shadow utilities are class-first; no inline style mapping.
    /// </summary>
    /// <returns>An empty string as shadow utilities are class-first.</returns>
    public override string ToStyle() => string.Empty;
}
