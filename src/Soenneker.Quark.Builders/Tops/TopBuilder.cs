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
    private readonly List<TopRule> _rules = new(4);

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
    public TopBuilder Is0 => Chain(TopEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public TopBuilder Is1 => Chain(TopEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public TopBuilder Is1_5 => Chain(TopEnum.Is1_5);
    /// <summary>
    /// Gets or sets is1of2.
    /// </summary>
    public TopBuilder Is1of2 => Chain(TopEnum.Is1of2);
    /// <summary>
    /// Gets or sets is1of3.
    /// </summary>
    public TopBuilder Is1of3 => Chain(TopEnum.Is1of3);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public TopBuilder Is2 => Chain(TopEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public TopBuilder Is3 => Chain(TopEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public TopBuilder Is4 => Chain(TopEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public TopBuilder Is5 => Chain(TopEnum.Is5);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public TopBuilder Is8 => Chain(TopEnum.Is8);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public TopBuilder Is12 => Chain(TopEnum.Is12);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public TopBuilder Is16 => Chain(TopEnum.Is16);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public TopBuilder Is24 => Chain(TopEnum.Is24);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public TopBuilder Auto => Chain(TopEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public TopBuilder Px => Chain(TopEnum.Px);
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



    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (TopRule rule in _rules)
        {
            string cls = rule.Value;
            if (cls.Length == 0) continue;
            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
            if (!first) sb.Append(' ');
            else first = false;
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
