
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// Simplified gap builder with fluent API for chaining gap rules.
/// </summary>
[TailwindPrefix("gap-", Responsive = true)]
public sealed class GapBuilder : CssBuilderBase
{
    private readonly List<GapRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal GapBuilder(string size, BreakpointType? breakpoint = null, GapAxisEnum? axis = null)
    {
        if (size.Length != 0)
            _rules.Add(new GapRule(size, axis ?? GapAxisEnum.All, breakpoint));
    }

    internal GapBuilder(List<GapRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is0 => ChainWithSize(GapScaleEnum.Is0Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is1 => ChainWithSize(GapScaleEnum.Is1Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is2 => ChainWithSize(GapScaleEnum.Is2Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is3 => ChainWithSize(GapScaleEnum.Is3Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is4 => ChainWithSize(GapScaleEnum.Is4Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is5 => ChainWithSize(GapScaleEnum.Is5Value);

    /// <summary>
    /// Chain with an arbitrary Tailwind gap token for the next rule.
    /// </summary>
    public GapBuilder Token(string value) => ChainWithSize(value);

    /// <summary>
    /// Apply to column gap only.
    /// </summary>
    public GapBuilder X => ChainWithAxis(GapAxisEnum.X);

    public GapBuilder Column => X;

    /// <summary>
    /// Apply to row gap only.
    /// </summary>
    public GapBuilder Y => ChainWithAxis(GapAxisEnum.Y);

    public GapBuilder Row => Y;

    /// <summary>
    /// Applies on the base breakpoint.
    /// </summary>
    public GapBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);

    /// <summary>
    /// Apply on small screens (≥640px).
    /// </summary>
    public GapBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);

    /// <summary>
    /// Applies on the md breakpoint.
    /// </summary>
    public GapBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);

    /// <summary>
    /// Applies on the lg breakpoint.
    /// </summary>
    public GapBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);

    /// <summary>
    /// Applies on the xl breakpoint.
    /// </summary>
    public GapBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);

    /// <summary>
    /// Applies on the 2xl breakpoint.
    /// </summary>
    public GapBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    /// <summary>
    /// Applies on the 2xl breakpoint.
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GapBuilder ChainWithSize(string size)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new GapRule(size, GapAxisEnum.All, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GapBuilder ChainWithAxis(GapAxisEnum axis)
    {
        if (_rules.Count == 0)
        {
            BreakpointType? bpEmpty = _pendingBreakpoint;
            _pendingBreakpoint = null;
            _rules.Add(new GapRule(GapScaleEnum.Is0Value, axis, bpEmpty));
            return this;
        }

        int lastIdx = _rules.Count - 1;
        GapRule last = _rules[lastIdx];
        BreakpointType? bpRewrite = _pendingBreakpoint ?? last.Breakpoint;
        _pendingBreakpoint = null;
        _rules[lastIdx] = new GapRule(last.Size, axis, bpRewrite);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GapBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            GapRule rule = _rules[i];
            string cls = rule.Size.Length == 0 ? string.Empty : rule.Axis.Value + rule.Size;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointClass(rule.Breakpoint);

            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first) 
                sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

}
