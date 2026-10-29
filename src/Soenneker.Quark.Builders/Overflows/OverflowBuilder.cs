using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance overflow builder with fluent API for chaining overflow rules.
/// </summary>
[TailwindPrefix("overflow-", Responsive = true)]
public sealed class OverflowBuilder : CssBuilderBase<OverflowBuilder>
{
    private RuleList<OverflowRule> _rules;
    private string _axis = "";

    internal OverflowBuilder() { }

    internal OverflowBuilder(string overflow)
    {
        _rules.Add(new OverflowRule(overflow));
    }

    internal OverflowBuilder(List<OverflowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Creates a new OverflowBuilder with no initial value.
    /// </summary>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static OverflowBuilder Create()
    {
        return new OverflowBuilder([]);
    }

	/// <summary>
	/// Sets the overflow to auto.
	/// </summary>
    public OverflowBuilder Auto => Chain(OverflowKeyword.AutoValue);
	/// <summary>
	/// Sets the overflow to hidden.
	/// </summary>
    public OverflowBuilder Hidden => Chain(OverflowKeyword.HiddenValue);
	/// <summary>
	/// Sets the overflow to visible.
	/// </summary>
    public OverflowBuilder Visible => Chain(OverflowKeyword.VisibleValue);
    /// <summary>Clips overflowing content without creating a scroll container.</summary>
    public OverflowBuilder Clip => Chain("clip");

    /// <summary>Sets the overflow to scroll.</summary>
    public OverflowBuilder Scroll => Chain(OverflowKeyword.ScrollValue);

	/// <summary>
	/// Applies overflow on the X axis.
	/// </summary>
    public OverflowBuilder X => ChainAxis("-x");
	/// <summary>
	/// Applies overflow on the Y axis.
	/// </summary>
    public OverflowBuilder Y => ChainAxis("-y");
	/// <summary>
	/// Applies overflow on all axes.
	/// </summary>
    public OverflowBuilder All => ChainAxis("");

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OverflowBuilder Chain(string overflow)
    {
        _rules.Add(new OverflowRule(overflow, _axis, ConsumePendingModifierChain()));
        _axis = "";
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OverflowBuilder ChainAxis(string axis)
    {
        _axis = axis;
        return this;
    }

    public override string ToClass() => _rules.CachedClass ??= BuildClass();

    private string BuildClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            OverflowRule rule = _rules[0];
            return ClassWriter.Render(GetOverflowClass(rule), modifiers: rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                OverflowRule rule = _rules[i];
                writer.Add(GetOverflowClass(rule), modifiers: rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string GetOverflowClass(OverflowRule rule)
    {
        if (string.IsNullOrEmpty(rule.Overflow))
            return string.Empty;

        return string.IsNullOrEmpty(rule.Axis)
            ? $"overflow-{rule.Overflow}"
            : $"overflow{rule.Axis}-{rule.Overflow}";
    }

    /// <summary>Gets the string representation of the builder (same as ToClass).</summary>
    public override string ToString()
    {
        return ToClass();
    }
}
