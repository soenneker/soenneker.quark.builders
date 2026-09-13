
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance text transform builder with fluent API for chaining text transform rules.
/// </summary>
[TailwindPrefix("uppercase", Responsive = true)]
public sealed class TextTransformBuilder : CssBuilderBase<TextTransformBuilder>
{
    private RuleList<TextTransformRule> _rules;

    internal TextTransformBuilder()
    {
    }

    internal TextTransformBuilder(TextTransformEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextTransformRule(value.Value, breakpoint));
    }

    internal TextTransformBuilder(List<TextTransformRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the text transform to lowercase.
    /// </summary>
    public TextTransformBuilder Lowercase => Chain(TextTransformEnum.Lowercase);
    /// <summary>
    /// Sets the text transform to uppercase.
    /// </summary>
    public TextTransformBuilder Uppercase => Chain(TextTransformEnum.Uppercase);
    /// <summary>
    /// Sets the text transform to capitalize.
    /// </summary>
    public TextTransformBuilder Capitalize => Chain(TextTransformEnum.Capitalize);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextTransformBuilder Chain(TextTransformEnum value)
    {
        _rules.Add(new TextTransformRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            TextTransformRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                TextTransformRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
