
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified margin builder with fluent API for chaining margin rules.
/// </summary>
[TailwindPrefix("m-", Responsive = true)]
public sealed class MarginBuilder : ICssBuilder
{
    private readonly List<MarginRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    // ----- Class tokens -----
    private const string _baseToken = "m";

    // ----- Size tokens -----
    private const string _token0 = "0";
    private const string _token1 = "1";
    private const string _token2 = "2";
    private const string _token3 = "3";
    private const string _token4 = "4";
    private const string _token5 = "5";
    private const string _token8 = "8";
    private const string _tokenAuto = "auto";

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
    public MarginBuilder Auto => ChainWithSize("auto");

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
    public MarginBuilder Is8 => ChainWithSize("8");

	/// <summary>
	/// Sets the margin size from an arbitrary Tailwind spacing token.
	/// </summary>
    public MarginBuilder Token(string value) => ChainWithSize(value);

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
    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            MarginRule rule = _rules[i];

            string sizeTok = GetSizeToken(rule.Size);

            if (sizeTok.Length == 0)
                continue;

            string sideTok = rule.Side.Value;
            string bpTok = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            // Tailwind: mt-1, md:mt-1 (not legacy mt-md-1 syntax)
            string baseClass = _baseToken + (sideTok.Length != 0 ? sideTok : "") + "-" + sizeTok;
            string cls = bpTok.Length != 0 ? BreakpointUtil.ApplyTailwindBreakpoint(baseClass, bpTok) : baseClass;
            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public string ToStyle() => string.Empty;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetSizeToken(string size)
        {
            return size switch
            {
                MarginScaleEnum.Is0Value => _token0,
                MarginScaleEnum.Is1Value => _token1,
                MarginScaleEnum.Is2Value => _token2,
                MarginScaleEnum.Is3Value => _token3,
                MarginScaleEnum.Is4Value => _token4,
                MarginScaleEnum.Is5Value => _token5,
                "8" => _token8,
                "auto" => _tokenAuto,
                _ => string.Empty
            };
        }

    }
