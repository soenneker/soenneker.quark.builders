
using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind whitespace utility builder.
/// </summary>
[TailwindPrefix("whitespace-", Responsive = true)]
public sealed class WhitespaceBuilder : CssBuilderBase<WhitespaceBuilder>
{
    private RuleList<WhitespaceRule> _rules;

    internal WhitespaceBuilder()
    {
    }

    internal WhitespaceBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new WhitespaceRule(value, breakpoint));
    }

    internal WhitespaceBuilder(WhitespaceEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new WhitespaceRule(value.Value, breakpoint));
    }

    internal WhitespaceBuilder(List<WhitespaceRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the whitespace to normal.
    /// </summary>
    public WhitespaceBuilder Normal => Chain(WhitespaceEnum.NormalValue);

    /// <summary>
    /// Sets the whitespace to nowrap.
    /// </summary>
    public WhitespaceBuilder Nowrap => Chain(WhitespaceEnum.NowrapValue);

    /// <summary>
    /// Sets the whitespace to pre.
    /// </summary>
    public WhitespaceBuilder Pre => Chain(WhitespaceEnum.PreValue);

    /// <summary>
    /// Sets the whitespace to pre-line.
    /// </summary>
    public WhitespaceBuilder PreLine => Chain(WhitespaceEnum.PreLineValue);

    /// <summary>
    /// Sets the whitespace to pre-wrap.
    /// </summary>
    public WhitespaceBuilder PreWrap => Chain(WhitespaceEnum.PreWrapValue);

    /// <summary>
    /// Sets the whitespace to break-spaces.
    /// </summary>
    public WhitespaceBuilder BreakSpaces => Chain(WhitespaceEnum.BreakSpacesValue);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private WhitespaceBuilder Chain(string value)
    {
        BreakpointType? bp = null;
        _rules.Add(new WhitespaceRule(value, bp, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private WhitespaceBuilder Chain(WhitespaceEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new WhitespaceRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }


    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            WhitespaceRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                WhitespaceRule rule = _rules[i];
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
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
