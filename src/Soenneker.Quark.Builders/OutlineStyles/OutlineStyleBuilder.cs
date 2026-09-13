
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Outline style builder. Tailwind: outline-none, outline, outline-dashed, outline-dotted, outline-double.
/// </summary>
[TailwindPrefix("outline-", Responsive = true)]
public sealed class OutlineStyleBuilder : CssBuilderBase<OutlineStyleBuilder>
{
    private RuleList<OutlineStyleRule> _rules;

    internal OutlineStyleBuilder()
    {
    }

    internal OutlineStyleBuilder(OutlineStyleEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new OutlineStyleRule(value, breakpoint));
    }

    internal OutlineStyleBuilder(List<OutlineStyleRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public OutlineStyleBuilder None => Chain(OutlineStyleEnum.None);
    /// <summary>
    /// Hides the outline while preserving forced-colors accessibility behavior. Tailwind: outline-hidden.
    /// </summary>
    public OutlineStyleBuilder Hidden => Chain(OutlineStyleEnum.Hidden);
    /// <summary>
    /// Fluent step for `Solid` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OutlineStyleBuilder Solid => Chain(OutlineStyleEnum.Solid);
    /// <summary>
    /// Fluent step for `Dashed` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OutlineStyleBuilder Dashed => Chain(OutlineStyleEnum.Dashed);
    /// <summary>
    /// Fluent step for `Dotted` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OutlineStyleBuilder Dotted => Chain(OutlineStyleEnum.Dotted);
    /// <summary>
    /// Fluent step for `Double` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OutlineStyleBuilder Double => Chain(OutlineStyleEnum.Double);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OutlineStyleBuilder Chain(OutlineStyleEnum value)
    {
        _rules.Add(new OutlineStyleRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            OutlineStyleRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                OutlineStyleRule rule = _rules[i];
                writer.Add(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
