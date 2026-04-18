
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned object-position builder.
/// </summary>
[TailwindPrefix("object-", Responsive = true)]
public sealed class ObjectPositionBuilder : ICssBuilder
{
    private readonly List<ObjectPositionRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal ObjectPositionBuilder(string position, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ObjectPositionRule(position, breakpoint));
    }

    internal ObjectPositionBuilder(ObjectPositionEnum position, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ObjectPositionRule(position.Value, breakpoint));
    }

    internal ObjectPositionBuilder(List<ObjectPositionRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the object position to center.
    /// </summary>
    public ObjectPositionBuilder Center => Chain(ObjectPositionEnum.Center);
    /// <summary>
    /// Sets the object position to top.
    /// </summary>
    public ObjectPositionBuilder Top => Chain(ObjectPositionEnum.Top);
    /// <summary>
    /// Sets the object position to right.
    /// </summary>
    public ObjectPositionBuilder Right => Chain(ObjectPositionEnum.Right);
    /// <summary>
    /// Sets the object position to bottom.
    /// </summary>
    public ObjectPositionBuilder Bottom => Chain(ObjectPositionEnum.Bottom);
    /// <summary>
    /// Sets the object position to left.
    /// </summary>
    public ObjectPositionBuilder Left => Chain(ObjectPositionEnum.Left);
    /// <summary>
    /// Sets the object position to top-left.
    /// </summary>
    public ObjectPositionBuilder TopLeft => Chain(ObjectPositionEnum.TopLeft);
    /// <summary>
    /// Sets the object position to top-right.
    /// </summary>
    public ObjectPositionBuilder TopRight => Chain(ObjectPositionEnum.TopRight);
    /// <summary>
    /// Sets the object position to bottom-left.
    /// </summary>
    public ObjectPositionBuilder BottomLeft => Chain(ObjectPositionEnum.BottomLeft);
    /// <summary>
    /// Sets the object position to bottom-right.
    /// </summary>
    public ObjectPositionBuilder BottomRight => Chain(ObjectPositionEnum.BottomRight);

    /// <summary>
    /// Applies an exact Tailwind object-position utility token suffix.
    /// </summary>
    public ObjectPositionBuilder Token(string token) => Chain(token);

    /// <summary>
    /// Applies the object position on phone breakpoint.
    /// </summary>
    public ObjectPositionBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the object position on small breakpoint (≥640px).
    /// </summary>
    public ObjectPositionBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the object position on tablet breakpoint.
    /// </summary>
    public ObjectPositionBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the object position on laptop breakpoint.
    /// </summary>
    public ObjectPositionBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the object position on desktop breakpoint.
    /// </summary>
    public ObjectPositionBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the object position on the 2xl breakpoint.
    /// </summary>
    public ObjectPositionBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ObjectPositionBuilder Chain(ObjectPositionEnum position)
    {
        return Chain(position.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ObjectPositionBuilder Chain(string position)
    {
        _rules.Add(new ObjectPositionRule(position, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ObjectPositionBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            ObjectPositionRule rule = _rules[i];
            string cls = "object-" + rule.Position;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointClass(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this object position builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
