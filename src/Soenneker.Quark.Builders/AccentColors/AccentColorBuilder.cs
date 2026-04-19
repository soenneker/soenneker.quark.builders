using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Accent color builder for form controls. Tailwind: accent-auto, accent-primary, accent-*.
/// </summary>
[TailwindPrefix("accent-", Responsive = true)]
public sealed class AccentColorBuilder : CssBuilderBase
{
    private const string Prefix = "accent-";

    private readonly List<AccentColorRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal AccentColorBuilder(AccentColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AccentColorRule(value.Value, breakpoint));
    }

    internal AccentColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new AccentColorRule(value, breakpoint));
    }

    internal AccentColorBuilder(List<AccentColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public AccentColorBuilder Auto => Chain(AccentColorEnum.Auto);
    /// <summary>
    /// `accent-primary` — uses your theme primary (shadcn maps this to CSS variables).
    /// </summary>
    public AccentColorBuilder Primary => Chain(AccentColorEnum.Primary);
    /// <summary>
    /// Fully transparent color (`transparent`).
    /// </summary>
    public AccentColorBuilder Transparent => Chain(AccentColorEnum.Transparent);
    /// <summary>
    /// `currentColor` — uses the element’s computed `color` (common for icons and rings).
    /// </summary>
    public AccentColorBuilder Current => Chain(AccentColorEnum.Current);
    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint.
    /// </summary>
    public AccentColorBuilder OnBase => ChainBp(BreakpointType.Base);

    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public AccentColorBuilder OnSm => ChainBp(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public AccentColorBuilder OnMd => ChainBp(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public AccentColorBuilder OnLg => ChainBp(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public AccentColorBuilder OnXl => ChainBp(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public AccentColorBuilder On2xl => ChainBp(BreakpointType.Xxl);

    public AccentColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    public AccentColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AccentColorBuilder Chain(AccentColorEnum value)
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new AccentColorRule(value.Value, breakpoint));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AccentColorBuilder ChainClass(string value)
    {
        if (value.Length == 0)
            return this;

        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new AccentColorRule(value, breakpoint));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AccentColorBuilder ChainBp(BreakpointType bp)
    {
        _pendingBreakpoint = bp;
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (AccentColorRule rule in _rules)
        {
            string cls = rule.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle()
        => string.Empty;

    public override string ToString() => ToClass();
}
