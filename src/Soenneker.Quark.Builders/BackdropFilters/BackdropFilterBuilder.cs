using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified backdrop filter builder with fluent API for chaining backdrop filter rules.
/// </summary>
[TailwindPrefix("backdrop-", Responsive = true)]
public sealed class BackdropFilterBuilder : CssBuilderBase
{
    private readonly List<BackdropFilterRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal BackdropFilterBuilder(BackdropFilterEnum filter, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BackdropFilterRule(filter.Value, breakpoint));
    }

    internal BackdropFilterBuilder(string filter, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BackdropFilterRule(filter, breakpoint));
    }

    internal BackdropFilterBuilder(List<BackdropFilterRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the backdrop filter to none.
    /// </summary>
    public BackdropFilterBuilder None => ChainWithFilter(BackdropFilterEnum.None);
    /// <summary>
    /// Sets the backdrop filter to blur.
    /// </summary>
    public BackdropFilterBuilder Blur => ChainWithFilter(BackdropFilterEnum.Blur);
    /// <summary>
    /// Sets the backdrop filter to brightness.
    /// </summary>
    public BackdropFilterBuilder Brightness => ChainWithFilter(BackdropFilterEnum.Brightness);
    /// <summary>
    /// Sets the backdrop filter to contrast.
    /// </summary>
    public BackdropFilterBuilder Contrast => ChainWithFilter(BackdropFilterEnum.Contrast);
    /// <summary>
    /// Sets the backdrop filter to grayscale.
    /// </summary>
    public BackdropFilterBuilder Grayscale => ChainWithFilter(BackdropFilterEnum.Grayscale);
    /// <summary>
    /// Sets the backdrop filter to hue-rotate.
    /// </summary>
    public BackdropFilterBuilder HueRotate => ChainWithFilter(BackdropFilterEnum.HueRotate);
    /// <summary>
    /// Sets the backdrop filter to invert.
    /// </summary>
    public BackdropFilterBuilder Invert => ChainWithFilter(BackdropFilterEnum.Invert);
    /// <summary>
    /// Sets the backdrop filter to opacity.
    /// </summary>
    public BackdropFilterBuilder Opacity => ChainWithFilter(BackdropFilterEnum.Opacity);
    /// <summary>
    /// Sets the backdrop filter to saturate.
    /// </summary>
    public BackdropFilterBuilder Saturate => ChainWithFilter(BackdropFilterEnum.Saturate);
    /// <summary>
    /// Sets the backdrop filter to sepia.
    /// </summary>
    public BackdropFilterBuilder Sepia => ChainWithFilter(BackdropFilterEnum.Sepia);

    /// <summary>
    /// Applies an exact Tailwind backdrop-filter utility token, e.g. "backdrop-blur".
    /// </summary>
    public BackdropFilterBuilder Token(string token) => ChainWithFilter(token);

    /// <summary>
    /// Applies the backdrop filter on phone breakpoint.
    /// </summary>
    public BackdropFilterBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the backdrop filter on small breakpoint (≥640px).
    /// </summary>
    public BackdropFilterBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the backdrop filter on tablet breakpoint.
    /// </summary>
    public BackdropFilterBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the backdrop filter on laptop breakpoint.
    /// </summary>
    public BackdropFilterBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the backdrop filter on desktop breakpoint.
    /// </summary>
    public BackdropFilterBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the backdrop filter on the 2xl breakpoint.
    /// </summary>
    public BackdropFilterBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackdropFilterBuilder ChainWithFilter(BackdropFilterEnum filter)
    {
        return ChainWithFilter(filter.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackdropFilterBuilder ChainWithFilter(string filter)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new BackdropFilterRule(filter, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackdropFilterBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
            BackdropFilterRule rule = _rules[i];
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
    /// Returns the CSS class string representation of this backdrop filter builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
