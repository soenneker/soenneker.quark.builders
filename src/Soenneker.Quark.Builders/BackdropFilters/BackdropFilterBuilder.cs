using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified backdrop filter builder with fluent API for chaining backdrop filter rules.
/// </summary>
[TailwindPrefix("backdrop-", Responsive = true)]
public sealed class BackdropFilterBuilder : CssBuilderBase<BackdropFilterBuilder>
{
    private RuleList<BackdropFilterRule> _rules;

    internal BackdropFilterBuilder()
    {
    }

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
    /// Applies an exact Tailwind backdrop-filter utility token, e.g. "blur-xl" or "backdrop-blur-xl".
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public BackdropFilterBuilder Token(string token) => ChainWithFilter(BackdropFilter.NormalizeToken(token));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackdropFilterBuilder ChainWithFilter(BackdropFilterEnum filter)
    {
        return ChainWithFilter(filter.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackdropFilterBuilder ChainWithFilter(string filter)
    {
        _rules.Add(new BackdropFilterRule(filter, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            BackdropFilterRule rule = _rules[0];
            return ClassWriter.Render(rule.Filter, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                BackdropFilterRule rule = _rules[i];
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
    /// Returns the CSS class string representation of this backdrop filter builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
