
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Outline style builder. Tailwind: outline-none, outline, outline-dashed, outline-dotted, outline-double.
/// </summary>
[TailwindPrefix("outline-", Responsive = true)]
public sealed class OutlineStyleBuilder : CssBuilderBase
{
    private readonly List<OutlineStyleRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal OutlineStyleBuilder(OutlineStyleEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new OutlineStyleRule(value, breakpoint));
    }

    internal OutlineStyleBuilder(List<OutlineStyleRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public OutlineStyleBuilder None => Chain(OutlineStyleEnum.None);
    /// <summary>
    /// Fluent step for `Solid` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OutlineStyleBuilder Solid => Chain(OutlineStyleEnum.Solid);
    /// <summary>
    /// Fluent step for `Dashed` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OutlineStyleBuilder Dashed => Chain(OutlineStyleEnum.Dashed);
    /// <summary>
    /// Fluent step for `Dotted` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OutlineStyleBuilder Dotted => Chain(OutlineStyleEnum.Dotted);
    /// <summary>
    /// Fluent step for `Double` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public OutlineStyleBuilder Double => Chain(OutlineStyleEnum.Double);

    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public OutlineStyleBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public OutlineStyleBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public OutlineStyleBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public OutlineStyleBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public OutlineStyleBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OutlineStyleBuilder Chain(OutlineStyleEnum value)
    {
        _rules.Add(new OutlineStyleRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OutlineStyleBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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

    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (OutlineStyleRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
