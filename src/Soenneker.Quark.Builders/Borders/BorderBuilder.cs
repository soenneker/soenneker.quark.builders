
using Soenneker.Extensions.String;

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// Simplified border builder with fluent API for chaining border rules.
/// </summary>
[TailwindPrefix("border-", Responsive = true)]
public sealed class BorderBuilder : CssBuilderBase<BorderBuilder>
{
    private readonly List<BorderRule> _rules = new(4);
    private ElementSideEnum? _pendingSide;

    internal BorderBuilder()
    {
    }

    internal BorderBuilder(string size, BreakpointType? breakpoint = null, bool allowEmpty = false)
    {
        if (allowEmpty || size.HasContent())
            _rules.Add(new BorderRule(size, ElementSideEnum.All, breakpoint, CanRetargetSide: true));
    }

    internal BorderBuilder(ElementSideEnum side)
    {
        _pendingSide = side;
    }

    internal BorderBuilder(List<BorderRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

	/// <summary>
	/// Applies border from the top side.
	/// </summary>
    public BorderBuilder FromTop => AddRule(ElementSideEnum.Top);
	/// <summary>
	/// Applies border from the right side.
	/// </summary>
    public BorderBuilder FromRight => AddRule(ElementSideEnum.Right);
	/// <summary>
	/// Applies border from the bottom side.
	/// </summary>
    public BorderBuilder FromBottom => AddRule(ElementSideEnum.Bottom);
	/// <summary>
	/// Applies border from the left side.
	/// </summary>
    public BorderBuilder FromLeft => AddRule(ElementSideEnum.Left);
	/// <summary>
	/// Applies border on the horizontal axis (left and right).
	/// </summary>
    public BorderBuilder OnX => AddRule(ElementSideEnum.Horizontal);
	/// <summary>
	/// Applies border on the vertical axis (top and bottom).
	/// </summary>
    public BorderBuilder OnY => AddRule(ElementSideEnum.Vertical);
	/// <summary>
	/// Applies border on all sides.
	/// </summary>
    public BorderBuilder OnAll => AddRule(ElementSideEnum.All);
	/// <summary>
	/// Applies border from the inline start.
	/// </summary>
    public BorderBuilder FromStart => AddRule(ElementSideEnum.InlineStart);
	/// <summary>
	/// Applies border from the inline end.
	/// </summary>
    public BorderBuilder FromEnd => AddRule(ElementSideEnum.InlineEnd);

	/// <summary>
	/// Uses Tailwind’s default unsuffixed border width utility.
	/// </summary>
    public BorderBuilder Default => ChainWithSize(BorderScaleEnum.Is1Value, allowEmpty: true);
    /// <summary>
    /// Sets the border width from an arbitrary Tailwind border token.
    /// </summary>
    public BorderBuilder Is0 => ChainWithSize(BorderScaleEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is1 => ChainWithSize(BorderScaleEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is2 => ChainWithSize(BorderScaleEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is3 => ChainWithSize(BorderScaleEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is4 => ChainWithSize(BorderScaleEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public BorderBuilder Is5 => ChainWithSize(BorderScaleEnum.Is5);

    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    public BorderBuilder Token(string value) => ChainWithSize(NormalizeBorderClass(value));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder AddRule(ElementSideEnum side)
    {
        if (_pendingSide is null && _rules.Count > 0)
        {
            var lastIndex = _rules.Count - 1;
            BorderRule lastRule = _rules[lastIndex];

            if (lastRule.CanRetargetSide && ReferenceEquals(lastRule.Side, ElementSideEnum.All))
            {
                _rules[lastIndex] = lastRule with { Side = side, CanRetargetSide = false };
                return this;
            }
        }

        _pendingSide = side;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder ChainWithSize(BorderScaleEnum scale)
    {
        var hadPendingSide = _pendingSide is not null;
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
            _rules.Add(new BorderRule(scale.Value, side, null, ConsumePendingModifierChain(), ReferenceEquals(side, ElementSideEnum.All) && !hadPendingSide));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder ChainWithSize(string value)
    {
        return ChainWithSize(value, allowEmpty: false);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder ChainWithSize(string value, bool allowEmpty)
    {
        var hadPendingSide = _pendingSide is not null;
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;

        if (allowEmpty || value.Length != 0)
            _rules.Add(new BorderRule(value, side, null, ConsumePendingModifierChain(), ReferenceEquals(side, ElementSideEnum.All) && !hadPendingSide));
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
            BorderRule rule = _rules[i];
            string cls = BuildClass(rule);
            if (cls.Length == 0)
                continue;

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    private static string BuildClass(BorderRule rule)
    {
        string cls = ApplySide(rule.Size, rule.Side);
        if (cls.Length == 0)
            return string.Empty;

        string bpTok = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
        if (bpTok.Length != 0)
            cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bpTok);

        if (rule.ModifierChain is { Length: > 0 })
            cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

        return cls;
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizeBorderClass(string value)
    {
        if (value.Length == 0)
            return string.Empty;

        if (value == "border" || value.StartsWith("border-"))
            return value;

        return "border-" + value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ApplySide(string sizeClass, ElementSideEnum side)
    {
        if (sizeClass.Length == 0)
            return string.Empty;

        if (ReferenceEquals(side, ElementSideEnum.All))
            return sizeClass;

        if (sizeClass == "border")
            return "border-" + side.Value;

        if (!sizeClass.StartsWith("border-"))
            return sizeClass;

        return "border-" + side.Value + sizeClass["border".Length..];
    }
}
