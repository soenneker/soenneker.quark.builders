
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified z-index builder with fluent API for chaining z-index rules.
/// </summary>
[TailwindPrefix("z-", Responsive = true)]
public sealed class ZIndexBuilder : CssBuilderBase
{
    private readonly List<ZIndexRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

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

    /// <summary>
    /// Applies the z-index on phone breakpoint.
    /// </summary>
    public ZIndexBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);

    /// <summary>
    /// Applies the z-index on small breakpoint (≥640px).
    /// </summary>
    public ZIndexBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);

    /// <summary>
    /// Applies the z-index on tablet breakpoint.
    /// </summary>
    public ZIndexBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);

    /// <summary>
    /// Applies the z-index on laptop breakpoint.
    /// </summary>
    public ZIndexBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);

    /// <summary>
    /// Applies the z-index on desktop breakpoint.
    /// </summary>
    public ZIndexBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);

    /// <summary>
    /// Applies the z-index on the 2xl breakpoint.
    /// </summary>
    public ZIndexBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ZIndexBuilder Chain(ZIndexEnum value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new ZIndexRule(value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ZIndexBuilder SetPendingBreakpoint(BreakpointType bp)
    {
        _pendingBreakpoint = bp;
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
