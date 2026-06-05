
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
    private readonly List<OutlineStyleRule> _rules = new(4);

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

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (OutlineStyleRule rule in _rules)
        {
            string cls = rule.Value.Value;
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
