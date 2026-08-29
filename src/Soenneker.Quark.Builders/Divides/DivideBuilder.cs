using System.Runtime.CompilerServices;
using System.Collections.Generic;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the divide builder.
/// </summary>
[TailwindPrefix("divide-", Responsive = true)]
public sealed class DivideBuilder : CssBuilderBase<DivideBuilder>
{
    private readonly List<DivideRule> _rules = new(8);

    internal DivideBuilder()
    {
    }

    internal DivideBuilder(DivideEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new DivideRule(value.Value, breakpoint));
    }

    internal DivideBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new DivideRule(value, breakpoint));
    }

    /// <summary>
    /// Fluent step for `X` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public DivideBuilder X => Chain(DivideEnum.X);
    /// <summary>
    /// Fluent step for `Y` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public DivideBuilder Y => Chain(DivideEnum.Y);
    /// <summary>
    /// Fluent step for `XReverse` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public DivideBuilder XReverse => Chain(DivideEnum.XReverse);
    /// <summary>
    /// Fluent step for `YReverse` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public DivideBuilder YReverse => Chain(DivideEnum.YReverse);
    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public DivideBuilder Primary => Chain(DivideEnum.Primary);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public DivideBuilder Secondary => Chain(DivideEnum.Secondary);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public DivideBuilder Destructive => Chain(DivideEnum.Destructive);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public DivideBuilder Muted => Chain(DivideEnum.Muted);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public DivideBuilder Accent => Chain(DivideEnum.Accent);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public DivideBuilder Popover => Chain(DivideEnum.Popover);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public DivideBuilder Card => Chain(DivideEnum.Card);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public DivideBuilder Background => Chain(DivideEnum.Background);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public DivideBuilder Border => Chain(DivideEnum.Border);
    /// <summary>
    /// Gets or sets input.
    /// </summary>
    public DivideBuilder Input => Chain(DivideEnum.Input);
    /// <summary>
    /// Gets or sets ring.
    /// </summary>
    public DivideBuilder Ring => Chain(DivideEnum.Ring);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public DivideBuilder White => Chain(DivideEnum.White);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public DivideBuilder Black => Chain(DivideEnum.Black);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public DivideBuilder Transparent => Chain(DivideEnum.Transparent);
    /// <summary>
    /// Adds the color Divide utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DivideBuilder Color(string value) => ChainClass($"divide-{value}");
    /// <summary>
    /// Fluent step for `Solid` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public DivideBuilder Solid => Chain(DivideEnum.Solid);
    /// <summary>
    /// Fluent step for `Dashed` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public DivideBuilder Dashed => Chain(DivideEnum.Dashed);
    /// <summary>
    /// Fluent step for `Dotted` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public DivideBuilder Dotted => Chain(DivideEnum.Dotted);
    /// <summary>
    /// Fluent step for `Double` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public DivideBuilder Double => Chain(DivideEnum.Double);
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public DivideBuilder None => Chain(DivideEnum.None);

    /// <summary>
    /// Creates a divide utility from a Tailwind token or fully-prefixed utility.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DivideBuilder Token(string value) => Color(value);

    /// <summary>
    /// Passes through a fully-prefixed divide utility such as <c>divide-border</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DivideBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("divide-", utility));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private DivideBuilder Chain(DivideEnum value)
    {
        _rules.Add(new DivideRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private DivideBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new DivideRule(value, null, ConsumePendingModifierChain()));
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
            DivideRule rule = _rules[i];
            string cls = rule.Value;
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
    public override string ToString() => ToClass();
}
