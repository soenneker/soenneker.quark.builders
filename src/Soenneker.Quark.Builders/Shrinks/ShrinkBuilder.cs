using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the shrink builder.
/// </summary>
public sealed class ShrinkBuilder : CssBuilderBase<ShrinkBuilder>
{
    private readonly List<ShrinkRule> _rules = new(4);

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



    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        foreach (ShrinkRule rule in _rules)
        {
            string cls = rule.Value.Value;
            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

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
