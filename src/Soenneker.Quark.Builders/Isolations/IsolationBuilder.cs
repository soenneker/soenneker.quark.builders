
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
    private readonly List<IsolationRule> _rules = new(4);

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
    public IsolationBuilder Auto => Chain(IsolationEnum.Auto);
    /// <summary>
    /// Fluent step for `Isolate` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public IsolationBuilder Isolate => Chain(IsolationEnum.Isolate);


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
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (IsolationRule rule in _rules)
        {
            if (rule.Value.Length == 0)
                continue;

            string cls = rule.Value;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
