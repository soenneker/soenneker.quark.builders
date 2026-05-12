using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Min-height builder with fluent API. Tailwind-first (min-h-*).
/// </summary>
[TailwindPrefix("min-h-", Responsive = true)]
public sealed class MinHeightBuilder : CssBuilderBase<MinHeightBuilder>
{
    private readonly List<UtilityRule> _rules = new(4);

    internal MinHeightBuilder()
    {
    }

    internal MinHeightBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new UtilityRule(value, breakpoint));
    }

    public MinHeightBuilder Is0 => Chain("min-h-0");
    public MinHeightBuilder IsPx => Chain("min-h-px");
    public MinHeightBuilder IsFull => Chain("min-h-full");
    public MinHeightBuilder IsScreen => Chain("min-h-screen");
    public MinHeightBuilder IsSvh => Chain("min-h-svh");
    public MinHeightBuilder IsLvh => Chain("min-h-lvh");
    public MinHeightBuilder IsDvh => Chain("min-h-dvh");
    public MinHeightBuilder IsMin => Chain("min-h-min");
    public MinHeightBuilder IsMax => Chain("min-h-max");
    public MinHeightBuilder IsFit => Chain("min-h-fit");
    public MinHeightBuilder Token(string value) => Chain(Normalize(value));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MinHeightBuilder Chain(string value)
    {
        _rules.Add(new UtilityRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            UtilityRule rule = _rules[i];
            string cls = rule.Value;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string Normalize(string value) => value.StartsWith("min-h-") ? value : "min-h-" + value;
}
