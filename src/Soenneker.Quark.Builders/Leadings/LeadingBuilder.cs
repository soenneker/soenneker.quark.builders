using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the leading builder.
/// </summary>
[TailwindPrefix("leading-", Responsive = true)]
public sealed class LeadingBuilder : CssBuilderBase<LeadingBuilder>
{
    private const string Prefix = "leading-";
    private RuleList<LeadingRule> _rules;

    internal LeadingBuilder()
    {
    }

    internal LeadingBuilder(LeadingEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeadingRule(value.Value, breakpoint));
    }

    internal LeadingBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeadingRule(value, breakpoint));
    }

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public LeadingBuilder None => Chain(LeadingEnum.NoneValue);
    /// <summary>
    /// Gets or sets tight.
    /// </summary>
    public LeadingBuilder Tight => Chain(LeadingEnum.TightValue);
    /// <summary>
    /// Gets or sets snug.
    /// </summary>
    public LeadingBuilder Snug => Chain(LeadingEnum.SnugValue);
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public LeadingBuilder Normal => Chain(LeadingEnum.NormalValue);
    /// <summary>
    /// Gets or sets relaxed.
    /// </summary>
    public LeadingBuilder Relaxed => Chain(LeadingEnum.RelaxedValue);
    /// <summary>
    /// Gets or sets loose.
    /// </summary>
    public LeadingBuilder Loose => Chain(LeadingEnum.LooseValue);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public LeadingBuilder Is0 => Chain(LeadingEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public LeadingBuilder Is1 => Chain(LeadingEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public LeadingBuilder Is2 => Chain(LeadingEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public LeadingBuilder Is3 => Chain(LeadingEnum.Is3Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public LeadingBuilder Is4 => Chain(LeadingEnum.Is4Value);
    /// <summary>
    /// Gets or sets is4 5.
    /// </summary>
    public LeadingBuilder Is4_5 => Chain(LeadingEnum.Is4_5Value);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public LeadingBuilder Is5 => Chain(LeadingEnum.Is5Value);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public LeadingBuilder Is6 => Chain(LeadingEnum.Is6Value);
    /// <summary>
    /// Gets or sets is6 5.
    /// </summary>
    public LeadingBuilder Is6_5 => Chain(LeadingEnum.Is6_5Value);
    /// <summary>
    /// Gets or sets is7.
    /// </summary>
    public LeadingBuilder Is7 => Chain(LeadingEnum.Is7Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public LeadingBuilder Is8 => Chain(LeadingEnum.Is8Value);
    /// <summary>
    /// Gets or sets is9.
    /// </summary>
    public LeadingBuilder Is9 => Chain(LeadingEnum.Is9Value);
    /// <summary>
    /// Gets or sets is10.
    /// </summary>
    public LeadingBuilder Is10 => Chain(LeadingEnum.Is10Value);
    /// <summary>
    /// Adds an arbitrary leading utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public LeadingBuilder Token(string value) => Chain(UtilityToken.WithPrefix(value, Prefix));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeadingBuilder Chain(LeadingEnum value)
    {
        _rules.Add(new LeadingRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeadingBuilder Chain(string value)
    {
        _rules.Add(new LeadingRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            LeadingRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                LeadingRule rule = _rules[i];
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
