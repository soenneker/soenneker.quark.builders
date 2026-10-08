
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind word break utility builder.
/// </summary>
[TailwindPrefix("break-", Responsive = true)]
public sealed class WordBreakBuilder : CssBuilderBase<WordBreakBuilder>
{
    private RuleList<WordBreakRule> _rules;

    internal WordBreakBuilder()
    {
    }

    internal WordBreakBuilder(WordBreakEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new WordBreakRule(value.Value, breakpoint));
    }

    internal WordBreakBuilder(List<WordBreakRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets normal line breaking.
    /// </summary>
    public WordBreakBuilder Normal => Chain(WordBreakEnum.Normal);
    /// <summary>
    /// Breaks at any character.
    /// </summary>
    public WordBreakBuilder All => Chain(WordBreakEnum.All);
    /// <summary>
    /// Prevents breaks in CJK text.
    /// </summary>
    public WordBreakBuilder Keep => Chain(WordBreakEnum.Keep);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private WordBreakBuilder Chain(WordBreakEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new WordBreakRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            WordBreakRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                WordBreakRule rule = _rules[i];
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
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
