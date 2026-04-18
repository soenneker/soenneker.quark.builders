
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// CSS contain builder. Tailwind: contain-none, contain-size, contain-layout, contain-style, contain-paint, contain-strict, contain-content.
/// </summary>
[TailwindPrefix("contain-", Responsive = true)]
public sealed class ContainBuilder : CssBuilderBase
{
    private readonly List<ContainRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal ContainBuilder(ContainEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ContainRule(value, breakpoint));
    }

    internal ContainBuilder(List<ContainRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public ContainBuilder None => Chain(ContainEnum.None);
    /// <summary>
    /// Fluent step for `Size` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Size => Chain(ContainEnum.Size);
    /// <summary>
    /// Fluent step for `Layout` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Layout => Chain(ContainEnum.Layout);
    /// <summary>
    /// Fluent step for `Style` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Style => Chain(ContainEnum.Style);
    /// <summary>
    /// Fluent step for `Paint` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Paint => Chain(ContainEnum.Paint);
    /// <summary>
    /// Fluent step for `Strict` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Strict => Chain(ContainEnum.Strict);
    /// <summary>
    /// Fluent step for `Content` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public ContainBuilder Content => Chain(ContainEnum.Content);

    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public ContainBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public ContainBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public ContainBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public ContainBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public ContainBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ContainBuilder Chain(ContainEnum value)
    {
        _rules.Add(new ContainRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ContainBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
        foreach (ContainRule rule in _rules)
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
