
using Soenneker.Extensions.String;

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// Simplified border builder with fluent API for chaining border rules.
/// </summary>
[TailwindPrefix("border-", Responsive = true)]
public sealed class BorderBuilder : ICssBuilder
{
    private readonly List<BorderRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    // ----- Class tokens -----
    private const string _baseToken = "border";

    internal BorderBuilder(string size, BreakpointType? breakpoint = null)
    {
        if (size.HasContent())
            _rules.Add(new BorderRule(size, ElementSideType.All, breakpoint));
    }

    internal BorderBuilder(List<BorderRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

	/// <summary>
	/// Applies border from the top side.
	/// </summary>
    public BorderBuilder FromTop => AddRule(ElementSideType.Top);
	/// <summary>
	/// Applies border from the right side.
	/// </summary>
    public BorderBuilder FromRight => AddRule(ElementSideType.Right);
	/// <summary>
	/// Applies border from the bottom side.
	/// </summary>
    public BorderBuilder FromBottom => AddRule(ElementSideType.Bottom);
	/// <summary>
	/// Applies border from the left side.
	/// </summary>
    public BorderBuilder FromLeft => AddRule(ElementSideType.Left);
	/// <summary>
	/// Applies border on the horizontal axis (left and right).
	/// </summary>
    public BorderBuilder OnX => AddRule(ElementSideType.Horizontal);
	/// <summary>
	/// Applies border on the vertical axis (top and bottom).
	/// </summary>
    public BorderBuilder OnY => AddRule(ElementSideType.Vertical);
	/// <summary>
	/// Applies border on all sides.
	/// </summary>
    public BorderBuilder OnAll => AddRule(ElementSideType.All);
	/// <summary>
	/// Applies border from the inline start.
	/// </summary>
    public BorderBuilder FromStart => AddRule(ElementSideType.InlineStart);
	/// <summary>
	/// Applies border from the inline end.
	/// </summary>
    public BorderBuilder FromEnd => AddRule(ElementSideType.InlineEnd);

	/// <summary>
	/// Sets the border width from an arbitrary Tailwind border token.
	/// </summary>
    public BorderBuilder Is0 => ChainWithSize(ScaleType.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is1 => ChainWithSize(ScaleType.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is2 => ChainWithSize(ScaleType.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is3 => ChainWithSize(ScaleType.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is4 => ChainWithSize(ScaleType.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is5 => ChainWithSize(ScaleType.Is5);

    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    public BorderBuilder Token(string value) => ChainWithSize(value);

	/// <summary>
	/// Applies the border on phone breakpoint.
	/// </summary>
    public BorderBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
	/// <summary>
	/// Applies the border on small breakpoint (≥640px).
	/// </summary>
    public BorderBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
	/// <summary>
	/// Applies the border on tablet breakpoint.
	/// </summary>
    public BorderBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
	/// <summary>
	/// Applies the border on laptop breakpoint.
	/// </summary>
    public BorderBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
	/// <summary>
	/// Applies the border on desktop breakpoint.
	/// </summary>
    public BorderBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
	/// <summary>
	/// Applies the border on the 2xl breakpoint.
	/// </summary>
    public BorderBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder AddRule(ElementSideType side)
    {
        BreakpointType? pending = ConsumePendingBreakpoint();
        string size = _rules.Count > 0 ? _rules[^1].Size : "0";
        BreakpointType? bp = pending ?? (_rules.Count > 0 ? _rules[^1].Breakpoint : null);

        if (_rules.Count > 0 && _rules[^1].Side == ElementSideType.All)
        {
            _rules[^1] = new BorderRule(size, side, bp);
        }
        else
        {
            _rules.Add(new BorderRule(size, side, bp));
        }

        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder ChainWithSize(ScaleType scale)
    {
        _rules.Add(new BorderRule(scale.Value, ElementSideType.All, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder ChainWithSize(string value)
    {
        _rules.Add(new BorderRule(value, ElementSideType.All, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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

    /// <summary>Gets the CSS class string for the current configuration.</summary>
    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            BorderRule rule = _rules[i];

            string sizeTok = rule.Size;

            if (sizeTok.Length == 0)
                continue;

            string sideTok = rule.Side.Value;
            string bpTok = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            if (bpTok.Length != 0)
            {
                sb.Append(bpTok);
                sb.Append(':');
            }

            sb.Append(_baseToken);

            if (sideTok.Length != 0)
            {
                sb.Append('-');
                sb.Append(sideTok);
            }

            sb.Append('-');
            sb.Append(sizeTok);
        }

        return sb.ToString();
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public string ToStyle() => string.Empty;

}
