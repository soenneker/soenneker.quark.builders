
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified margin builder with fluent API for chaining margin rules.
/// </summary>
[TailwindPrefix("m-", Responsive = true)]
public sealed class MarginBuilder : CssBuilderBase
{
    private readonly List<MarginRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal MarginBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new MarginRule(size, ElementSideEnum.All, breakpoint));
    }

    internal MarginBuilder(List<MarginRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

	/// <summary>
	/// Applies margin from the top side.
	/// </summary>
    public MarginBuilder FromTop => AddRule(ElementSideEnum.Top);
	/// <summary>
	/// Applies margin from the right side.
	/// </summary>
    public MarginBuilder FromRight => AddRule(ElementSideEnum.Right);
	/// <summary>
	/// Applies margin from the bottom side.
	/// </summary>
    public MarginBuilder FromBottom => AddRule(ElementSideEnum.Bottom);
	/// <summary>
	/// Applies margin from the left side.
	/// </summary>
    public MarginBuilder FromLeft => AddRule(ElementSideEnum.Left);
	/// <summary>
	/// Applies margin on the horizontal axis (left and right).
	/// </summary>
    public MarginBuilder OnX => AddRule(ElementSideEnum.Horizontal);
	/// <summary>
	/// Applies margin on the vertical axis (top and bottom).
	/// </summary>
    public MarginBuilder OnY => AddRule(ElementSideEnum.Vertical);
	/// <summary>
	/// Applies margin on all sides.
	/// </summary>
    public MarginBuilder OnAll => AddRule(ElementSideEnum.All);
	/// <summary>
	/// Applies margin from the inline start.
	/// </summary>
    public MarginBuilder FromStart => AddRule(ElementSideEnum.InlineStart);
	/// <summary>
	/// Applies margin from the inline end.
	/// </summary>
    public MarginBuilder FromEnd => AddRule(ElementSideEnum.InlineEnd);

	/// <summary>
	/// Sets the margin to auto.
	/// </summary>
    public MarginBuilder Auto => ChainWithSize(MarginScaleEnum.Auto);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public MarginBuilder Is0 => ChainWithSize(MarginScaleEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public MarginBuilder Is1 => ChainWithSize(MarginScaleEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public MarginBuilder Is2 => ChainWithSize(MarginScaleEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public MarginBuilder Is3 => ChainWithSize(MarginScaleEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public MarginBuilder Is4 => ChainWithSize(MarginScaleEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public MarginBuilder Is5 => ChainWithSize(MarginScaleEnum.Is5);
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public MarginBuilder Is8 => ChainWithSize(MarginScaleEnum.Is8);

	/// <summary>
	/// Sets the margin size from an arbitrary Tailwind spacing token.
	/// </summary>
    public MarginBuilder Token(string value) => ChainWithSize(NormalizeMarginClass(value));

	/// <summary>
	/// Applies the margin on phone breakpoint.
	/// </summary>
    public MarginBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
	/// <summary>
	/// Applies the margin on small breakpoint (≥640px).
	/// </summary>
    public MarginBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
	/// <summary>
	/// Applies the margin on tablet breakpoint.
	/// </summary>
    public MarginBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
	/// <summary>
	/// Applies the margin on laptop breakpoint.
	/// </summary>
    public MarginBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
	/// <summary>
	/// Applies the margin on desktop breakpoint.
	/// </summary>
    public MarginBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
	/// <summary>
	/// Applies the margin on the 2xl breakpoint.
	/// </summary>
    public MarginBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MarginBuilder AddRule(ElementSideEnum side)
    {
        string size = _rules.Count > 0 ? _rules[^1].Size : MarginScaleEnum.Is0Value;
        BreakpointType? existingBp = _rules.Count > 0 ? _rules[^1].Breakpoint : null;
        BreakpointType? bp = _pendingBreakpoint ?? existingBp;
        _pendingBreakpoint = null;

        if (_rules.Count > 0 && ReferenceEquals(_rules[^1].Side, ElementSideEnum.All))
        {
            _rules[^1] = new MarginRule(size, side, bp);
        }
        else
        {
            _rules.Add(new MarginRule(size, side, bp));
        }

        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MarginBuilder ChainWithSize(string size)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new MarginRule(size, ElementSideEnum.All, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MarginBuilder ChainWithSize(MarginScaleEnum scale)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new MarginRule(scale.Value, ElementSideEnum.All, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MarginBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    /// <summary>Gets the CSS class string for the current configuration.</summary>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            MarginRule rule = _rules[i];

            string cls = ApplySide(rule.Size, rule.Side);
            if (cls.Length == 0)
                continue;

            string bpTok = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bpTok.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bpTok);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizeMarginClass(string size)
    {
        if (size.Length == 0)
            return string.Empty;

        if (size.StartsWith("-m-") || size.StartsWith("m-"))
            return size;

        return size[0] == '-' ? "-m-" + size[1..] : "m-" + size;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ApplySide(string sizeClass, ElementSideEnum side)
    {
        if (sizeClass.Length == 0)
            return string.Empty;

        if (ReferenceEquals(side, ElementSideEnum.All))
            return sizeClass;

        bool negative = sizeClass[0] == '-';
        string classWithoutNegative = negative ? sizeClass[1..] : sizeClass;

        if (!classWithoutNegative.StartsWith("m-"))
            return sizeClass;

        string result = "m" + side.Value + classWithoutNegative[1..];
        return negative ? "-" + result : result;
    }

}
