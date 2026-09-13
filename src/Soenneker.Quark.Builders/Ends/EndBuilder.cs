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
    private RuleList<EndRule> _rules;

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

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            EndRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                EndRule rule = _rules[i];
                writer.Add(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
