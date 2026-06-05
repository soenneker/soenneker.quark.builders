
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified screen reader builder with fluent API for chaining screen reader rules.
/// </summary>
[TailwindPrefix("sr-", Responsive = true)]
public sealed class ScreenReaderBuilder : CssBuilderBase<ScreenReaderBuilder>
{
    private readonly List<ScreenReaderRule> _rules = new(4);

    internal ScreenReaderBuilder()
    {
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScreenReaderBuilder ChainWithType(string type)
    {
        _rules.Add(new ScreenReaderRule(type, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScreenReaderBuilder ChainWithType(ScreenReaderEnum type)
    {
        _rules.Add(new ScreenReaderRule(type.Value, null, ConsumePendingModifierChain()));
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

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

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
    /// Returns the CSS class string representation of this screen reader builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
