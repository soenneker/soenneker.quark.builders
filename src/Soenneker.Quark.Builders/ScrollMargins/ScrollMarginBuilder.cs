
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll margin builder. Tailwind: scroll-m-*, scroll-mt-*, scroll-mr-*, etc.
/// </summary>
[TailwindPrefix("scroll-m", Responsive = true)]
public sealed class ScrollMarginBuilder : CssBuilderBase
{
    private readonly List<ScrollMarginRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    private const string _baseToken = "scroll-m";
    internal ScrollMarginBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollMarginRule(size, ElementSideEnum.All, breakpoint));
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
    public ScrollMarginBuilder Is24 => ChainWithSize("24");
    /// <summary>
    /// One pixel (`px` unit) — hairline borders, fixed 1px tracks, etc.
    /// </summary>
    public ScrollMarginBuilder Px => ChainWithSize("px");

    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public ScrollMarginBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public ScrollMarginBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public ScrollMarginBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public ScrollMarginBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public ScrollMarginBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollMarginBuilder AddRule(ElementSideEnum side)
    {
        string size = _rules.Count > 0 ? _rules[^1].Size : ScrollMarginScaleEnum.Is0Value;
        BreakpointType? existingBp = _rules.Count > 0 ? _rules[^1].Breakpoint : null;
        BreakpointType? bp = _pendingBreakpoint ?? existingBp;
        _pendingBreakpoint = null;
        if (_rules.Count > 0 && ReferenceEquals(_rules[^1].Side, ElementSideEnum.All))
            _rules[^1] = new ScrollMarginRule(size, side, bp);
        else
            _rules.Add(new ScrollMarginRule(size, side, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollMarginBuilder ChainWithSize(string size)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new ScrollMarginRule(size, ElementSideEnum.All, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollMarginBuilder ChainWithSize(ScrollMarginScaleEnum scale)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new ScrollMarginRule(scale.Value, ElementSideEnum.All, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollMarginBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            ScrollMarginRule rule = _rules[i];
            string sizeTok = GetSizeToken(rule.Size);
            if (sizeTok.Length == 0) continue;
            string sideTok = rule.Side.Value;
            string baseClass = _baseToken + sideTok + "-" + sizeTok;
            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0) baseClass = BreakpointUtil.ApplyTailwindBreakpoint(baseClass, bp);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(baseClass);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();

    private static string GetSizeToken(string size) => size switch
    {
        ScrollMarginScaleEnum.Is0Value => "0",
        ScrollMarginScaleEnum.Is1Value => "1",
        ScrollMarginScaleEnum.Is2Value => "2",
        ScrollMarginScaleEnum.Is3Value => "3",
        ScrollMarginScaleEnum.Is4Value => "4",
        ScrollMarginScaleEnum.Is5Value => "5",
        "24" => "24",
        "px" => "px",
        _ => string.Empty
    };

}
