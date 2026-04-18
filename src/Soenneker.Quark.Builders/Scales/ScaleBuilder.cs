using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scale builder with fluent API for chaining scale rules.
/// </summary>
public sealed class ScaleBuilder : CssBuilderBase
{
    private readonly List<ScaleRule> _rules = new(4);

    internal ScaleBuilder(ScaleEnum scale)
    {
        _rules.Add(new ScaleRule(scale));
    }

    internal ScaleBuilder(List<ScaleRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public ScaleBuilder Scale50 => ChainWithScale(ScaleEnum.Scale50);
    public ScaleBuilder Scale75 => ChainWithScale(ScaleEnum.Scale75);
    public ScaleBuilder Scale90 => ChainWithScale(ScaleEnum.Scale90);
    public ScaleBuilder Scale95 => ChainWithScale(ScaleEnum.Scale95);
    public ScaleBuilder Scale100 => ChainWithScale(ScaleEnum.Scale100);
    public ScaleBuilder Scale105 => ChainWithScale(ScaleEnum.Scale105);
    public ScaleBuilder Scale110 => ChainWithScale(ScaleEnum.Scale110);
    public ScaleBuilder Scale125 => ChainWithScale(ScaleEnum.Scale125);
    public ScaleBuilder Scale150 => ChainWithScale(ScaleEnum.Scale150);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScaleBuilder ChainWithScale(ScaleEnum scale)
    {
        _rules.Add(new ScaleRule(scale));
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
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

    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this scale builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
