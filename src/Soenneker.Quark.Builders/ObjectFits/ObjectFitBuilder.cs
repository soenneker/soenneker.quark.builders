
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified object-fit builder with fluent API for chaining object-fit rules.
/// </summary>
[TailwindPrefix("object-", Responsive = true)]
public sealed class ObjectFitBuilder : ICssBuilder
{
    private readonly List<ObjectFitRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal ObjectFitBuilder(string fit, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ObjectFitRule(fit, breakpoint));
    }

    internal ObjectFitBuilder(ObjectFitEnum fit, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ObjectFitRule(fit.Value, breakpoint));
    }

    internal ObjectFitBuilder(List<ObjectFitRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Chain with contain for the next rule.
    /// </summary>
    public ObjectFitBuilder Contain => ChainWithFit(ObjectFitEnum.Contain);

    /// <summary>
    /// Chain with cover for the next rule.
    /// </summary>
    public ObjectFitBuilder Cover => ChainWithFit(ObjectFitEnum.Cover);

    /// <summary>
    /// Chain with fill for the next rule.
    /// </summary>
    public ObjectFitBuilder Fill => ChainWithFit(ObjectFitEnum.Fill);

    /// <summary>
    /// Chain with scale-down for the next rule.
    /// </summary>
    public ObjectFitBuilder ScaleDown => ChainWithFit(ObjectFitEnum.ScaleDown);

    /// <summary>
    /// Chain with none for the next rule.
    /// </summary>
    public ObjectFitBuilder None => ChainWithFit(ObjectFitEnum.None);

    /// <summary>
    /// Applies on the base breakpoint.
    /// </summary>
    public ObjectFitBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);

    /// <summary>
    /// Apply on small screens (≥640px).
    /// </summary>
    public ObjectFitBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);

    /// <summary>
    /// Applies on the md breakpoint.
    /// </summary>
    public ObjectFitBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);

    /// <summary>
    /// Applies on the lg breakpoint.
    /// </summary>
    public ObjectFitBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);

    /// <summary>
    /// Applies on the xl breakpoint.
    /// </summary>
    public ObjectFitBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);

    /// <summary>
    /// Applies on the 2xl breakpoint.
    /// </summary>
    public ObjectFitBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ObjectFitBuilder ChainWithFit(string fit)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new ObjectFitRule(fit, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ObjectFitBuilder ChainWithFit(ObjectFitEnum fit)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new ObjectFitRule(fit.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ObjectFitBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            ObjectFitRule rule = _rules[i];
            string cls = rule.Fit;
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
    public string ToStyle()
    {
        return string.Empty;
    }

    public override string ToString() => ToClass();
}
