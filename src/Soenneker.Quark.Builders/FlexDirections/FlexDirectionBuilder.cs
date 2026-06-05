using System;
using System.Collections.Generic;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the flex direction builder.
/// </summary>
[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexDirectionBuilder : ResponsiveUtilityBuilder<FlexDirectionBuilder>
{
    internal FlexDirectionBuilder()
    {
    }

    internal FlexDirectionBuilder(FlexDirectionEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal FlexDirectionBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public FlexDirectionBuilder Row => ChainValue(FlexDirectionEnum.RowValue);
    /// <summary>
    /// Gets or sets row reverse.
    /// </summary>
    public FlexDirectionBuilder RowReverse => ChainValue(FlexDirectionEnum.RowReverseValue);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public FlexDirectionBuilder Col => ChainValue(FlexDirectionEnum.ColValue);
    /// <summary>
    /// Gets or sets col reverse.
    /// </summary>
    public FlexDirectionBuilder ColReverse => ChainValue(FlexDirectionEnum.ColReverseValue);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public FlexDirectionBuilder Token(string value) => ChainValue("flex-" + value);

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (Rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < Rules.Count; i++)
        {
            UtilityRule rule = Rules[i];

            if (rule.Value.Length == 0)
                continue;

            string modifierChain = GetModifierChain(rule);

            if (!HasPreviousModifierChain(i, modifierChain))
            {
                string flexClass = modifierChain.Length == 0 ? "flex" : BreakpointUtil.ApplyTailwindModifiers("flex", modifierChain);

                if (!first)
                    sb.Append(' ');
                else
                    first = false;

                sb.Append(flexClass);
            }

            string cls = modifierChain.Length == 0 ? rule.Value : BreakpointUtil.ApplyTailwindModifiers(rule.Value, modifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    private bool HasPreviousModifierChain(int ruleIndex, string modifierChain)
    {
        for (var i = 0; i < ruleIndex; i++)
        {
            if (string.Equals(GetModifierChain(Rules[i]), modifierChain, StringComparison.Ordinal))
                return true;
        }

        return false;
    }

    private static string GetModifierChain(UtilityRule rule)
    {
        string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

        if (breakpoint.Length == 0)
            return rule.ModifierChain ?? string.Empty;

        return rule.ModifierChain is { Length: > 0 } ? $"{breakpoint}:{rule.ModifierChain}" : breakpoint;
    }
}
