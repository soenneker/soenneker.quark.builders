
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind text break utility builder.
/// </summary>
[TailwindPrefix("break-", Responsive = true)]
public sealed class TextBreakBuilder : CssBuilderBase<TextBreakBuilder>
{
    private RuleList<TextBreakRule> _rules;

    internal TextBreakBuilder()
    {
    }

    internal TextBreakBuilder(TextBreakEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextBreakRule(value.Value, breakpoint));
    }

    internal TextBreakBuilder(List<TextBreakRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets normal line breaking.
    /// </summary>
    public TextBreakBuilder Normal => Chain(TextBreakEnum.Normal);
    /// <summary>
    /// Breaks words when needed.
    /// </summary>
    public TextBreakBuilder Words => Chain(TextBreakEnum.Words);
    /// <summary>
    /// Breaks at any character.
    /// </summary>
    public TextBreakBuilder All => Chain(TextBreakEnum.All);
    /// <summary>
    /// Prevents breaks in CJK text.
    /// </summary>
    public TextBreakBuilder Keep => Chain(TextBreakEnum.Keep);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextBreakBuilder Chain(TextBreakEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new TextBreakRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            TextBreakRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                TextBreakRule rule = _rules[i];
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
