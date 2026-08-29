using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Left offset builder. Tailwind: left-*.
/// </summary>
[TailwindPrefix("left-", Responsive = true)]
public sealed class LeftBuilder : CssBuilderBase<LeftBuilder>
{
    private readonly List<LeftRule> _rules = new(4);

    internal LeftBuilder()
    {
    }

    internal LeftBuilder(LeftEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeftRule(value.Value, breakpoint));
    }

    internal LeftBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeftRule(value, breakpoint));
    }

    internal LeftBuilder(List<LeftRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public LeftBuilder Is0 => Chain(LeftEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public LeftBuilder Is1 => Chain(LeftEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public LeftBuilder Is1_5 => Chain(LeftEnum.Is1_5);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public LeftBuilder Is2 => Chain(LeftEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public LeftBuilder Is3 => Chain(LeftEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public LeftBuilder Is4 => Chain(LeftEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public LeftBuilder Is5 => Chain(LeftEnum.Is5);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public LeftBuilder Is8 => Chain(LeftEnum.Is8);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public LeftBuilder Is12 => Chain(LeftEnum.Is12);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public LeftBuilder Is16 => Chain(LeftEnum.Is16);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public LeftBuilder Is24 => Chain(LeftEnum.Is24);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public LeftBuilder Auto => Chain(LeftEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public LeftBuilder Px => Chain(LeftEnum.Px);
    /// <summary>
    /// Adds an arbitrary left utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public LeftBuilder Token(string value) => Chain(value.StartsWith("left-") ? value : "left-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeftBuilder Chain(LeftEnum value)
    {
        _rules.Add(new LeftRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeftBuilder Chain(string value)
    {
        _rules.Add(new LeftRule(value, null, ConsumePendingModifierChain()));
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
        foreach (LeftRule rule in _rules)
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
