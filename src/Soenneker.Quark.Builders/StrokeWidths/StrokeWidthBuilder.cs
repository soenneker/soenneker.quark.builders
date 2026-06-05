
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Stroke width builder for SVG/CSS. Tailwind: stroke-0, stroke-1, stroke-2.
/// </summary>
[TailwindPrefix("stroke-", Responsive = true)]
public sealed class StrokeWidthBuilder : CssBuilderBase<StrokeWidthBuilder>
{
    private readonly List<StrokeWidthRule> _rules = new(4);

    internal StrokeWidthBuilder()
    {
    }

    internal StrokeWidthBuilder(StrokeWidthEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new StrokeWidthRule(value, breakpoint));
    }

    internal StrokeWidthBuilder(List<StrokeWidthRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public StrokeWidthBuilder Is0 => Chain(StrokeWidthEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public StrokeWidthBuilder Is1 => Chain(StrokeWidthEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public StrokeWidthBuilder Is2 => Chain(StrokeWidthEnum.Is2);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StrokeWidthBuilder Chain(StrokeWidthEnum value)
    {
        _rules.Add(new StrokeWidthRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (StrokeWidthRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
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
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
