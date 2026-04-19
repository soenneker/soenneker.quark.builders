using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind overscroll-behavior builder supporting both axis-specific and global utilities.
/// </summary>
[TailwindPrefix("overscroll-", Responsive = true)]
public sealed class OverscrollBuilder : CssBuilderBase
{
    private readonly List<OverscrollRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal OverscrollBuilder(OverscrollEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new OverscrollRule(value.Value, breakpoint));
    }

    internal OverscrollBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new OverscrollRule(value, breakpoint));
    }

    internal OverscrollBuilder(List<OverscrollRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public OverscrollBuilder Auto => Chain(OverscrollEnum.Auto);
    /// <summary>
    /// Fluent step for `Contain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder Contain => Chain(OverscrollEnum.Contain);
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public OverscrollBuilder None => Chain(OverscrollEnum.None);

    /// <summary>
    /// Fluent step for `XAuto` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder XAuto => Chain(OverscrollEnum.XAuto);
    /// <summary>
    /// Fluent step for `XContain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder XContain => Chain(OverscrollEnum.XContain);
    /// <summary>
    /// Fluent step for `XNone` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder XNone => Chain(OverscrollEnum.XNone);

    /// <summary>
    /// Fluent step for `YAuto` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder YAuto => Chain(OverscrollEnum.YAuto);
    /// <summary>
    /// Fluent step for `YContain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder YContain => Chain(OverscrollEnum.YContain);
    /// <summary>
    /// Fluent step for `YNone` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OverscrollBuilder YNone => Chain(OverscrollEnum.YNone);

    /// <summary>
    /// Applies an exact Tailwind overscroll class token, e.g. "overscroll-none".
    /// </summary>
    public OverscrollBuilder Token(string token) => Chain(token);

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint. In Tailwind’s mobile-first model, unprefixed utilities apply from 0px unless a larger breakpoint overrides them.
    /// </summary>
    public OverscrollBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public OverscrollBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public OverscrollBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public OverscrollBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public OverscrollBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public OverscrollBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OverscrollBuilder Chain(OverscrollEnum value)
    {
        return Chain(value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OverscrollBuilder Chain(string value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new OverscrollRule(value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OverscrollBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
            OverscrollRule rule = _rules[i];
            string cls = rule.Value;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString()
    {
        return ToClass();
    }
}
