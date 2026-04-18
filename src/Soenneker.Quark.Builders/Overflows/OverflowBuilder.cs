using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance overflow builder with fluent API for chaining overflow rules.
/// </summary>
public sealed class OverflowBuilder : ICssBuilder
{
    private readonly List<OverflowRule> _rules = new(4);
    private string _axis = "";

    internal OverflowBuilder(string overflow)
    {
        _rules.Add(new OverflowRule(overflow, null));
    }

    internal OverflowBuilder(List<OverflowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Creates a new OverflowBuilder with no initial value.
    /// </summary>
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
	/// <summary>
	/// Sets the overflow to scroll.
	/// </summary>
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
        // Replace the last rule instead of adding a new one
        if (_rules.Count > 0)
        {
            _rules[_rules.Count - 1] = new OverflowRule(overflow, null);
        }
        else
        {
            _rules.Add(new OverflowRule(overflow, null));
        }
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OverflowBuilder ChainAxis(string axis)
    {
        _axis = axis;
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
            OverflowRule rule = _rules[i];

            string baseClass = GetOverflowClass(rule.Overflow);
            if (baseClass.Length == 0)
                continue;

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(baseClass);
        }

        return sb.ToString();
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string GetOverflowClass(string overflow)
    {
        if (string.IsNullOrEmpty(overflow))
            return string.Empty;

        return string.IsNullOrEmpty(_axis)
            ? $"overflow-{overflow}"
            : $"overflow{_axis}-{overflow}";
    }

    /// <summary>Gets the string representation of the builder (same as ToClass).</summary>
    public override string ToString()
    {
        return ToClass();
    }
}
