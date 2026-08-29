using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind overscroll-behavior builder supporting both axis-specific and global utilities.
/// </summary>
[TailwindPrefix("overscroll-", Responsive = true)]
public sealed class OverscrollBuilder : CssBuilderBase<OverscrollBuilder>
{
    private readonly List<OverscrollRule> _rules = new(4);

    internal OverscrollBuilder()
    {
    }

    internal OverscrollBuilder(OverscrollEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new OverscrollRule(value.Value, breakpoint));
    }

    internal OverscrollBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new OverscrollRule(value, breakpoint));
    }

    internal OverscrollBuilder(List<OverscrollRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public OverscrollBuilder Auto => Chain(OverscrollEnum.Auto);
    /// <summary>
    /// Fluent step for `Contain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder Contain => Chain(OverscrollEnum.Contain);
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public OverscrollBuilder None => Chain(OverscrollEnum.None);

    /// <summary>
    /// Fluent step for `XAuto` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder XAuto => Chain(OverscrollEnum.XAuto);
    /// <summary>
    /// Fluent step for `XContain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder XContain => Chain(OverscrollEnum.XContain);
    /// <summary>
    /// Fluent step for `XNone` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder XNone => Chain(OverscrollEnum.XNone);

    /// <summary>
    /// Fluent step for `YAuto` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder YAuto => Chain(OverscrollEnum.YAuto);
    /// <summary>
    /// Fluent step for `YContain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder YContain => Chain(OverscrollEnum.YContain);
    /// <summary>
    /// Fluent step for `YNone` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder YNone => Chain(OverscrollEnum.YNone);

    /// <summary>
    /// Applies an exact Tailwind overscroll class token, e.g. "overscroll-none".
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public OverscrollBuilder Token(string token) => Chain(token);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OverscrollBuilder Chain(OverscrollEnum value)
    {
        return Chain(value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OverscrollBuilder Chain(string value)
    {
        _rules.Add(new OverscrollRule(value, null, ConsumePendingModifierChain()));
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
            OverscrollRule rule = _rules[i];
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

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
