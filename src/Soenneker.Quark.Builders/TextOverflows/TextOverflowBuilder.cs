
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance text-overflow builder with fluent API for chaining rules.
/// </summary>
[TailwindPrefix("text-", Responsive = true)]
public sealed class TextOverflowBuilder : CssBuilderBase<TextOverflowBuilder>
{
    private RuleList<TextOverflowRule> _rules;

    internal TextOverflowBuilder()
    {
    }

    internal TextOverflowBuilder(TextOverflowEnum textOverflow, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextOverflowRule(textOverflow.Value, breakpoint));
    }

    internal TextOverflowBuilder(List<TextOverflowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    // ----- Fluent chaining (TextOverflow enum) -----
    /// <summary>
    /// Sets the text overflow to clip.
    /// </summary>
    public TextOverflowBuilder Clip => Chain(TextOverflowEnum.Clip);
    /// <summary>
    /// Sets the text overflow to ellipsis.
    /// </summary>
    public TextOverflowBuilder Ellipsis => Chain(TextOverflowEnum.Ellipsis);

    // ----- BreakpointType chaining -----

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextOverflowBuilder Chain(TextOverflowEnum value)
    {
        BreakpointType? breakpoint = null;
        _rules.Add(new TextOverflowRule(value.Value, breakpoint, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            TextOverflowRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                TextOverflowRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
