
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll padding builder. Tailwind: scroll-p-*, scroll-pt-*, scroll-pr-*, etc.
/// </summary>
[TailwindPrefix("scroll-p", Responsive = true)]
public sealed class ScrollPaddingBuilder : ICssBuilder
{
    private readonly List<ScrollPaddingRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    private const string _baseToken = "scroll-p";
    internal ScrollPaddingBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollPaddingRule(size, ElementSideEnum.All, breakpoint));
    }

    internal ScrollPaddingBuilder(List<ScrollPaddingRule> rules)
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
    public ScrollPaddingBuilder Is0 => ChainWithSize(ScrollPaddingScaleEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is1 => ChainWithSize(ScrollPaddingScaleEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is2 => ChainWithSize(ScrollPaddingScaleEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is3 => ChainWithSize(ScrollPaddingScaleEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is4 => ChainWithSize(ScrollPaddingScaleEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public ScrollPaddingBuilder Is5 => ChainWithSize(ScrollPaddingScaleEnum.Is5);
    /// <summary>
    /// One pixel (`px` unit) — hairline borders, fixed 1px tracks, etc.
    /// </summary>
    public ScrollPaddingBuilder Px => ChainWithSize("px");

    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public ScrollPaddingBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public ScrollPaddingBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public ScrollPaddingBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public ScrollPaddingBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public ScrollPaddingBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollPaddingBuilder AddRule(ElementSideEnum side)
    {
        BreakpointType? pending = ConsumePendingBreakpoint();
        string size = _rules.Count > 0 ? _rules[^1].Size : ScrollPaddingScaleEnum.Is0Value;
        BreakpointType? bp = pending ?? (_rules.Count > 0 ? _rules[^1].Breakpoint : null);
        if (_rules.Count > 0 && ReferenceEquals(_rules[^1].Side, ElementSideEnum.All))
            _rules[^1] = new ScrollPaddingRule(size, side, bp);
        else
            _rules.Add(new ScrollPaddingRule(size, side, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollPaddingBuilder ChainWithSize(string size)
    {
        _rules.Add(new ScrollPaddingRule(size, ElementSideEnum.All, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollPaddingBuilder ChainWithSize(ScrollPaddingScaleEnum scale)
    {
        _rules.Add(new ScrollPaddingRule(scale.Value, ElementSideEnum.All, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollPaddingBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    public string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            ScrollPaddingRule rule = _rules[i];
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

    public string ToStyle() => string.Empty;

    public override string ToString() => ToClass();

    private static string GetSizeToken(string size) => size switch
    {
        ScrollPaddingScaleEnum.Is0Value => "0",
        ScrollPaddingScaleEnum.Is1Value => "1",
        ScrollPaddingScaleEnum.Is2Value => "2",
        ScrollPaddingScaleEnum.Is3Value => "3",
        ScrollPaddingScaleEnum.Is4Value => "4",
        ScrollPaddingScaleEnum.Is5Value => "5",
        "px" => "px",
        _ => string.Empty
    };

}
