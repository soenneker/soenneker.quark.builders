using System;

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
    /// <summary>Selects the logical block start side.</summary>
    public BorderBuilder FromBlockStart => AddRule(ElementSideEnum.BlockStart);

    /// <summary>Selects the logical block end side.</summary>
    public BorderBuilder FromBlockEnd => AddRule(ElementSideEnum.BlockEnd);


    private RuleList<UtilityRule> _rules;
    private ElementSideEnum? _pendingSide;

    internal BorderBuilder()
    {
    }

    internal BorderBuilder(string size, BreakpointType? breakpoint = null, bool allowEmpty = false)
    {
        if (allowEmpty || size.HasContent())
            _rules.Add(new UtilityRule(size, breakpoint));
    }

    internal BorderBuilder(ElementSideEnum side)
    {
        _pendingSide = side;
    }

    internal BorderBuilder(List<UtilityRule> rules)
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
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public BorderBuilder Token(string value) => ChainWithSize("border-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder AddRule(ElementSideEnum side)
    {
        _pendingSide = side;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderBuilder ChainWithSize(BorderScaleEnum scale)
    {
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;
            _rules.Add(new UtilityRule(CreateSideClass(scale.Value, side), null, ConsumePendingModifierChain()));
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
        ElementSideEnum side = _pendingSide ?? ElementSideEnum.All;
        _pendingSide = null;

        if (allowEmpty || value.Length != 0)
            _rules.Add(new UtilityRule(CreateSideClass(value, side), null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            UtilityRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                UtilityRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }


    private static string CreateSideClass(string value, ElementSideEnum side)
    {
        if (ReferenceEquals(side, ElementSideEnum.All)) return value;
        return value.Length == 6 ? "border-" + side.Value : string.Concat("border-", side.Value, value.AsSpan(6));
    }
}
