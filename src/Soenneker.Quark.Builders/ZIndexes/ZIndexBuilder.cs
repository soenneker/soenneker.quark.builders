
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified z-index builder with fluent API for chaining z-index rules.
/// </summary>
[TailwindPrefix("z-", Responsive = true)]
public sealed class ZIndexBuilder : CssBuilderBase<ZIndexBuilder>
{
    private readonly List<ZIndexRule> _rules = new(4);

    internal ZIndexBuilder()
    {
    }

    internal ZIndexBuilder(ZIndexEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ZIndexRule(value, breakpoint));
    }

    internal ZIndexBuilder(List<ZIndexRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the z-index to -1.
    /// </summary>
    public ZIndexBuilder N1 => Chain(ZIndexEnum.N1);

    /// <summary>
    /// Sets the z-index to 0.
    /// </summary>
    public ZIndexBuilder Z0 => Chain(ZIndexEnum.Z0);

    /// <summary>
    /// Sets the z-index to 1.
    /// </summary>
    public ZIndexBuilder Z1 => Chain(ZIndexEnum.Z1);

    /// <summary>
    /// Sets the z-index to 2.
    /// </summary>
    public ZIndexBuilder Z2 => Chain(ZIndexEnum.Z2);

    /// <summary>
    /// Sets the z-index to 3.
    /// </summary>
    public ZIndexBuilder Z3 => Chain(ZIndexEnum.Z3);

    /// <summary>
    /// Sets the z-index to 10.
    /// </summary>
    public ZIndexBuilder Z10 => Chain(ZIndexEnum.Z10);

    /// <summary>
    /// Sets the z-index to 50.
    /// </summary>
    public ZIndexBuilder Z50 => Chain(ZIndexEnum.Z50);







    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ZIndexBuilder Chain(ZIndexEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new ZIndexRule(value, bp, ConsumePendingModifierChain()));
        return this;
    }


    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            ZIndexRule rule = _rules[i];
            string cls = rule.Value.Value;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
