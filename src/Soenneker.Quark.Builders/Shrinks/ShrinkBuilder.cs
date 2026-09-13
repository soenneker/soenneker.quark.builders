using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the shrink builder.
/// </summary>
public sealed class ShrinkBuilder : CssBuilderBase<ShrinkBuilder>
{
    private RuleList<ShrinkRule> _rules;

    internal ShrinkBuilder()
    {
    }

    internal ShrinkBuilder(ShrinkEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ShrinkRule(value, breakpoint));
    }

    internal ShrinkBuilder(List<ShrinkRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public ShrinkBuilder Is1 => Chain(ShrinkEnum.Is1);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public ShrinkBuilder Is0 => Chain(ShrinkEnum.Is0);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ShrinkBuilder Chain(ShrinkEnum value)
    {
        _rules.Add(new ShrinkRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ShrinkRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ShrinkRule rule = _rules[i];
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
