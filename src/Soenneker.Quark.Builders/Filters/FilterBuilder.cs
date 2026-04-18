using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified filter builder with fluent API for chaining filter rules.
/// </summary>
[TailwindPrefix("filter", Responsive = true)]
public sealed class FilterBuilder : CssBuilderBase
{
    private readonly List<FilterRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal FilterBuilder(string filter, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FilterRule(filter, breakpoint));
    }

    internal FilterBuilder(FilterEnum filter, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FilterRule(filter.Value, breakpoint));
    }

    internal FilterBuilder(List<FilterRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the filter to none.
    /// </summary>
    public FilterBuilder None => ChainWithFilter(FilterEnum.None);
    /// <summary>
    /// Sets the filter to blur.
    /// </summary>
    public FilterBuilder Blur => ChainWithFilter(FilterEnum.Blur);
    /// <summary>
    /// Sets the filter to brightness.
    /// </summary>
    public FilterBuilder Brightness => ChainWithFilter(FilterEnum.Brightness);
    /// <summary>
    /// Sets the filter to contrast.
    /// </summary>
    public FilterBuilder Contrast => ChainWithFilter(FilterEnum.Contrast);
    /// <summary>
    /// Sets the filter to drop-shadow.
    /// </summary>
    public FilterBuilder DropShadow => ChainWithFilter(FilterEnum.DropShadow);
    /// <summary>
    /// Sets the filter to grayscale.
    /// </summary>
    public FilterBuilder Grayscale => ChainWithFilter(FilterEnum.Grayscale);
    /// <summary>
    /// Sets the filter to hue-rotate.
    /// </summary>
    public FilterBuilder HueRotate => ChainWithFilter(FilterEnum.HueRotate);
    /// <summary>
    /// Sets the filter to invert.
    /// </summary>
    public FilterBuilder Invert => ChainWithFilter(FilterEnum.Invert);
    /// <summary>
    /// Sets the filter to opacity.
    /// </summary>
    public FilterBuilder Opacity => ChainWithFilter(FilterEnum.Opacity);
    /// <summary>
    /// Sets the filter to saturate.
    /// </summary>
    public FilterBuilder Saturate => ChainWithFilter(FilterEnum.Saturate);
    /// <summary>
    /// Sets the filter to sepia.
    /// </summary>
    public FilterBuilder Sepia => ChainWithFilter(FilterEnum.Sepia);

    /// <summary>
    /// Applies an exact Tailwind filter utility token, e.g. "blur-xs".
    /// </summary>
    public FilterBuilder Token(string token) => ChainWithFilter(token);

    /// <summary>
    /// Applies the filter on phone breakpoint.
    /// </summary>
    public FilterBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the filter on small breakpoint (≥640px).
    /// </summary>
    public FilterBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the filter on tablet breakpoint.
    /// </summary>
    public FilterBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the filter on laptop breakpoint.
    /// </summary>
    public FilterBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the filter on desktop breakpoint.
    /// </summary>
    public FilterBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the filter on the 2xl breakpoint.
    /// </summary>
    public FilterBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FilterBuilder ChainWithFilter(string filter)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new FilterRule(filter, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FilterBuilder ChainWithFilter(FilterEnum filter)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new FilterRule(filter.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FilterBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
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
            FilterRule rule = _rules[i];
            string cls = rule.Filter;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointClass(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this filter builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
