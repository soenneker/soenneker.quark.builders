
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// CSS isolation builder. Tailwind: isolation-auto, isolation-isolate.
/// </summary>
[TailwindPrefix("isolation-", Responsive = true)]
public sealed class IsolationBuilder : CssBuilderBase<IsolationBuilder>
{
    private RuleList<IsolationRule> _rules;

    internal IsolationBuilder()
    {
    }

    internal IsolationBuilder(IsolationEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new IsolationRule(value.Value, breakpoint));
    }

    internal IsolationBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new IsolationRule(value, breakpoint));
    }

    internal IsolationBuilder(List<IsolationRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public IsolationBuilder Auto => Chain(IsolationEnum.AutoValue);
    /// <summary>
    /// Fluent step for `Isolate` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public IsolationBuilder Isolate => Chain(IsolationEnum.IsolateValue);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private IsolationBuilder Chain(IsolationEnum value)
    {
        _rules.Add(new IsolationRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private IsolationBuilder Chain(string value)
    {
        _rules.Add(new IsolationRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            IsolationRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                IsolationRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
