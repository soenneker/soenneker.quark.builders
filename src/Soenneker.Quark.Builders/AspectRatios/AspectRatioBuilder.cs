
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified aspect ratio builder with fluent API for chaining aspect ratio rules.
/// </summary>
[TailwindPrefix("aspect-", Responsive = true)]
public sealed class AspectRatioBuilder : CssBuilderBase
{
    private readonly List<AspectRatioRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal AspectRatioBuilder(string ratio, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AspectRatioRule(ratio, breakpoint));
    }

    internal AspectRatioBuilder(AspectRatioEnum ratio, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AspectRatioRule(ratio.Value, breakpoint));
    }

    internal AspectRatioBuilder(List<AspectRatioRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the aspect ratio to 1:1 (square).
    /// </summary>
    public AspectRatioBuilder R1X1 => ChainWithRatio(AspectRatioEnum.R1X1);
    /// <summary>
    /// Sets the aspect ratio to 4:3.
    /// </summary>
    public AspectRatioBuilder R4X3 => ChainWithRatio(AspectRatioEnum.R4X3);
    /// <summary>
    /// Sets the aspect ratio to 16:9.
    /// </summary>
    public AspectRatioBuilder R16X9 => ChainWithRatio(AspectRatioEnum.R16X9);
    /// <summary>
    /// Sets the aspect ratio to 21:9.
    /// </summary>
    public AspectRatioBuilder R21X9 => ChainWithRatio(AspectRatioEnum.R21X9);

    /// <summary>
    /// Applies the aspect ratio at base (mobile-first default).
    /// </summary>
    public AspectRatioBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the aspect ratio at sm breakpoint (≥640px).
    /// </summary>
    public AspectRatioBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the aspect ratio at md breakpoint (≥768px).
    /// </summary>
    public AspectRatioBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the aspect ratio at lg breakpoint (≥1024px).
    /// </summary>
    public AspectRatioBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the aspect ratio at xl breakpoint (≥1280px).
    /// </summary>
    public AspectRatioBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the aspect ratio at 2xl breakpoint (≥1536px).
    /// </summary>
    public AspectRatioBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AspectRatioBuilder ChainWithRatio(string ratio)
    {
        _rules.Add(new AspectRatioRule(ratio, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AspectRatioBuilder ChainWithRatio(AspectRatioEnum ratio)
    {
        _rules.Add(new AspectRatioRule(ratio.Value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AspectRatioBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            AspectRatioRule rule = _rules[i];
            string cls = rule.Ratio;
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

    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this aspect ratio builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
