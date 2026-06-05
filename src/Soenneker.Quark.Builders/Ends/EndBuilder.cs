using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// End (inset-inline-end) builder. Tailwind: end-*.
/// </summary>
[TailwindPrefix("end-", Responsive = true)]
public sealed class EndBuilder : CssBuilderBase<EndBuilder>
{
    private readonly List<EndRule> _rules = new(4);

    internal EndBuilder()
    {
    }

    internal EndBuilder(EndEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new EndRule(value, breakpoint));
    }

    internal EndBuilder(List<EndRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public EndBuilder Is0 => Chain(EndEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public EndBuilder Is1 => Chain(EndEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public EndBuilder Is1_5 => Chain(EndEnum.Is1_5);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public EndBuilder Is2 => Chain(EndEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public EndBuilder Is3 => Chain(EndEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public EndBuilder Is4 => Chain(EndEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public EndBuilder Is5 => Chain(EndEnum.Is5);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public EndBuilder Auto => Chain(EndEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public EndBuilder Px => Chain(EndEnum.Px);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private EndBuilder Chain(EndEnum value)
    {
        _rules.Add(new EndRule(value, null, ConsumePendingModifierChain()));
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
        foreach (EndRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
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
