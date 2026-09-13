using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind/shadcn rounded classes.
/// </summary>
public sealed class RoundedBuilder : CssBuilderBase<RoundedBuilder>
{
    private RuleList<RoundedRule> _rules;

    private RoundedPositionEnum _pendingPosition = RoundedPositionEnum.All;
    private string? _pendingCtorModifier;

    private const string _base = "rounded";

    internal RoundedBuilder()
    {
    }

    internal RoundedBuilder(List<RoundedRule> rules, RoundedPositionEnum? position = null, BreakpointType? bp = null)
    {
        if (rules.Count > 0)
            _rules.AddRange(rules);

        _pendingPosition = position ?? RoundedPositionEnum.All;
        if (bp is not null)
            _pendingCtorModifier = BreakpointUtil.GetBreakpointToken(bp);
    }

    // ----- Positions -----

    /// <summary>
    /// Targets all corners (`rounded-*` with no corner suffix).
    /// </summary>
    public RoundedBuilder All => SetPosition(RoundedPositionEnum.All);
    /// <summary>
    /// Top corners only (`rounded-t-*`).
    /// </summary>
    public RoundedBuilder Top => SetPosition(RoundedPositionEnum.Top);
    /// <summary>
    /// Bottom corners only (`rounded-b-*`).
    /// </summary>
    public RoundedBuilder Bottom => SetPosition(RoundedPositionEnum.Bottom);
    /// <summary>
    /// Left corners only (`rounded-l-*`).
    /// </summary>
    public RoundedBuilder Left => SetPosition(RoundedPositionEnum.Left);
    /// <summary>
    /// Right corners only (`rounded-r-*`).
    /// </summary>
    public RoundedBuilder Right => SetPosition(RoundedPositionEnum.Right);

    /// <summary>
    /// Top-left corner only (`rounded-tl-*`).
    /// </summary>
    public RoundedBuilder TopLeft => SetPosition(RoundedPositionEnum.TopLeft);
    /// <summary>
    /// Top-right corner only (`rounded-tr-*`).
    /// </summary>
    public RoundedBuilder TopRight => SetPosition(RoundedPositionEnum.TopRight);
    /// <summary>
    /// Bottom-left corner only (`rounded-bl-*`).
    /// </summary>
    public RoundedBuilder BottomLeft => SetPosition(RoundedPositionEnum.BottomLeft);
    /// <summary>
    /// Bottom-right corner only (`rounded-br-*`).
    /// </summary>
    public RoundedBuilder BottomRight => SetPosition(RoundedPositionEnum.BottomRight);

    // ----- Sizes -----

    /// <summary>
    /// Default theme radius: `rounded` with no suffix — in Tailwind’s default config typically `0.25rem` (maps to shadcn `--radius` usage when you align tokens).
    /// </summary>
    public RoundedBuilder Default => Add(null);
    /// <summary>
    /// <c>rounded-none</c> — <c>border-radius: 0</c> on the selected corners (fully square corners).
    /// </summary>
    public RoundedBuilder None => Add("none");
    /// <summary>
    /// `rounded-sm` — small radius (default theme `0.125rem`).
    /// </summary>
    public RoundedBuilder Sm => Add("sm");
    /// <summary>
    /// `rounded-md` — medium radius (default theme `0.375rem`); common for cards and inputs in shadcn.
    /// </summary>
    public RoundedBuilder Md => Add("md");
    /// <summary>
    /// `rounded-lg` — large radius (default theme `0.5rem`).
    /// </summary>
    public RoundedBuilder Lg => Add("lg");
    /// <summary>
    /// `rounded-xl` — extra-large radius (default theme `0.75rem`).
    /// </summary>
    public RoundedBuilder Xl => Add("xl");
    /// <summary>
    /// `rounded-2xl` — 2× XL radius (default theme `1rem`).
    /// </summary>
    public RoundedBuilder TwoXl => Add("2xl");
    /// <summary>
    /// `rounded-3xl` — very large radius (default theme `1.5rem`).
    /// </summary>
    public RoundedBuilder ThreeXl => Add("3xl");
    /// <summary>
    /// “Full” extremum for this utility. For border radius this is `rounded-full` (`border-radius: 9999px`), producing pills/circles; for width/height often `100%` (`w-full` / `h-full`).
    /// </summary>
    public RoundedBuilder Full => Add("full");
    /// <summary>
    /// Custom <c>rounded-*</c> suffix: theme scale key, arbitrary length (for example <c>[2vw]</c>), or CSS variable reference aligned with shadcn’s <c>--radius</c> pattern.
    /// </summary>
    /// <param name="value">The segment after <c>rounded-</c> (and any corner prefix such as <c>tl-</c>).</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RoundedBuilder Token(string value) => Add(value);

    // ----- Core -----

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RoundedBuilder SetPosition(RoundedPositionEnum pos)
    {
        _pendingPosition = pos;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RoundedBuilder Add(string? size)
    {
        string? modifierChain = ConsumePendingModifierChain();
        if (modifierChain is not { Length: > 0 })
            modifierChain = _pendingCtorModifier;

        _rules.Add(new RoundedRule(size, _pendingPosition, null, modifierChain));

        _pendingPosition = RoundedPositionEnum.All;
        _pendingCtorModifier = null;

        return this;
    }

    // ----- Output -----

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            RoundedRule rule = _rules[0];
            return ClassWriter.Render(BuildClass(rule), BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                RoundedRule rule = _rules[i];
                writer.Add(BuildClass(rule), BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    private static string BuildClass(RoundedRule rule)
    {
        string position = rule.Position.Value;
        string? size = rule.SizeToken;
        if (position.Length == 0)
            return string.IsNullOrEmpty(size) ? _base : string.Concat(_base, "-", size);
        if (string.IsNullOrEmpty(size))
            return string.Concat(_base, "-", position);

        return string.Create(checked(_base.Length + 2 + position.Length + size.Length), (position, size), static (destination, state) =>
        {
            "rounded-".AsSpan().CopyTo(destination);
            int offset = _base.Length + 1;
            state.position.AsSpan().CopyTo(destination[offset..]);
            offset += state.position.Length;
            destination[offset++] = '-';
            state.size.AsSpan().CopyTo(destination[offset..]);
        });
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
}
