using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("ring-offset-", Responsive = true)]
public sealed class RingOffsetBuilder : CssBuilderBase<RingOffsetBuilder>
{
    private readonly List<RingOffsetRule> _rules = new(4);

    internal RingOffsetBuilder()
    {
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingOffsetBuilder Chain(string value)
    {
        if (value.Length != 0)
            _rules.Add(new RingOffsetRule(value, null, ConsumePendingModifierChain()));
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
            RingOffsetRule rule = _rules[i];
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

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
