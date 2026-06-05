
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
    private readonly List<WhitespaceRule> _rules = new(4);

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
    public WhitespaceBuilder Normal => Chain(WhitespaceEnum.Normal);

    /// <summary>
    /// Sets the whitespace to nowrap.
    /// </summary>
    public WhitespaceBuilder Nowrap => Chain(WhitespaceEnum.Nowrap);

    /// <summary>
    /// Sets the whitespace to pre.
    /// </summary>
    public WhitespaceBuilder Pre => Chain(WhitespaceEnum.Pre);

    /// <summary>
    /// Sets the whitespace to pre-line.
    /// </summary>
    public WhitespaceBuilder PreLine => Chain(WhitespaceEnum.PreLine);

    /// <summary>
    /// Sets the whitespace to pre-wrap.
    /// </summary>
    public WhitespaceBuilder PreWrap => Chain(WhitespaceEnum.PreWrap);

    /// <summary>
    /// Sets the whitespace to break-spaces.
    /// </summary>
    public WhitespaceBuilder BreakSpaces => Chain(WhitespaceEnum.BreakSpaces);


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


    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            WhitespaceRule rule = _rules[i];
            string cls = rule.Value;

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
