
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// Simplified visibility builder with fluent API for chaining visibility rules.
/// </summary>
[TailwindPrefix("visible", Responsive = true)]
public sealed class VisibilityBuilder : CssBuilderBase
{
    private readonly List<VisibilityRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal VisibilityBuilder(VisibilityEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new VisibilityRule(value, breakpoint));
    }

    internal VisibilityBuilder(List<VisibilityRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

	/// <summary>
	/// Sets the visibility to visible.
	/// </summary>
    public VisibilityBuilder Visible => Chain(VisibilityEnum.Visible);
	/// <summary>
	/// Sets the visibility to invisible.
	/// </summary>
    public VisibilityBuilder Invisible => Chain(VisibilityEnum.Invisible);
	/// <summary>
	/// Applies the visibility on phone breakpoint.
	/// </summary>
    public VisibilityBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
	/// <summary>
	/// Applies the visibility on small breakpoint (≥640px).
	/// </summary>
    public VisibilityBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
	/// <summary>
	/// Applies the visibility on tablet breakpoint.
	/// </summary>
    public VisibilityBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
	/// <summary>
	/// Applies the visibility on laptop breakpoint.
	/// </summary>
    public VisibilityBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
	/// <summary>
	/// Applies the visibility on desktop breakpoint.
	/// </summary>
    public VisibilityBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
	/// <summary>
	/// Applies the visibility on the 2xl breakpoint.
	/// </summary>
    public VisibilityBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private VisibilityBuilder Chain(VisibilityEnum value)
    {
        _rules.Add(new VisibilityRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private VisibilityBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            VisibilityRule rule = _rules[i];
            string cls;
            if (ReferenceEquals(rule.Value, VisibilityEnum.Visible))
                cls = VisibilityEnum.VisibleValue;
            else if (ReferenceEquals(rule.Value, VisibilityEnum.Invisible))
                cls = VisibilityEnum.InvisibleValue;
            else
                cls = string.Empty;
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
