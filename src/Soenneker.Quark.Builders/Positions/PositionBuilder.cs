using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;



namespace Soenneker.Quark;

/// <summary>
/// High-performance position builder with fluent API for chaining position rules.
/// </summary>
[TailwindPrefix("", Responsive = true)]
public sealed class PositionBuilder : CssBuilderBase<PositionBuilder>
{
    private RuleList<PositionRule> _rules;

    internal PositionBuilder()
    {
    }

    internal PositionBuilder(string position, BreakpointType? breakpoint = null)
    {
        _rules.Add(new PositionRule(position, breakpoint));
    }

    internal PositionBuilder(List<PositionRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>Chain with static positioning for the next rule.</summary>
    public PositionBuilder Static => ChainWithPosition(PositionKeyword.StaticValue);
    /// <summary>Chain with relative positioning for the next rule.</summary>
    public PositionBuilder Relative => ChainWithPosition(PositionKeyword.RelativeValue);
    /// <summary>Chain with absolute positioning for the next rule.</summary>
    public PositionBuilder Absolute => ChainWithPosition(PositionKeyword.AbsoluteValue);
    /// <summary>Chain with fixed positioning for the next rule.</summary>
    public PositionBuilder Fixed => ChainWithPosition(PositionKeyword.FixedValue);
    /// <summary>Chain with sticky positioning for the next rule.</summary>
    public PositionBuilder Sticky => ChainWithPosition(PositionKeyword.StickyValue);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PositionBuilder ChainWithPosition(string position)
    {
        _rules.Add(new PositionRule(position, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            PositionRule rule = _rules[0];
            return ClassWriter.Render(rule.Position, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                PositionRule rule = _rules[i];
                writer.Add(rule.Position, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
