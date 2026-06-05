using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the grow builder.
/// </summary>
public sealed class GrowBuilder : CssBuilderBase<GrowBuilder>
{
    private readonly List<GrowRule> _rules = new(4);

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

        foreach (GrowRule rule in _rules)
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
