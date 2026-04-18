
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance box shadow builder with fluent API for chaining box shadow rules.
/// </summary>
[TailwindPrefix("shadow-", Responsive = true)]
public sealed class BoxShadowBuilder : CssBuilderBase
{
    private readonly List<BoxShadowRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal BoxShadowBuilder(BoxShadowEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BoxShadowRule(value.Value, breakpoint));
    }

    internal BoxShadowBuilder(List<BoxShadowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the box shadow to none.
    /// </summary>
    public BoxShadowBuilder None => Chain(BoxShadowEnum.None);

    /// <summary>
    /// Sets the box shadow to extra small.
    /// </summary>
    public BoxShadowBuilder Xs => Chain(BoxShadowEnum.Xs);

    /// <summary>
    /// Sets the box shadow to small.
    /// </summary>
    public BoxShadowBuilder Sm => Chain(BoxShadowEnum.Sm);

    /// <summary>
    /// Sets the box shadow to the default value.
    /// </summary>
    public BoxShadowBuilder Default => Chain(BoxShadowEnum.Default);

    /// <summary>
    /// Sets the box shadow to medium.
    /// </summary>
    public BoxShadowBuilder Md => Chain(BoxShadowEnum.Md);

    /// <summary>
    /// Sets the box shadow to large.
    /// </summary>
    public BoxShadowBuilder Lg => Chain(BoxShadowEnum.Lg);

    /// <summary>
    /// Sets the box shadow to extra large.
    /// </summary>
    public BoxShadowBuilder Xl => Chain(BoxShadowEnum.Xl);

    /// <summary>
    /// Sets the box shadow to 2x extra large.
    /// </summary>
    public BoxShadowBuilder TwoXl => Chain(BoxShadowEnum.TwoXl);

    /// <summary>
    /// Sets the box shadow to inner.
    /// </summary>
    public BoxShadowBuilder Inner => Chain(BoxShadowEnum.Inner);

    /// <summary>
    /// Applies the box shadow on phone breakpoint.
    /// </summary>
    public BoxShadowBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);

    /// <summary>
    /// Applies the box shadow on small breakpoint (≥640px).
    /// </summary>
    public BoxShadowBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);

    /// <summary>
    /// Applies the box shadow on tablet breakpoint.
    /// </summary>
    public BoxShadowBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);

    /// <summary>
    /// Applies the box shadow on laptop breakpoint.
    /// </summary>
    public BoxShadowBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);

    /// <summary>
    /// Applies the box shadow on desktop breakpoint.
    /// </summary>
    public BoxShadowBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);

    /// <summary>
    /// Applies the box shadow on the 2xl breakpoint.
    /// </summary>
    public BoxShadowBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BoxShadowBuilder Chain(BoxShadowEnum value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new BoxShadowRule(value.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BoxShadowBuilder SetPendingBreakpoint(BreakpointType bp)
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
            BoxShadowRule rule = _rules[i];
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
