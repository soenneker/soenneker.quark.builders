
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
public sealed class RingColorBuilder : ICssBuilder
{
    private readonly List<RingColorRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal RingColorBuilder(RingColorEnum value, BreakpointType? breakpoint = null)
    {
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

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint. In Tailwind’s mobile‑first model, unprefixed utilities apply from 0px unless a larger breakpoint overrides them.
    /// </summary>
    public RingColorBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public RingColorBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public RingColorBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public RingColorBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public RingColorBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public RingColorBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingColorBuilder ChainValue(RingColorEnum value)
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new RingColorRule(value, breakpoint));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingColorBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            RingColorRule rule = _rules[i];
            string cls = rule.Value.Value;
            if (cls.Length == 0)
                continue;

            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public string ToStyle() => string.Empty;

    public override string ToString()
    {
        return ToClass();
    }
}
