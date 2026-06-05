
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// CSS contain builder. Tailwind: contain-none, contain-size, contain-layout, contain-style, contain-paint, contain-strict, contain-content.
/// </summary>
[TailwindPrefix("contain-", Responsive = true)]
public sealed class ContainBuilder : CssBuilderBase<ContainBuilder>
{
    private readonly List<ContainRule> _rules = new(4);

    internal ContainBuilder()
    {
    }

    internal ContainBuilder(ContainEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ContainRule(value, breakpoint));
    }

    internal ContainBuilder(List<ContainRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public ContainBuilder None => Chain(ContainEnum.None);
    /// <summary>
    /// Fluent step for `Size` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Size => Chain(ContainEnum.Size);
    /// <summary>
    /// Fluent step for `Layout` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Layout => Chain(ContainEnum.Layout);
    /// <summary>
    /// Fluent step for `Style` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Style => Chain(ContainEnum.Style);
    /// <summary>
    /// Fluent step for `Paint` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Paint => Chain(ContainEnum.Paint);
    /// <summary>
    /// Fluent step for `Strict` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Strict => Chain(ContainEnum.Strict);
    /// <summary>
    /// Fluent step for `Content` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Content => Chain(ContainEnum.Content);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ContainBuilder Chain(ContainEnum value)
    {
        _rules.Add(new ContainRule(value, null, ConsumePendingModifierChain()));
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
        foreach (ContainRule rule in _rules)
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
