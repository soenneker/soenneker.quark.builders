
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Extensions.String;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance ring color builder.
/// Produces ring color utility classes.
/// </summary>
[TailwindPrefix("ring-", Responsive = true)]
public sealed class RingColorBuilder : ColorBuilderBase<RingColorBuilder>
{
    private readonly List<RingColorRule> _rules = new(4);

    internal RingColorBuilder()
    {
    }

    internal RingColorBuilder(RingColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RingColorRule(value.Value, breakpoint));
    }

    internal RingColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.HasContent())
            _rules.Add(new RingColorRule(value, breakpoint));
    }

    internal RingColorBuilder(List<RingColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `Primary` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Primary => ChainValue(RingColorEnum.Primary);
    /// <summary>
    /// Fluent step for `Primary Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder PrimaryForeground => ChainValue(RingColorEnum.PrimaryForeground);
    /// <summary>
    /// Fluent step for `Secondary` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Secondary => ChainValue(RingColorEnum.Secondary);
    /// <summary>
    /// Fluent step for `Secondary Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder SecondaryForeground => ChainValue(RingColorEnum.SecondaryForeground);
    /// <summary>
    /// Fluent step for `Destructive` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Destructive => ChainValue(RingColorEnum.Destructive);
    /// <summary>
    /// Fluent step for `Destructive Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder DestructiveForeground => ChainValue(RingColorEnum.DestructiveForeground);
    /// <summary>
    /// Fluent step for `Muted` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Muted => ChainValue(RingColorEnum.Muted);
    /// <summary>
    /// Fluent step for `Muted Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder MutedForeground => ChainValue(RingColorEnum.MutedForeground);
    /// <summary>
    /// Fluent step for `Accent` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Accent => ChainValue(RingColorEnum.Accent);
    /// <summary>
    /// Fluent step for `Accent Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder AccentForeground => ChainValue(RingColorEnum.AccentForeground);
    /// <summary>
    /// Fluent step for `Popover` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Popover => ChainValue(RingColorEnum.Popover);
    /// <summary>
    /// Fluent step for `Popover Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder PopoverForeground => ChainValue(RingColorEnum.PopoverForeground);
    /// <summary>
    /// Fluent step for `Card` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Card => ChainValue(RingColorEnum.Card);
    /// <summary>
    /// Fluent step for `Card Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder CardForeground => ChainValue(RingColorEnum.CardForeground);
    /// <summary>
    /// Fluent step for `Background` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Background => ChainValue(RingColorEnum.Background);
    /// <summary>
    /// Fluent step for `Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Foreground => ChainValue(RingColorEnum.Foreground);
    /// <summary>
    /// Fluent step for `Border` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Border => ChainValue(RingColorEnum.Border);
    /// <summary>
    /// Fluent step for `Input` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Input => ChainValue(RingColorEnum.Input);
    /// <summary>
    /// Fluent step for `Ring` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Ring => ChainValue(RingColorEnum.Ring);
    public RingColorBuilder Ring50 => ChainValue(RingColorEnum.Ring50);
    /// <summary>
    /// Fluent step for `Success` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Success => ChainValue(RingColorEnum.Success);
    /// <summary>
    /// Fluent step for `Warning` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Warning => ChainValue(RingColorEnum.Warning);
    /// <summary>
    /// Fluent step for `Info` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Info => ChainValue(RingColorEnum.Info);
    /// <summary>
    /// Fluent step for `White` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder White => ChainValue(RingColorEnum.White);
    /// <summary>
    /// Fluent step for `Black` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public RingColorBuilder Black => ChainValue(RingColorEnum.Black);

    public override RingColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("ring-", token));

    public RingColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("ring-", utility));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingColorBuilder ChainValue(RingColorEnum value)
    {
        BreakpointType? breakpoint = null;
        _rules.Add(new RingColorRule(value.Value, breakpoint, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingColorBuilder ChainClass(string value)
    {
        BreakpointType? breakpoint = null;

        if (value.HasContent())
            _rules.Add(new RingColorRule(value, breakpoint, ConsumePendingModifierChain()));

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
            RingColorRule rule = _rules[i];
            string cls = rule.Value;
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

    public override string ToString()
    {
        return ToClass();
    }
}
