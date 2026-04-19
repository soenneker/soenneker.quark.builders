
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Height builder with fluent API for chaining height rules.
/// Tailwind-first and shadcn-friendly (h-* and common tokens).
/// </summary>
[TailwindPrefix("h-", Responsive = true)]
public sealed class HeightBuilder : CssBuilderBase
{
    private readonly List<HeightRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal HeightBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new HeightRule(size, breakpoint));
    }

    internal HeightBuilder(List<HeightRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Spacing/sizing scale step `25` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 25` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is25 => ChainWithSize("h-1/4");
    /// <summary>
    /// Spacing/sizing scale step `50` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 50` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is50 => ChainWithSize("h-1/2");
    /// <summary>
    /// Spacing/sizing scale step `75` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 75` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is75 => ChainWithSize("h-3/4");
    /// <summary>
    /// Spacing/sizing scale step `100` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 100` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is100 => ChainWithSize("h-full");

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is0 => ChainWithSize("h-0");
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is8 => ChainWithSize("h-8");
    /// <summary>
    /// Spacing/sizing scale step `16` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 16` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is16 => ChainWithSize("h-16");
    /// <summary>
    /// Fluent step for `Is Px` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder IsPx => ChainWithSize("h-px");
    /// <summary>
    /// Fluent step for `Is Full` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder IsFull => ChainWithSize("h-full");
    /// <summary>
    /// Fluent step for `Is Screen` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder IsScreen => ChainWithSize("h-screen");
    /// <summary>
    /// Fluent step for `Is Fit` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder IsFit => ChainWithSize("h-fit");
    /// <summary>
    /// Fluent step for `Is Min` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder IsMin => ChainWithSize("h-min");
    /// <summary>
    /// Fluent step for `Is Max` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder IsMax => ChainWithSize("h-max");

    /// <summary>
    /// Fluent step for `Is1of2` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder Is1of2 => ChainWithSize("h-1/2");
    /// <summary>
    /// Fluent step for `Is1of3` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder Is1of3 => ChainWithSize("h-1/3");
    /// <summary>
    /// Fluent step for `Is2of3` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder Is2of3 => ChainWithSize("h-2/3");
    /// <summary>
    /// Fluent step for `Is1of4` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder Is1of4 => ChainWithSize("h-1/4");
    /// <summary>
    /// Fluent step for `Is2of4` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder Is2of4 => ChainWithSize("h-2/4");
    /// <summary>
    /// Fluent step for `Is3of4` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public HeightBuilder Is3of4 => ChainWithSize("h-3/4");

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public HeightBuilder Auto => ChainWithSize("h-auto");

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint. In Tailwind’s mobile‑first model, unprefixed utilities apply from 0px unless a larger breakpoint overrides them.
    /// </summary>
    public HeightBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public HeightBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public HeightBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public HeightBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public HeightBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public HeightBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    /// <summary>
    /// Applies an arbitrary Tailwind height token (e.g. "72", "[18rem]", "full").
    /// </summary>
    public HeightBuilder Token(string token) => ChainWithSize(NormalizeHeightClass(token));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private HeightBuilder ChainWithSize(string size)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new HeightRule(size, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private HeightBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
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
            HeightRule rule = _rules[i];
            string cls = rule.Size;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizeHeightClass(string size)
    {
        if (size.Length == 0)
            return string.Empty;

        return size.StartsWith("h-") ? size : "h-" + size;
    }
}
