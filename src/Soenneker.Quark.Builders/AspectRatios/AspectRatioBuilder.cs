
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified aspect ratio builder with fluent API for chaining aspect ratio rules.
/// </summary>
[TailwindPrefix("aspect-", Responsive = true)]
public sealed class AspectRatioBuilder : CssBuilderBase<AspectRatioBuilder>
{
    private RuleList<AspectRatioRule> _rules;

    internal AspectRatioBuilder()
    {
    }

    internal AspectRatioBuilder(string ratio, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AspectRatioRule(ratio, breakpoint));
    }

    internal AspectRatioBuilder(AspectRatioEnum ratio, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AspectRatioRule(ratio.Value, breakpoint));
    }

    internal AspectRatioBuilder(List<AspectRatioRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the aspect ratio to 1:1 (square).
    /// </summary>
    public AspectRatioBuilder R1X1 => ChainWithRatio(AspectRatioEnum.R1X1Value);
    /// <summary>
    /// Sets the aspect ratio to 4:3.
    /// </summary>
    public AspectRatioBuilder R4X3 => ChainWithRatio(AspectRatioEnum.R4X3Value);
    /// <summary>
    /// Sets the aspect ratio to 16:9.
    /// </summary>
    public AspectRatioBuilder R16X9 => ChainWithRatio(AspectRatioEnum.R16X9Value);
    /// <summary>
    /// Sets the aspect ratio to 21:9.
    /// </summary>
    public AspectRatioBuilder R21X9 => ChainWithRatio(AspectRatioEnum.R21X9Value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AspectRatioBuilder ChainWithRatio(string ratio)
    {
        _rules.Add(new AspectRatioRule(ratio, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AspectRatioBuilder ChainWithRatio(AspectRatioEnum ratio)
    {
        _rules.Add(new AspectRatioRule(ratio.Value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            AspectRatioRule rule = _rules[0];
            return ClassWriter.Render(rule.Ratio, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                AspectRatioRule rule = _rules[i];
                writer.Add(rule.Ratio, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// Returns the CSS class string representation of this aspect ratio builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
