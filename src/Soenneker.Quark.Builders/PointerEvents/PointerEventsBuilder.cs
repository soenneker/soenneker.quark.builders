using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified pointer events builder with fluent API for chaining pointer events rules.
/// </summary>
[TailwindPrefix("pointer-events-", Responsive = true)]
public sealed class PointerEventsBuilder : CssBuilderBase<PointerEventsBuilder>
{
    private RuleList<PointerEventsRule> _rules;

    internal PointerEventsBuilder()
    {
    }

    internal PointerEventsBuilder(PointerEventsEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new PointerEventsRule(value, breakpoint));
    }

    internal PointerEventsBuilder(List<PointerEventsRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the pointer events to none.
    /// </summary>
    public PointerEventsBuilder None => Chain(PointerEventsEnum.None);

    /// <summary>
    /// Sets the pointer events to auto.
    /// </summary>
    public PointerEventsBuilder Auto => Chain(PointerEventsEnum.Auto);







    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PointerEventsBuilder Chain(PointerEventsEnum value)
    {
        _rules.Add(new PointerEventsRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            PointerEventsRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain ?? PendingModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                PointerEventsRule rule = _rules[i];
                writer.Add(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain ?? (i == _rules.Count - 1 ? PendingModifierChain : null));
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
