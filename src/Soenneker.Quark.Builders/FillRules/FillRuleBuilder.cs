
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
    private RuleList<FillRuleRule> _rules;
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

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            FillRuleRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                FillRuleRule rule = _rules[i];
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

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
