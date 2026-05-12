
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Height builder with fluent API for chaining height rules.
/// Tailwind-first and shadcn-friendly (h-* and common tokens).
/// </summary>
[TailwindPrefix("h-", Responsive = true)]
public sealed class HeightBuilder : CssBuilderBase<HeightBuilder>
{
    private readonly List<HeightRule> _rules = new(4);

    internal HeightBuilder()
    {
    }

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
    public HeightBuilder Is0_5 => ChainWithSize("h-0.5");
    public HeightBuilder Is1 => ChainWithSize("h-1");
    public HeightBuilder Is1_5 => ChainWithSize("h-1.5");
    public HeightBuilder Is2 => ChainWithSize("h-2");
    public HeightBuilder Is3 => ChainWithSize("h-3");
    public HeightBuilder Is4 => ChainWithSize("h-4");
    public HeightBuilder Is5 => ChainWithSize("h-5");
    public HeightBuilder Is5_5 => ChainWithSize("h-5.5");
    public HeightBuilder Is6 => ChainWithSize("h-6");
    public HeightBuilder Is7 => ChainWithSize("h-7");
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is8 => ChainWithSize("h-8");
    public HeightBuilder Is9 => ChainWithSize("h-9");
    public HeightBuilder Is10 => ChainWithSize("h-10");
    public HeightBuilder Is11 => ChainWithSize("h-11");
    public HeightBuilder Is12 => ChainWithSize("h-12");
    public HeightBuilder Is14 => ChainWithSize("h-14");
    /// <summary>
    /// Spacing/sizing scale step `16` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 16` for integer spacing utilities unless overridden).
    /// </summary>
    public HeightBuilder Is16 => ChainWithSize("h-16");
    public HeightBuilder Is20 => ChainWithSize("h-20");
    public HeightBuilder Is24 => ChainWithSize("h-24");
    public HeightBuilder Is32 => ChainWithSize("h-32");
    public HeightBuilder Is36 => ChainWithSize("h-36");
    public HeightBuilder Is40 => ChainWithSize("h-40");
    public HeightBuilder Is44 => ChainWithSize("h-44");
    public HeightBuilder Is48 => ChainWithSize("h-48");
    public HeightBuilder Is52 => ChainWithSize("h-52");
    public HeightBuilder Is56 => ChainWithSize("h-56");
    public HeightBuilder Is60 => ChainWithSize("h-60");
    public HeightBuilder Is64 => ChainWithSize("h-64");
    public HeightBuilder Is72 => ChainWithSize("h-72");
    public HeightBuilder Is80 => ChainWithSize("h-80");
    public HeightBuilder Is96 => ChainWithSize("h-96");
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
    /// Applies an arbitrary Tailwind height token (e.g. "72", "[18rem]", "full").
    /// </summary>
    public HeightBuilder Token(string token) => ChainWithSize(NormalizeHeightClass(token));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private HeightBuilder ChainWithSize(string size)
    {
        BreakpointType? bp = null;
        _rules.Add(new HeightRule(size, bp, ConsumePendingModifierChain()));
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

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

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
