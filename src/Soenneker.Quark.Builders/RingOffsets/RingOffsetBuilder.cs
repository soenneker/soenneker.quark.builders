using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("ring-offset-", Responsive = true)]
public sealed class RingOffsetBuilder : CssBuilderBase
{
    private readonly List<RingOffsetRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal RingOffsetBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new RingOffsetRule(value, breakpoint));
    }

    public RingOffsetBuilder Primary => Chain(RingOffsetColorEnum.Primary.Value);
    public RingOffsetBuilder Secondary => Chain(RingOffsetColorEnum.Secondary.Value);
    public RingOffsetBuilder Destructive => Chain(RingOffsetColorEnum.Destructive.Value);
    public RingOffsetBuilder Muted => Chain(RingOffsetColorEnum.Muted.Value);
    public RingOffsetBuilder Accent => Chain(RingOffsetColorEnum.Accent.Value);
    public RingOffsetBuilder Popover => Chain(RingOffsetColorEnum.Popover.Value);
    public RingOffsetBuilder Card => Chain(RingOffsetColorEnum.Card.Value);
    public RingOffsetBuilder Background => Chain(RingOffsetColorEnum.Background.Value);
    public RingOffsetBuilder Border => Chain(RingOffsetColorEnum.Border.Value);
    public RingOffsetBuilder Input => Chain(RingOffsetColorEnum.Input.Value);
    public RingOffsetBuilder Ring => Chain(RingOffsetColorEnum.Ring.Value);
    public RingOffsetBuilder White => Chain(RingOffsetColorEnum.White.Value);
    public RingOffsetBuilder Black => Chain(RingOffsetColorEnum.Black.Value);
    public RingOffsetBuilder Transparent => Chain(RingOffsetColorEnum.Transparent.Value);
    public RingOffsetBuilder Width(int value) => Chain($"ring-offset-{value}");
    public RingOffsetBuilder Width(string value) => Chain($"ring-offset-{value}");
    public RingOffsetBuilder Color(string value) => Chain(ColorUtility.CreateClass("ring-offset-", value));
    public RingOffsetBuilder Utility(string utility) => Chain(ColorUtility.CreateUtilityClass("ring-offset-", utility));

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint. In Tailwind’s mobile‑first model, unprefixed utilities apply from 0px unless a larger breakpoint overrides them.
    /// </summary>
    public RingOffsetBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public RingOffsetBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public RingOffsetBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public RingOffsetBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public RingOffsetBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public RingOffsetBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingOffsetBuilder Chain(string value)
    {
        if (value.Length != 0)
            _rules.Add(new RingOffsetRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingOffsetBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            RingOffsetRule rule = _rules[i];
            string cls = rule.Value;
            string bp = BreakpointUtil.GetBreakpointClass(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
