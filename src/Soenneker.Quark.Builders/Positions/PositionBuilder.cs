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
    private readonly List<PositionRule> _rules = new(4);

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



    /// <summary>Gets the CSS class string for the current configuration.</summary>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            PositionRule rule = _rules[i];

            string baseClass = rule.Position;
            if (baseClass.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                baseClass = BreakpointUtil.ApplyTailwindBreakpoint(baseClass, bp);

            if (rule.ModifierChain is { Length: > 0 })
                baseClass = BreakpointUtil.ApplyTailwindModifiers(baseClass, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(baseClass);
        }

        return sb.ToString();
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
