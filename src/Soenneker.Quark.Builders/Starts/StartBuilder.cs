using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Start (inset-inline-start) builder. Tailwind: start-*.
/// </summary>
[TailwindPrefix("start-", Responsive = true)]
public sealed class StartBuilder : CssBuilderBase<StartBuilder>
{
    private RuleList<StartRule> _rules;

    internal StartBuilder()
    {
    }

    internal StartBuilder(StartEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new StartRule(value, breakpoint));
    }

    internal StartBuilder(List<StartRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public StartBuilder Is0 => Chain(StartEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public StartBuilder Is1 => Chain(StartEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public StartBuilder Is1_5 => Chain(StartEnum.Is1_5);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public StartBuilder Is2 => Chain(StartEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public StartBuilder Is3 => Chain(StartEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public StartBuilder Is4 => Chain(StartEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public StartBuilder Is5 => Chain(StartEnum.Is5);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public StartBuilder Auto => Chain(StartEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public StartBuilder Px => Chain(StartEnum.Px);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StartBuilder Chain(StartEnum value)
    {
        _rules.Add(new StartRule(value, null, ConsumePendingModifierChain()));
        return this;
    }


    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            StartRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                StartRule rule = _rules[i];
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
