using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the grow builder.
/// </summary>
public sealed class GrowBuilder : CssBuilderBase<GrowBuilder>
{
    private RuleList<GrowRule> _rules;

    internal GrowBuilder()
    {
    }

    internal GrowBuilder(GrowEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new GrowRule(value, breakpoint));
    }

    internal GrowBuilder(List<GrowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public GrowBuilder Is1 => Chain(GrowEnum.Is1);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public GrowBuilder Is0 => Chain(GrowEnum.Is0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GrowBuilder Chain(GrowEnum value)
    {
        _rules.Add(new GrowRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            GrowRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                GrowRule rule = _rules[i];
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
