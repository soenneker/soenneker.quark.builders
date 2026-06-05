using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the ring offset builder.
/// </summary>
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

    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public RingOffsetBuilder Primary => Chain(RingOffsetColorEnum.Primary.Value);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public RingOffsetBuilder Secondary => Chain(RingOffsetColorEnum.Secondary.Value);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public RingOffsetBuilder Destructive => Chain(RingOffsetColorEnum.Destructive.Value);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public RingOffsetBuilder Muted => Chain(RingOffsetColorEnum.Muted.Value);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public RingOffsetBuilder Accent => Chain(RingOffsetColorEnum.Accent.Value);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public RingOffsetBuilder Popover => Chain(RingOffsetColorEnum.Popover.Value);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public RingOffsetBuilder Card => Chain(RingOffsetColorEnum.Card.Value);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public RingOffsetBuilder Background => Chain(RingOffsetColorEnum.Background.Value);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public RingOffsetBuilder Border => Chain(RingOffsetColorEnum.Border.Value);
    /// <summary>
    /// Gets or sets input.
    /// </summary>
    public RingOffsetBuilder Input => Chain(RingOffsetColorEnum.Input.Value);
    /// <summary>
    /// Gets or sets ring.
    /// </summary>
    public RingOffsetBuilder Ring => Chain(RingOffsetColorEnum.Ring.Value);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public RingOffsetBuilder White => Chain(RingOffsetColorEnum.White.Value);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public RingOffsetBuilder Black => Chain(RingOffsetColorEnum.Black.Value);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public RingOffsetBuilder Transparent => Chain(RingOffsetColorEnum.Transparent.Value);
    /// <summary>
    /// Executes the width operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RingOffsetBuilder Width(int value) => Chain($"ring-offset-{value}");
    /// <summary>
    /// Executes the width operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RingOffsetBuilder Width(string value) => Chain($"ring-offset-{value}");
    /// <summary>
    /// Executes the color operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RingOffsetBuilder Color(string value) => Chain(ColorUtility.CreateClass("ring-offset-", value));
    /// <summary>
    /// Executes the utility operation.
    /// </summary>
    /// <param name="utility">The utility.</param>
    /// <returns>The result of the operation.</returns>
    public RingOffsetBuilder Utility(string utility) => Chain(ColorUtility.CreateUtilityClass("ring-offset-", utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RingOffsetBuilder Chain(string value)
    {
        if (value.Length != 0)
            _rules.Add(new RingOffsetRule(value, null, ConsumePendingModifierChain()));
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
