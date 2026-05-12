using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Max-height builder with fluent API. Tailwind-first (max-h-*).
/// </summary>
[TailwindPrefix("max-h-", Responsive = true)]
public sealed class MaxHeightBuilder : CssBuilderBase<MaxHeightBuilder>
{
    private readonly List<UtilityRule> _rules = new(4);

    internal MaxHeightBuilder()
    {
    }

    internal MaxHeightBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new UtilityRule(value, breakpoint));
    }

    public MaxHeightBuilder IsNone => Chain("max-h-none");
    public MaxHeightBuilder Is0 => Chain("max-h-0");
    public MaxHeightBuilder IsPx => Chain("max-h-px");
    public MaxHeightBuilder IsFull => Chain("max-h-full");
    public MaxHeightBuilder IsScreen => Chain("max-h-screen");
    public MaxHeightBuilder IsSvh => Chain("max-h-svh");
    public MaxHeightBuilder IsLvh => Chain("max-h-lvh");
    public MaxHeightBuilder IsDvh => Chain("max-h-dvh");
    public MaxHeightBuilder IsMin => Chain("max-h-min");
    public MaxHeightBuilder IsMax => Chain("max-h-max");
    public MaxHeightBuilder IsFit => Chain("max-h-fit");
    public MaxHeightBuilder Token(string value) => Chain(Normalize(value));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MaxHeightBuilder Chain(string value)
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
    private static string Normalize(string value) => value.StartsWith("max-h-") ? value : "max-h-" + value;
}
