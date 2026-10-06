using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll padding builder. Tailwind: scroll-p-*, scroll-pt-*, scroll-pr-*, etc.
/// </summary>
[TailwindPrefix("scroll-p", Responsive = true)]
public sealed class ScrollPaddingBuilder : CssBuilderBase<ScrollPaddingBuilder>
{
    /// <summary>Selects the logical block start side.</summary>
    public ScrollPaddingBuilder FromBlockStart => AddRule(ElementSideEnum.BlockStart);

    /// <summary>Selects the logical block end side.</summary>
    public ScrollPaddingBuilder FromBlockEnd => AddRule(ElementSideEnum.BlockEnd);


    private RuleList<UtilityRule> _rules;
    private ElementSideEnum? _pendingSide;

    internal ScrollPaddingBuilder()
    {
    }

    internal ScrollPaddingBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new UtilityRule(size, breakpoint));
    }

    internal ScrollPaddingBuilder(ElementSideEnum side)
    {
        _pendingSide = side;
    }

    internal ScrollPaddingBuilder(List<UtilityRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `From Top` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder FromTop => AddRule(ElementSideEnum.Top);
    /// <summary>
    /// Fluent step for `From Right` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder FromRight => AddRule(ElementSideEnum.Right);
    /// <summary>
    /// Fluent step for `From Bottom` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder FromBottom => AddRule(ElementSideEnum.Bottom);
    /// <summary>
    /// Fluent step for `From Left` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder FromLeft => AddRule(ElementSideEnum.Left);
    /// <summary>
    /// Fluent step for `On X` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder OnX => AddRule(ElementSideEnum.Horizontal);
    /// <summary>
    /// Fluent step for `On Y` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder OnY => AddRule(ElementSideEnum.Vertical);
    /// <summary>
    /// Fluent step for `On All` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder OnAll => AddRule(ElementSideEnum.All);
    /// <summary>
    /// Fluent step for `From Start` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder FromStart => AddRule(ElementSideEnum.InlineStart);
    /// <summary>
    /// Fluent step for `From End` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollPaddingBuilder FromEnd => AddRule(ElementSideEnum.InlineEnd);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is0 => ChainWithSize(ScrollPaddingScaleEnum.Is0Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is1 => ChainWithSize(ScrollPaddingScaleEnum.Is1Value);
    /// <summary>
    /// Spacing/sizing scale step `1.5` — uses Tailwind’s default spacing scale.
    /// </summary>
    public ScrollPaddingBuilder Is1_5 => ChainWithSize(ScrollPaddingScaleEnum.Is1_5Value);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is2 => ChainWithSize(ScrollPaddingScaleEnum.Is2Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is3 => ChainWithSize(ScrollPaddingScaleEnum.Is3Value);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is4 => ChainWithSize(ScrollPaddingScaleEnum.Is4Value);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is5 => ChainWithSize(ScrollPaddingScaleEnum.Is5Value);
    /// <summary>
    /// One pixel (`px` unit) — hairline borders, fixed 1px tracks, etc.
    /// </summary>
    public ScrollPaddingBuilder Px => ChainWithSize(ScrollPaddingScaleEnum.PxValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollPaddingBuilder AddRule(ElementSideEnum side)
    {
        _pendingSide = side;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollPaddingBuilder ChainWithSize(string size)
    {
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
        _rules.Add(new UtilityRule(CreateSideClass(size, side), null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollPaddingBuilder ChainWithSize(ScrollPaddingScaleEnum scale)
    {
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
        _rules.Add(new UtilityRule(CreateSideClass(scale.Value, side), null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            UtilityRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                UtilityRule rule = _rules[i];
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
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();

    private static string CreateSideClass(string sizeClass, ElementSideEnum side)
    {
        if (ReferenceEquals(side, ElementSideEnum.All))
            return sizeClass;

        return string.Concat("scroll-p", side.Value, sizeClass.AsSpan(8));
    }

}
