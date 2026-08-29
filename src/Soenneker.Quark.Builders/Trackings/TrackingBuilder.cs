using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the tracking builder.
/// </summary>
[TailwindPrefix("tracking-", Responsive = true)]
public sealed class TrackingBuilder : CssBuilderBase<TrackingBuilder>
{
    private const string Prefix = "tracking-";
    private readonly List<TrackingRule> _rules = new(4);

    internal TrackingBuilder()
    {
    }

    internal TrackingBuilder(TrackingEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TrackingRule(value.Value, breakpoint));
    }

    internal TrackingBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TrackingRule(value, breakpoint));
    }

    /// <summary>
    /// Gets or sets tighter.
    /// </summary>
    public TrackingBuilder Tighter => Chain(TrackingEnum.Tighter);
    /// <summary>
    /// Gets or sets tight.
    /// </summary>
    public TrackingBuilder Tight => Chain(TrackingEnum.Tight);
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public TrackingBuilder Normal => Chain(TrackingEnum.Normal);
    /// <summary>
    /// Gets or sets wide.
    /// </summary>
    public TrackingBuilder Wide => Chain(TrackingEnum.Wide);
    /// <summary>
    /// Gets or sets wider.
    /// </summary>
    public TrackingBuilder Wider => Chain(TrackingEnum.Wider);
    /// <summary>
    /// Gets or sets widest.
    /// </summary>
    public TrackingBuilder Widest => Chain(TrackingEnum.Widest);
    /// <summary>
    /// Adds an arbitrary tracking utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public TrackingBuilder Token(string value) => Chain(Prefix + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TrackingBuilder Chain(TrackingEnum value)
    {
        _rules.Add(new TrackingRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TrackingBuilder Chain(string value)
    {
        _rules.Add(new TrackingRule(value, null, ConsumePendingModifierChain()));
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
            TrackingRule rule = _rules[i];

            if (rule.Value.Length == 0)
                continue;

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
