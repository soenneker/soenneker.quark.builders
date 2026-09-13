
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified z-index builder with fluent API for chaining z-index rules.
/// </summary>
[TailwindPrefix("z-", Responsive = true)]
public sealed class ZIndexBuilder : CssBuilderBase<ZIndexBuilder>
{
    private RuleList<ZIndexRule> _rules;

    internal ZIndexBuilder()
    {
    }

    internal ZIndexBuilder(ZIndexEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ZIndexRule(value, breakpoint));
    }

    internal ZIndexBuilder(List<ZIndexRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the z-index to -1.
    /// </summary>
    public ZIndexBuilder Negative1 => Chain(ZIndexEnum.Negative1);

    /// <summary>
    /// Sets the z-index to 0.
    /// </summary>
    public ZIndexBuilder Is0 => Chain(ZIndexEnum.Is0);

    /// <summary>
    /// Sets the z-index to 1.
    /// </summary>
    public ZIndexBuilder Is1 => Chain(ZIndexEnum.Is1);

    /// <summary>
    /// Sets the z-index to 2.
    /// </summary>
    public ZIndexBuilder Is2 => Chain(ZIndexEnum.Is2);

    /// <summary>
    /// Sets the z-index to 3.
    /// </summary>
    public ZIndexBuilder Is3 => Chain(ZIndexEnum.Is3);

    /// <summary>
    /// Sets the z-index to 10.
    /// </summary>
    public ZIndexBuilder Is10 => Chain(ZIndexEnum.Is10);

    /// <summary>
    /// Sets the z-index to 50.
    /// </summary>
    public ZIndexBuilder Is50 => Chain(ZIndexEnum.Is50);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ZIndexBuilder Chain(ZIndexEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new ZIndexRule(value, bp, ConsumePendingModifierChain()));
        return this;
    }


    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ZIndexRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ZIndexRule rule = _rules[i];
                writer.Add(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
