using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind ring utility builder.
/// </summary>
[TailwindPrefix("ring-", Responsive = true)]
public sealed class RingBuilder : CssBuilderBase<RingBuilder>
{
    private readonly List<RingRule> _rules = new(4);

    internal RingBuilder()
    {
    }

    internal RingBuilder(string token, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RingRule(token, breakpoint));
    }

    internal RingBuilder(RingEnum token, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RingRule(token.Value, breakpoint));
    }

    internal RingBuilder(List<RingRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Default theme radius: `rounded` with no suffix — in Tailwind’s default config typically `0.25rem` (maps to shadcn `--radius` usage when you align tokens).
    /// </summary>
    public RingBuilder Default => Chain(RingEnum.Default);
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public RingBuilder None => Chain(RingEnum.None);
    public RingBuilder Is1 => Chain(RingEnum.Is1);
    public RingBuilder Is2 => Chain(RingEnum.Is2);
    public RingBuilder Is4 => Chain(RingEnum.Is4);
    public RingBuilder Is8 => Chain(RingEnum.Is8);
    /// <summary>
    /// Fluent step for `Inset` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingBuilder Inset => Chain(RingEnum.Inset);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingBuilder Chain(string token)
    {
        _rules.Add(new RingRule(token, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingBuilder Chain(RingEnum token)
    {
        _rules.Add(new RingRule(token.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            RingRule rule = _rules[i];
            string cls = rule.Token;
            if (cls.Length == 0)
                continue;

            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);

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

    public override string ToStyle() => string.Empty;

}
