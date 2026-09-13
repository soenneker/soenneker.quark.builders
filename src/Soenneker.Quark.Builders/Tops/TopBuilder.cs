using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Top offset builder. Tailwind: top-*.
/// </summary>
[TailwindPrefix("top-", Responsive = true)]
public sealed class TopBuilder : CssBuilderBase<TopBuilder>
{
    private RuleList<TopRule> _rules;

    internal TopBuilder()
    {
    }

    internal TopBuilder(TopEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TopRule(value.Value, breakpoint));
    }

    internal TopBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TopRule(value, breakpoint));
    }

    internal TopBuilder(List<TopRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public TopBuilder Is0 => Chain(TopEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public TopBuilder Is1 => Chain(TopEnum.Is1Value);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public TopBuilder Is1_5 => Chain(TopEnum.Is1_5Value);
    /// <summary>
    /// Gets or sets is1of2.
    /// </summary>
    public TopBuilder Is1of2 => Chain(TopEnum.Is1of2Value);
    /// <summary>
    /// Gets or sets is1of3.
    /// </summary>
    public TopBuilder Is1of3 => Chain(TopEnum.Is1of3Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public TopBuilder Is2 => Chain(TopEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public TopBuilder Is3 => Chain(TopEnum.Is3Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public TopBuilder Is4 => Chain(TopEnum.Is4Value);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public TopBuilder Is5 => Chain(TopEnum.Is5Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public TopBuilder Is8 => Chain(TopEnum.Is8Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public TopBuilder Is12 => Chain(TopEnum.Is12Value);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public TopBuilder Is16 => Chain(TopEnum.Is16Value);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public TopBuilder Is24 => Chain(TopEnum.Is24Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public TopBuilder Auto => Chain(TopEnum.AutoValue);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public TopBuilder Px => Chain(TopEnum.PxValue);
    /// <summary>
    /// Adds an arbitrary top utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public TopBuilder Token(string value) => Chain(value.StartsWith("top-") ? value : "top-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TopBuilder Chain(TopEnum value)
    {
        _rules.Add(new TopRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TopBuilder Chain(string value)
    {
        _rules.Add(new TopRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            TopRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                TopRule rule = _rules[i];
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
