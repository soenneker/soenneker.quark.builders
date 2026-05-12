
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Inset (top/right/bottom/left) builder with fluent API. Tailwind: inset-*, top-*, right-*, bottom-*, left-*, start-*, end-*.
/// </summary>
[TailwindPrefix("inset-", Responsive = true)]
public sealed class InsetBuilder : CssBuilderBase<InsetBuilder>
{
    private readonly List<InsetRule> _rules = new(4);

    internal InsetBuilder()
    {
    }

    internal InsetBuilder(InsetScaleEnum size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new InsetRule(size, ElementSideEnum.All, breakpoint));
    }

    internal InsetBuilder(List<InsetRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `From Top` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder FromTop => AddRule(ElementSideEnum.Top);
    /// <summary>
    /// Fluent step for `From Right` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder FromRight => AddRule(ElementSideEnum.Right);
    /// <summary>
    /// Fluent step for `From Bottom` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder FromBottom => AddRule(ElementSideEnum.Bottom);
    /// <summary>
    /// Fluent step for `From Left` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder FromLeft => AddRule(ElementSideEnum.Left);
    /// <summary>
    /// Fluent step for `On X` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder OnX => AddRule(ElementSideEnum.Horizontal);
    /// <summary>
    /// Fluent step for `On Y` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder OnY => AddRule(ElementSideEnum.Vertical);
    /// <summary>
    /// Fluent step for `On All` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder OnAll => AddRule(ElementSideEnum.All);
    /// <summary>
    /// Fluent step for `From Start` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder FromStart => AddRule(ElementSideEnum.InlineStart);
    /// <summary>
    /// Fluent step for `From End` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public InsetBuilder FromEnd => AddRule(ElementSideEnum.InlineEnd);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public InsetBuilder Is0 => ChainWithSize(InsetScaleEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public InsetBuilder Is1 => ChainWithSize(InsetScaleEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public InsetBuilder Is2 => ChainWithSize(InsetScaleEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public InsetBuilder Is3 => ChainWithSize(InsetScaleEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public InsetBuilder Is4 => ChainWithSize(InsetScaleEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public InsetBuilder Is5 => ChainWithSize(InsetScaleEnum.Is5);
    /// <summary>
    /// One pixel (`px` unit) — hairline borders, fixed 1px tracks, etc.
    /// </summary>
    public InsetBuilder Px => ChainWithSize(InsetScaleEnum.Px);
    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public InsetBuilder Auto => ChainWithSize(InsetScaleEnum.Auto);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private InsetBuilder AddRule(ElementSideEnum side)
    {
        InsetScaleEnum size = _rules.Count > 0 ? _rules[^1].Size : InsetScaleEnum.Is0;
        BreakpointType? bp = _rules.Count > 0 ? _rules[^1].Breakpoint : null;
        string? modifierChain = ConsumePendingModifierChain();
        if (modifierChain is not { Length: > 0 } && _rules.Count > 0)
            modifierChain = _rules[^1].ModifierChain;
        if (_rules.Count > 0 && ReferenceEquals(_rules[^1].Side, ElementSideEnum.All))
            _rules[^1] = new InsetRule(size, side, bp, modifierChain);
        else
            _rules.Add(new InsetRule(size, side, bp, modifierChain));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private InsetBuilder ChainWithSize(InsetScaleEnum scale)
    {
        _rules.Add(new InsetRule(scale, ElementSideEnum.All, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            InsetRule rule = _rules[i];
            string cls = ApplySide(rule.Size.Value, rule.Side);
            if (cls.Length == 0) continue;
            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ApplySide(string sizeClass, ElementSideEnum side)
    {
        if (sizeClass.Length == 0)
            return string.Empty;

        if (ReferenceEquals(side, ElementSideEnum.All))
            return sizeClass;

        if (!sizeClass.StartsWith("inset-"))
            return sizeClass;

        string suffix = sizeClass["inset-".Length..];
        if (ReferenceEquals(side, ElementSideEnum.Top)) return "top-" + suffix;
        if (ReferenceEquals(side, ElementSideEnum.Right)) return "right-" + suffix;
        if (ReferenceEquals(side, ElementSideEnum.Bottom)) return "bottom-" + suffix;
        if (ReferenceEquals(side, ElementSideEnum.Left)) return "left-" + suffix;
        if (ReferenceEquals(side, ElementSideEnum.Horizontal) || ReferenceEquals(side, ElementSideEnum.LeftRight)) return "inset-x-" + suffix;
        if (ReferenceEquals(side, ElementSideEnum.Vertical) || ReferenceEquals(side, ElementSideEnum.TopBottom)) return "inset-y-" + suffix;
        if (ReferenceEquals(side, ElementSideEnum.InlineStart)) return "start-" + suffix;
        if (ReferenceEquals(side, ElementSideEnum.InlineEnd)) return "end-" + suffix;
        return string.Empty;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string? GetSizeValue(InsetScaleEnum size)
    {
        if (ReferenceEquals(size, InsetScaleEnum.Is0)) return "0";
        if (ReferenceEquals(size, InsetScaleEnum.Is1)) return "0.25rem";
        if (ReferenceEquals(size, InsetScaleEnum.Is2)) return "0.5rem";
        if (ReferenceEquals(size, InsetScaleEnum.Is3)) return "1rem";
        if (ReferenceEquals(size, InsetScaleEnum.Is4)) return "1.5rem";
        if (ReferenceEquals(size, InsetScaleEnum.Is5)) return "3rem";
        if (ReferenceEquals(size, InsetScaleEnum.Auto)) return "auto";
        if (ReferenceEquals(size, InsetScaleEnum.Px)) return "1px";
        return null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static (string? prop, string? val) GetInsetStyle(ElementSideEnum side, string sizeVal)
    {
        string? prop = null;
        if (ReferenceEquals(side, ElementSideEnum.All)) prop = "inset";
        else if (ReferenceEquals(side, ElementSideEnum.Top)) prop = "top";
        else if (ReferenceEquals(side, ElementSideEnum.Right)) prop = "right";
        else if (ReferenceEquals(side, ElementSideEnum.Bottom)) prop = "bottom";
        else if (ReferenceEquals(side, ElementSideEnum.Left)) prop = "left";
        else if (ReferenceEquals(side, ElementSideEnum.Horizontal) || ReferenceEquals(side, ElementSideEnum.LeftRight)) prop = "inset-inline";
        else if (ReferenceEquals(side, ElementSideEnum.Vertical) || ReferenceEquals(side, ElementSideEnum.TopBottom)) prop = "inset-block";
        else if (ReferenceEquals(side, ElementSideEnum.InlineStart)) prop = "inset-inline-start";
        else if (ReferenceEquals(side, ElementSideEnum.InlineEnd)) prop = "inset-inline-end";
        return (prop, sizeVal);
    }
}
