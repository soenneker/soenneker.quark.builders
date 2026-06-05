
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// SVG fill-rule builder. Tailwind: fill-rule-evenodd, fill-rule-nonzero.
/// </summary>
[TailwindPrefix("fill-rule-", Responsive = true)]
public sealed class FillRuleBuilder : CssBuilderBase<FillRuleBuilder>
{
    private readonly List<FillRuleRule> _rules = new(4);
    internal FillRuleBuilder()
    {
    }

    internal FillRuleBuilder(FillRuleEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FillRuleRule(value.Value, breakpoint));
    }

    internal FillRuleBuilder(List<FillRuleRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `Evenodd` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FillRuleBuilder Evenodd => Chain(FillRuleEnum.Evenodd);
    /// <summary>
    /// Fluent step for `Nonzero` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FillRuleBuilder Nonzero => Chain(FillRuleEnum.Nonzero);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FillRuleBuilder Chain(FillRuleEnum value)
    {
        _rules.Add(new FillRuleRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (FillRuleRule rule in _rules)
        {
            string cls = rule.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
