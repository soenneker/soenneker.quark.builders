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
    private RuleList<TrackingRule> _rules;

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
    public TrackingBuilder Tighter => Chain(TrackingEnum.TighterValue);
    /// <summary>
    /// Gets or sets tight.
    /// </summary>
    public TrackingBuilder Tight => Chain(TrackingEnum.TightValue);
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public TrackingBuilder Normal => Chain(TrackingEnum.NormalValue);
    /// <summary>
    /// Gets or sets wide.
    /// </summary>
    public TrackingBuilder Wide => Chain(TrackingEnum.WideValue);
    /// <summary>
    /// Gets or sets wider.
    /// </summary>
    public TrackingBuilder Wider => Chain(TrackingEnum.WiderValue);
    /// <summary>
    /// Gets or sets widest.
    /// </summary>
    public TrackingBuilder Widest => Chain(TrackingEnum.WidestValue);
    /// <summary>
    /// Adds an arbitrary tracking utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public TrackingBuilder Token(string value) => Chain(UtilityToken.WithPrefix(value, Prefix));


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



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            TrackingRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                TrackingRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
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
