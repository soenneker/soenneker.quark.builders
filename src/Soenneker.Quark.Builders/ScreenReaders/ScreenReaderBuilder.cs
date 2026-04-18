
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified screen reader builder with fluent API for chaining screen reader rules.
/// </summary>
[TailwindPrefix("sr-", Responsive = true)]
public sealed class ScreenReaderBuilder : CssBuilderBase
{
    private readonly List<ScreenReaderRule> _rules = new(4);

    internal ScreenReaderBuilder(string type, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScreenReaderRule(type, breakpoint));
    }

    internal ScreenReaderBuilder(ScreenReaderEnum type, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScreenReaderRule(type.Value, breakpoint));
    }

    internal ScreenReaderBuilder(List<ScreenReaderRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the screen reader to only (sr-only).
    /// </summary>
    public ScreenReaderBuilder Only => ChainWithType(ScreenReaderEnum.Only);

    /// <summary>
    /// Applies the screen reader on phone breakpoint.
    /// </summary>
    public ScreenReaderBuilder OnBase => ChainWithBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the screen reader on small breakpoint (≥640px).
    /// </summary>
    public ScreenReaderBuilder OnSm => ChainWithBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies the screen reader on tablet breakpoint.
    /// </summary>
    public ScreenReaderBuilder OnMd => ChainWithBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies the screen reader on laptop breakpoint.
    /// </summary>
    public ScreenReaderBuilder OnLg => ChainWithBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies the screen reader on desktop breakpoint.
    /// </summary>
    public ScreenReaderBuilder OnXl => ChainWithBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies the screen reader on the 2xl breakpoint.
    /// </summary>
    public ScreenReaderBuilder On2xl => ChainWithBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScreenReaderBuilder ChainWithType(string type)
    {
        _rules.Add(new ScreenReaderRule(type, null));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScreenReaderBuilder ChainWithType(ScreenReaderEnum type)
    {
        _rules.Add(new ScreenReaderRule(type.Value, null));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScreenReaderBuilder ChainWithBreakpoint(BreakpointType breakpoint)
    {
        if (_rules.Count == 0)
        {
            _rules.Add(new ScreenReaderRule("only", breakpoint));
            return this;
        }

        int lastIdx = _rules.Count - 1;
        ScreenReaderRule last = _rules[lastIdx];
        _rules[lastIdx] = new ScreenReaderRule(last.Type, breakpoint);
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
            ScreenReaderRule rule = _rules[i];
            string cls = rule.Type;
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
    /// Returns the CSS class string representation of this screen reader builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
