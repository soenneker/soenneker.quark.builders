using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance padding builder with fluent API for chaining padding rules.
/// </summary>
[TailwindPrefix("p-", Responsive = true)]
public sealed class PaddingBuilder : CssBuilderBase
{
    private readonly List<PaddingRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    // ----- Class tokens -----
    private const string _baseToken = "p";

    // ----- Size tokens -----
    private const string _token0 = "0";
    private const string _token6 = "6";
    private const string _token8 = "8";
    private const string _token16 = "16";
    private const string _tokenAuto = "auto";

    internal PaddingBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new PaddingRule(size, ElementSideEnum.All, breakpoint));
    }

    internal PaddingBuilder(List<PaddingRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

	/// <summary>
	/// Applies padding from the top side.
	/// </summary>
    public PaddingBuilder FromTop => AddRule(ElementSideEnum.Top);
	/// <summary>
	/// Applies padding from the right side.
	/// </summary>
    public PaddingBuilder FromRight => AddRule(ElementSideEnum.Right);
	/// <summary>
	/// Applies padding from the bottom side.
	/// </summary>
    public PaddingBuilder FromBottom => AddRule(ElementSideEnum.Bottom);
	/// <summary>
	/// Applies padding from the left side.
	/// </summary>
    public PaddingBuilder FromLeft => AddRule(ElementSideEnum.Left);
	/// <summary>
	/// Applies padding on the horizontal axis (left and right).
	/// </summary>
    public PaddingBuilder OnX => AddRule(ElementSideEnum.Horizontal);
	/// <summary>
	/// Applies padding on the vertical axis (top and bottom).
	/// </summary>
    public PaddingBuilder OnY => AddRule(ElementSideEnum.Vertical);
	/// <summary>
	/// Applies padding on all sides.
	/// </summary>
    public PaddingBuilder OnAll => AddRule(ElementSideEnum.All);
	/// <summary>
	/// Applies padding from the inline start.
	/// </summary>
    public PaddingBuilder FromStart => AddRule(ElementSideEnum.InlineStart);
	/// <summary>
	/// Applies padding from the inline end.
	/// </summary>
    public PaddingBuilder FromEnd => AddRule(ElementSideEnum.InlineEnd);

	/// <summary>
	/// Sets the padding size from an arbitrary Tailwind spacing token.
	/// </summary>
    public PaddingBuilder Is0 => ChainWithSize(PaddingScaleEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is1 => ChainWithSize(PaddingScaleEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is2 => ChainWithSize(PaddingScaleEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is3 => ChainWithSize(PaddingScaleEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is4 => ChainWithSize(PaddingScaleEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is5 => ChainWithSize(PaddingScaleEnum.Is5);
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is6 => ChainWithSize("6");
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is8 => ChainWithSize("8");
    /// <summary>
    /// Spacing/sizing scale step `16` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 16` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is16 => ChainWithSize("16");

    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    public PaddingBuilder Token(string value) => ChainWithSize(value);

	/// <summary>
	/// Applies the padding on phone breakpoint.
	/// </summary>
    public PaddingBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
	/// <summary>
	/// Applies the padding on small breakpoint (≥640px).
	/// </summary>
    public PaddingBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
	/// <summary>
	/// Applies the padding on tablet breakpoint.
	/// </summary>
    public PaddingBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
	/// <summary>
	/// Applies the padding on laptop breakpoint.
	/// </summary>
    public PaddingBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
	/// <summary>
	/// Applies the padding on desktop breakpoint.
	/// </summary>
    public PaddingBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
	/// <summary>
	/// Applies the padding on the 2xl breakpoint.
	/// </summary>
    public PaddingBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaddingBuilder AddRule(ElementSideEnum side)
    {
        string size = _rules.Count > 0 ? _rules[^1].Size : PaddingScaleEnum.Is0Value;
        BreakpointType? existingBp = _rules.Count > 0 ? _rules[^1].Breakpoint : null;
        BreakpointType? bp = _pendingBreakpoint ?? existingBp;
        _pendingBreakpoint = null;

        if (_rules.Count > 0 && ReferenceEquals(_rules[^1].Side, ElementSideEnum.All))
        {
            // Replace last "All" with specific side using same size/bp
            _rules[^1] = new PaddingRule(size, side, bp);
        }
        else
        {
            _rules.Add(new PaddingRule(size, side, bp));
        }

        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaddingBuilder ChainWithSize(string size)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new PaddingRule(size, ElementSideEnum.All, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaddingBuilder ChainWithSize(PaddingScaleEnum scale)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new PaddingRule(scale.Value, ElementSideEnum.All, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaddingBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
            PaddingRule rule = _rules[i];

            string sizeTok = GetSizeToken(rule.Size);
            if (sizeTok.Length == 0)
                continue;

            string sideTok = rule.Side.Value;
            string bpTok = BreakpointUtil.GetBreakpointToken(rule.Breakpoint); // "", "sm", "md", ...

            if (!first) sb.Append(' ');
            else first = false;

            // Tailwind-style: p-4, md:p-4 (breakpoint-prefixed)
            string baseClass = _baseToken + (sideTok.Length != 0 ? sideTok : "") + "-" + sizeTok;
            string cls = bpTok.Length != 0 ? BreakpointUtil.ApplyTailwindBreakpoint(baseClass, bpTok) : baseClass;
            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string GetSizeToken(string size)
    {
        return size switch
        {
            PaddingScaleEnum.Is0Value => _token0,
            PaddingScaleEnum.Is1Value => PaddingScaleEnum.Is1Value,
            PaddingScaleEnum.Is2Value => PaddingScaleEnum.Is2Value,
            PaddingScaleEnum.Is3Value => PaddingScaleEnum.Is3Value,
            PaddingScaleEnum.Is4Value => PaddingScaleEnum.Is4Value,
            PaddingScaleEnum.Is5Value => PaddingScaleEnum.Is5Value,
            "6" => _token6,
            "8" => _token8,
            "16" => _token16,
            "-1" => _tokenAuto, // "auto"
            _ => string.Empty
        };
    }

}
