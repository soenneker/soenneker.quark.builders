
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified resize builder with fluent API for chaining resize rules.
/// </summary>
[TailwindPrefix("resize-", Responsive = true)]
public sealed class ResizeBuilder : CssBuilderBase
{
    private readonly List<ResizeRule> _rules = new(4);

    internal ResizeBuilder(string resize, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ResizeRule(resize, breakpoint));
    }

    internal ResizeBuilder(ResizeEnum resize, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ResizeRule(resize.Value, breakpoint));
    }

    internal ResizeBuilder(List<ResizeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the resize to none.
    /// </summary>
    public ResizeBuilder None => ChainWithResize(ResizeEnum.None);
    /// <summary>
    /// Sets the resize to both.
    /// </summary>
    public ResizeBuilder Both => ChainWithResize(ResizeEnum.Both);
    /// <summary>
    /// Sets the resize to horizontal.
    /// </summary>
    public ResizeBuilder Horizontal => ChainWithResize(ResizeEnum.Horizontal);
    /// <summary>
    /// Sets the resize to vertical.
    /// </summary>
    public ResizeBuilder Vertical => ChainWithResize(ResizeEnum.Vertical);

    /// <summary>
    /// Applies the resize on phone breakpoint.
    /// </summary>
    public ResizeBuilder OnBase => ChainWithBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the resize on small breakpoint (≥640px).
    /// </summary>
    public ResizeBuilder OnSm => ChainWithBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the resize on tablet breakpoint.
    /// </summary>
    public ResizeBuilder OnMd => ChainWithBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the resize on laptop breakpoint.
    /// </summary>
    public ResizeBuilder OnLg => ChainWithBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the resize on desktop breakpoint.
    /// </summary>
    public ResizeBuilder OnXl => ChainWithBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the resize on the 2xl breakpoint.
    /// </summary>
    public ResizeBuilder On2xl => ChainWithBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ResizeBuilder ChainWithResize(string resize)
    {
        _rules.Add(new ResizeRule(resize, null));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ResizeBuilder ChainWithResize(ResizeEnum resize)
    {
        _rules.Add(new ResizeRule(resize.Value, null));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ResizeBuilder ChainWithBreakpoint(BreakpointType breakpoint)
    {
        if (_rules.Count == 0)
        {
            _rules.Add(new ResizeRule("none", breakpoint));
            return this;
        }

        int lastIdx = _rules.Count - 1;
        ResizeRule last = _rules[lastIdx];
        _rules[lastIdx] = new ResizeRule(last.Resize, breakpoint);
        return this;
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
            ResizeRule rule = _rules[i];
            string cls = rule.Resize;
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

    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this resize builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
