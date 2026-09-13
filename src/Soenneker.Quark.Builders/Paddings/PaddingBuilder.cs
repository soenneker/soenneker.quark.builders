using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance padding builder with fluent API for chaining padding rules.
/// </summary>
[TailwindPrefix("p-", Responsive = true)]
public sealed class PaddingBuilder : CssBuilderBase<PaddingBuilder>
{
    private RuleList<PaddingRule> _rules;
    private ElementSideEnum? _pendingSide;

    internal PaddingBuilder()
    {
    }

    internal PaddingBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new PaddingRule(size, ElementSideEnum.All, breakpoint, CanRetargetSide: true));
    }

    internal PaddingBuilder(ElementSideEnum side)
    {
        _pendingSide = side;
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
    public PaddingBuilder Is0 => ChainWithSize(PaddingScaleEnum.Is0Value);
    /// <summary>
    /// Gets or sets is0 5.
    /// </summary>
    public PaddingBuilder Is0_5 => ChainWithSize(PaddingScaleEnum.Is0_5Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is1 => ChainWithSize(PaddingScaleEnum.Is1Value);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public PaddingBuilder Is1_5 => ChainWithSize(PaddingScaleEnum.Is1_5Value);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is2 => ChainWithSize(PaddingScaleEnum.Is2Value);
    /// <summary>
    /// Gets or sets is2 5.
    /// </summary>
    public PaddingBuilder Is2_5 => ChainWithSize(PaddingScaleEnum.Is2_5Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is3 => ChainWithSize(PaddingScaleEnum.Is3Value);
    /// <summary>
    /// Gets or sets is3 5.
    /// </summary>
    public PaddingBuilder Is3_5 => ChainWithSize(PaddingScaleEnum.Is3_5Value);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is4 => ChainWithSize(PaddingScaleEnum.Is4Value);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is5 => ChainWithSize(PaddingScaleEnum.Is5Value);
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is6 => ChainWithSize(PaddingScaleEnum.Is6Value);
    /// <summary>
    /// Gets or sets is7.
    /// </summary>
    public PaddingBuilder Is7 => ChainWithSize(PaddingScaleEnum.Is7Value);
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is8 => ChainWithSize(PaddingScaleEnum.Is8Value);
    /// <summary>
    /// Gets or sets is9.
    /// </summary>
    public PaddingBuilder Is9 => ChainWithSize(PaddingScaleEnum.Is9Value);
    /// <summary>
    /// Gets or sets is10.
    /// </summary>
    public PaddingBuilder Is10 => ChainWithSize(PaddingScaleEnum.Is10Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public PaddingBuilder Is12 => ChainWithSize(PaddingScaleEnum.Is12Value);
    /// <summary>
    /// Gets or sets is14.
    /// </summary>
    public PaddingBuilder Is14 => ChainWithSize(PaddingScaleEnum.Is14Value);
    /// <summary>
    /// Spacing/sizing scale step `16` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 16` for integer spacing utilities unless overridden).
    /// </summary>
    public PaddingBuilder Is16 => ChainWithSize(PaddingScaleEnum.Is16Value);
    /// <summary>
    /// Gets or sets is20.
    /// </summary>
    public PaddingBuilder Is20 => ChainWithSize(PaddingScaleEnum.Is20Value);
    /// <summary>
    /// Gets or sets is px.
    /// </summary>
    public PaddingBuilder IsPx => ChainWithSize(PaddingScaleEnum.IsPxValue);

    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public PaddingBuilder Token(string value) => ChainWithSize(NormalizePaddingClass(value));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaddingBuilder AddRule(ElementSideEnum side)
    {
        if (_pendingSide is null && _rules.Count > 0)
        {
            var lastIndex = _rules.Count - 1;
            PaddingRule lastRule = _rules[lastIndex];

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
    private PaddingBuilder ChainWithSize(string size)
    {
        var hadPendingSide = _pendingSide is not null;
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
        _rules.Add(new PaddingRule(size, side, null, ConsumePendingModifierChain(), ReferenceEquals(side, ElementSideEnum.All) && !hadPendingSide));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaddingBuilder ChainWithSize(PaddingScaleEnum scale)
    {
        var hadPendingSide = _pendingSide is not null;
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
        _rules.Add(new PaddingRule(scale.Value, side, null, ConsumePendingModifierChain(), ReferenceEquals(side, ElementSideEnum.All) && !hadPendingSide));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            PaddingRule rule = _rules[0];
            return ClassWriter.Render(ApplySide(rule.Size, rule.Side), BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                PaddingRule rule = _rules[i];
                writer.Add(ApplySide(rule.Size, rule.Side), BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizePaddingClass(string size)
    {
        if (size.Length == 0)
            return string.Empty;

        return size.StartsWith("p-") ? size : "p-" + size;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ApplySide(string sizeClass, ElementSideEnum side)
    {
        if (sizeClass.Length == 0)
            return string.Empty;

        if (ReferenceEquals(side, ElementSideEnum.All))
            return sizeClass;

        return sizeClass.StartsWith("p-") ? string.Concat("p", side.Value, sizeClass.AsSpan(1)) : sizeClass;
    }
}
