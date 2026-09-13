
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
    private RuleList<ScreenReaderRule> _rules;

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
    public ScreenReaderBuilder Only => ChainWithType(ScreenReaderEnum.OnlyValue);

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

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ScreenReaderRule rule = _rules[0];
            return ClassWriter.Render(rule.Type, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ScreenReaderRule rule = _rules[i];
                writer.Add(rule.Type, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
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
