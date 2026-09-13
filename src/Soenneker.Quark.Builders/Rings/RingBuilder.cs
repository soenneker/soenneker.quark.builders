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
    private RuleList<RingRule> _rules;

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
    public RingBuilder Default => Chain(RingEnum.DefaultValue);
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public RingBuilder None => Chain(RingEnum.NoneValue);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public RingBuilder Is1 => Chain(RingEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public RingBuilder Is2 => Chain(RingEnum.Is2Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public RingBuilder Is4 => Chain(RingEnum.Is4Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public RingBuilder Is8 => Chain(RingEnum.Is8Value);
    /// <summary>
    /// Fluent step for `Inset` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingBuilder Inset => Chain(RingEnum.InsetValue);

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
        if (_rules.Count == 1)
        {
            RingRule rule = _rules[0];
            return ClassWriter.Render(rule.Token, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                RingRule rule = _rules[i];
                writer.Add(rule.Token, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
