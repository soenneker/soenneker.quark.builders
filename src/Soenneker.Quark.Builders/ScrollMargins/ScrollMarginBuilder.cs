
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll margin builder. Tailwind: scroll-m-*, scroll-mt-*, scroll-mr-*, etc.
/// </summary>
[TailwindPrefix("scroll-m", Responsive = true)]
public sealed class ScrollMarginBuilder : CssBuilderBase<ScrollMarginBuilder>
{
    private readonly List<ScrollMarginRule> _rules = new(4);
    private ElementSideEnum? _pendingSide;

    internal ScrollMarginBuilder()
    {
    }

    internal ScrollMarginBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollMarginRule(size, ElementSideEnum.All, breakpoint));
    }

    internal ScrollMarginBuilder(ElementSideEnum side)
    {
        _pendingSide = side;
    }

    internal ScrollMarginBuilder(List<ScrollMarginRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `From Top` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder FromTop => AddRule(ElementSideEnum.Top);
    /// <summary>
    /// Fluent step for `From Right` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder FromRight => AddRule(ElementSideEnum.Right);
    /// <summary>
    /// Fluent step for `From Bottom` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder FromBottom => AddRule(ElementSideEnum.Bottom);
    /// <summary>
    /// Fluent step for `From Left` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder FromLeft => AddRule(ElementSideEnum.Left);
    /// <summary>
    /// Fluent step for `On X` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder OnX => AddRule(ElementSideEnum.Horizontal);
    /// <summary>
    /// Fluent step for `On Y` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder OnY => AddRule(ElementSideEnum.Vertical);
    /// <summary>
    /// Fluent step for `On All` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder OnAll => AddRule(ElementSideEnum.All);
    /// <summary>
    /// Fluent step for `From Start` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder FromStart => AddRule(ElementSideEnum.InlineStart);
    /// <summary>
    /// Fluent step for `From End` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ScrollMarginBuilder FromEnd => AddRule(ElementSideEnum.InlineEnd);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollMarginBuilder Is0 => ChainWithSize(ScrollMarginScaleEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollMarginBuilder Is1 => ChainWithSize(ScrollMarginScaleEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `1.5` — uses Tailwind’s default spacing scale.
    /// </summary>
    public ScrollMarginBuilder Is1_5 => ChainWithSize(ScrollMarginScaleEnum.Is1_5);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollMarginBuilder Is2 => ChainWithSize(ScrollMarginScaleEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollMarginBuilder Is3 => ChainWithSize(ScrollMarginScaleEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollMarginBuilder Is4 => ChainWithSize(ScrollMarginScaleEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollMarginBuilder Is5 => ChainWithSize(ScrollMarginScaleEnum.Is5);
    /// <summary>
    /// Spacing/sizing scale step `24` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 24` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollMarginBuilder Is24 => ChainWithSize(ScrollMarginScaleEnum.Is24);
    /// <summary>
    /// One pixel (`px` unit) — hairline borders, fixed 1px tracks, etc.
    /// </summary>
    public ScrollMarginBuilder Px => ChainWithSize(ScrollMarginScaleEnum.Px);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollMarginBuilder AddRule(ElementSideEnum side)
    {
        _pendingSide = side;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollMarginBuilder ChainWithSize(string size)
    {
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
        _rules.Add(new ScrollMarginRule(size, side, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollMarginBuilder ChainWithSize(ScrollMarginScaleEnum scale)
    {
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
        _rules.Add(new ScrollMarginRule(scale.Value, side, null, ConsumePendingModifierChain()));
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
        for (var i = 0; i < _rules.Count; i++)
        {
            ScrollMarginRule rule = _rules[i];
            string baseClass = BuildClass(rule);
            if (baseClass.Length == 0) continue;
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(baseClass);
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

    private static string BuildClass(ScrollMarginRule rule)
    {
        string cls = ApplySide(rule.Size, rule.Side);
        if (cls.Length == 0)
            return string.Empty;

        string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
        if (bp.Length != 0)
            cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

        if (rule.ModifierChain is { Length: > 0 })
            cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

        return cls;
    }

    private static string ApplySide(string sizeClass, ElementSideEnum side)
    {
        if (sizeClass.Length == 0)
            return string.Empty;

        if (ReferenceEquals(side, ElementSideEnum.All))
            return sizeClass;

        return sizeClass.StartsWith("scroll-m-") ? "scroll-m" + side.Value + sizeClass["scroll-m".Length..] : sizeClass;
    }

}
