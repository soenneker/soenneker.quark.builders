using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified filter builder with fluent API for chaining filter rules.
/// </summary>
[TailwindPrefix("filter", Responsive = true)]
public sealed class FilterBuilder : CssBuilderBase<FilterBuilder>
{
    private RuleList<FilterRule> _rules;

    internal FilterBuilder()
    {
    }

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
    public FilterBuilder None => ChainWithFilter(FilterEnum.NoneValue);
    /// <summary>
    /// Sets the filter to blur.
    /// </summary>
    public FilterBuilder Blur => ChainWithFilter(FilterEnum.BlurValue);
    /// <summary>
    /// Sets the filter to brightness.
    /// </summary>
    public FilterBuilder Brightness => ChainWithFilter(FilterEnum.BrightnessValue);
    /// <summary>
    /// Sets the filter to contrast.
    /// </summary>
    public FilterBuilder Contrast => ChainWithFilter(FilterEnum.ContrastValue);
    /// <summary>
    /// Sets the filter to drop-shadow.
    /// </summary>
    public FilterBuilder DropShadow => ChainWithFilter(FilterEnum.DropShadowValue);
    /// <summary>
    /// Sets the filter to grayscale.
    /// </summary>
    public FilterBuilder Grayscale => ChainWithFilter(FilterEnum.GrayscaleValue);
    /// <summary>
    /// Sets the filter to hue-rotate.
    /// </summary>
    public FilterBuilder HueRotate => ChainWithFilter(FilterEnum.HueRotateValue);
    /// <summary>
    /// Sets the filter to invert.
    /// </summary>
    public FilterBuilder Invert => ChainWithFilter(FilterEnum.InvertValue);
    /// <summary>
    /// Sets the filter to opacity.
    /// </summary>
    public FilterBuilder Opacity => ChainWithFilter(FilterEnum.OpacityValue);
    /// <summary>
    /// Sets the filter to saturate.
    /// </summary>
    public FilterBuilder Saturate => ChainWithFilter(FilterEnum.SaturateValue);
    /// <summary>
    /// Sets the filter to sepia.
    /// </summary>
    public FilterBuilder Sepia => ChainWithFilter(FilterEnum.SepiaValue);

    /// <summary>
    /// Applies an exact Tailwind filter utility token, e.g. "blur-xs".
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FilterBuilder Token(string token) => ChainWithFilter(token);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FilterBuilder ChainWithFilter(string filter)
    {
        _rules.Add(new FilterRule(filter, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FilterBuilder ChainWithFilter(FilterEnum filter)
    {
        _rules.Add(new FilterRule(filter.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            FilterRule rule = _rules[0];
            return ClassWriter.Render(rule.Filter, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                FilterRule rule = _rules[i];
                writer.Add(rule.Filter, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// Returns the CSS class string representation of this filter builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
