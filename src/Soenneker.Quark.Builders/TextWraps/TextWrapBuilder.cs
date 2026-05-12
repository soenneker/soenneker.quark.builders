
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance text wrap builder with fluent API for chaining text wrap rules.
/// </summary>
[TailwindPrefix("text-", Responsive = true)]
public sealed class TextWrapBuilder : CssBuilderBase<TextWrapBuilder>
{
    private readonly List<TextWrapRule> _rules = new(4);

    internal TextWrapBuilder()
    {
    }

    internal TextWrapBuilder(TextWrapEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextWrapRule(value.Value, breakpoint));
    }

    internal TextWrapBuilder(List<TextWrapRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the text wrap to wrap.
    /// </summary>
    public TextWrapBuilder Wrap => Chain(TextWrapEnum.Wrap);
    /// <summary>
    /// Sets the text wrap to balance.
    /// </summary>
    public TextWrapBuilder Balance => Chain(TextWrapEnum.Balance);
    /// <summary>
    /// Sets the text wrap to pretty.
    /// </summary>
    public TextWrapBuilder Pretty => Chain(TextWrapEnum.Pretty);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextWrapBuilder Chain(TextWrapEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new TextWrapRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }


    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            TextWrapRule rule = _rules[i];
            string cls = rule.Value;

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
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
