using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Right offset builder. Tailwind: right-*.
/// </summary>
[TailwindPrefix("right-", Responsive = true)]
public sealed class RightBuilder : CssBuilderBase<RightBuilder>
{
    private readonly List<RightRule> _rules = new(4);

    internal RightBuilder()
    {
    }

    internal RightBuilder(RightEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RightRule(value.Value, breakpoint));
    }

    internal RightBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RightRule(value, breakpoint));
    }

    internal RightBuilder(List<RightRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public RightBuilder Is0 => Chain(RightEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public RightBuilder Is1 => Chain(RightEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public RightBuilder Is1_5 => Chain(RightEnum.Is1_5);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public RightBuilder Is2 => Chain(RightEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public RightBuilder Is3 => Chain(RightEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public RightBuilder Is4 => Chain(RightEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public RightBuilder Is5 => Chain(RightEnum.Is5);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public RightBuilder Is8 => Chain(RightEnum.Is8);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public RightBuilder Is12 => Chain(RightEnum.Is12);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public RightBuilder Is16 => Chain(RightEnum.Is16);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public RightBuilder Is24 => Chain(RightEnum.Is24);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public RightBuilder Auto => Chain(RightEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public RightBuilder Px => Chain(RightEnum.Px);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RightBuilder Token(string value) => Chain(value.StartsWith("right-") ? value : "right-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RightBuilder Chain(RightEnum value)
    {
        _rules.Add(new RightRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RightBuilder Chain(string value)
    {
        _rules.Add(new RightRule(value, null, ConsumePendingModifierChain()));
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
        foreach (RightRule rule in _rules)
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
