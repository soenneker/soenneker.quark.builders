
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified truncate builder with fluent API for chaining truncate rules.
/// </summary>
[TailwindPrefix("truncate", Responsive = true)]
public sealed class TruncateBuilder : CssBuilderBase<TruncateBuilder>
{
    private RuleList<TruncateRule> _rules;

    internal TruncateBuilder()
    {
    }

    internal TruncateBuilder(BreakpointType? breakpoint)
    {
        _rules.Add(new TruncateRule(breakpoint));
    }

    internal TruncateBuilder(List<TruncateRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public TruncateBuilder Default => Chain();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TruncateBuilder Chain()
    {
        _rules.Add(new TruncateRule(null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            TruncateRule rule = _rules[0];
            return ClassWriter.Render(TruncateEnum.DefaultValue, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                TruncateRule rule = _rules[i];
                writer.Add(TruncateEnum.DefaultValue, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// Returns the CSS class string representation of this truncate builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
