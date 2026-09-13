using System;

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
    private RuleList<InsetRule> _rules;
    private ElementSideEnum? _pendingSide;

    internal InsetBuilder()
    {
    }

    internal InsetBuilder(InsetScaleEnum size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new InsetRule(size, ElementSideEnum.All, breakpoint));
    }

    internal InsetBuilder(ElementSideEnum side)
    {
        _pendingSide = side;
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
    /// Spacing/sizing scale step `1.5` — uses Tailwind’s default spacing scale.
    /// </summary>
    public InsetBuilder Is1_5 => ChainWithSize(InsetScaleEnum.Is1_5);
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
        _pendingSide = side;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private InsetBuilder ChainWithSize(InsetScaleEnum scale)
    {
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
        _rules.Add(new InsetRule(scale, side, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            InsetRule rule = _rules[0];
            return ClassWriter.Render(ApplySide(rule.Size.Value, rule.Side), BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                InsetRule rule = _rules[i];
                writer.Add(ApplySide(rule.Size.Value, rule.Side), BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ApplySide(string sizeClass, ElementSideEnum side)
    {
        if (sizeClass.Length == 0)
            return string.Empty;

        if (ReferenceEquals(side, ElementSideEnum.All))
            return sizeClass;

        if (!sizeClass.StartsWith("inset-"))
            return sizeClass;

        ReadOnlySpan<char> suffix = sizeClass.AsSpan("inset-".Length);
        if (ReferenceEquals(side, ElementSideEnum.Top)) return string.Concat("top-", suffix);
        if (ReferenceEquals(side, ElementSideEnum.Right)) return string.Concat("right-", suffix);
        if (ReferenceEquals(side, ElementSideEnum.Bottom)) return string.Concat("bottom-", suffix);
        if (ReferenceEquals(side, ElementSideEnum.Left)) return string.Concat("left-", suffix);
        if (ReferenceEquals(side, ElementSideEnum.Horizontal) || ReferenceEquals(side, ElementSideEnum.LeftRight)) return string.Concat("inset-x-", suffix);
        if (ReferenceEquals(side, ElementSideEnum.Vertical) || ReferenceEquals(side, ElementSideEnum.TopBottom)) return string.Concat("inset-y-", suffix);
        if (ReferenceEquals(side, ElementSideEnum.InlineStart)) return string.Concat("start-", suffix);
        if (ReferenceEquals(side, ElementSideEnum.InlineEnd)) return string.Concat("end-", suffix);
        return string.Empty;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string? GetSizeValue(InsetScaleEnum size)
    {
        if (ReferenceEquals(size, InsetScaleEnum.Is0)) return "0";
        if (ReferenceEquals(size, InsetScaleEnum.Is1)) return "0.25rem";
        if (ReferenceEquals(size, InsetScaleEnum.Is1_5)) return "0.375rem";
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
