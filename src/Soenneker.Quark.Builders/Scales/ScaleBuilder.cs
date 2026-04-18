using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scale builder with fluent API for chaining scale rules.
/// </summary>
public sealed class ScaleBuilder : ICssBuilder
{
    private readonly List<ScaleRule> _rules = new(4);

    internal ScaleBuilder(ScaleType scale)
    {
        _rules.Add(new ScaleRule(scale));
    }

    internal ScaleBuilder(List<ScaleRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the scale to 0.
    /// </summary>
    public ScaleBuilder Is0 => ChainWithScale(ScaleType.Is0);
    /// <summary>
    /// Sets the scale to 1.
    /// </summary>
    public ScaleBuilder Is1 => ChainWithScale(ScaleType.Is1);
    /// <summary>
    /// Sets the scale to 2.
    /// </summary>
    public ScaleBuilder Is2 => ChainWithScale(ScaleType.Is2);
    /// <summary>
    /// Sets the scale to 3.
    /// </summary>
    public ScaleBuilder Is3 => ChainWithScale(ScaleType.Is3);
    /// <summary>
    /// Sets the scale to 4.
    /// </summary>
    public ScaleBuilder Is4 => ChainWithScale(ScaleType.Is4);
    /// <summary>
    /// Sets the scale to 5.
    /// </summary>
    public ScaleBuilder Is5 => ChainWithScale(ScaleType.Is5);
    /// <summary>
    /// Sets the scale to 6.
    /// </summary>
    public ScaleBuilder Is6 => ChainWithScale(ScaleType.Is6);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScaleBuilder ChainWithScale(ScaleType scale)
    {
        _rules.Add(new ScaleRule(scale));
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            ScaleRule rule = _rules[i];
            string cls = string.IsNullOrEmpty(rule.Scale.Value) ? string.Empty : $"scale-{rule.Scale.Value}";
            if (cls.Length == 0)
                continue;

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this scale builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
