
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
    private readonly List<TextBreakRule> _rules = new(4);

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
            TextBreakRule rule = _rules[i];
            string baseClass = rule.Value;
            if (baseClass.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                baseClass = BreakpointUtil.ApplyTailwindBreakpoint(baseClass, bp);

            if (rule.ModifierChain is { Length: > 0 })
                baseClass = BreakpointUtil.ApplyTailwindModifiers(baseClass, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(baseClass);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
