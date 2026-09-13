using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scale builder with fluent API for chaining scale rules.
/// </summary>
public sealed class ScaleBuilder : CssBuilderBase<ScaleBuilder>
{
    private RuleList<ScaleRule> _rules;

    internal ScaleBuilder()
    {
    }

    internal ScaleBuilder(ScaleEnum scale)
    {
        _rules.Add(new ScaleRule(scale));
    }

    internal ScaleBuilder(List<ScaleRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets scale50.
    /// </summary>
    public ScaleBuilder Scale50 => ChainWithScale(ScaleEnum.Scale50);
    /// <summary>
    /// Gets or sets scale75.
    /// </summary>
    public ScaleBuilder Scale75 => ChainWithScale(ScaleEnum.Scale75);
    /// <summary>
    /// Gets or sets scale90.
    /// </summary>
    public ScaleBuilder Scale90 => ChainWithScale(ScaleEnum.Scale90);
    /// <summary>
    /// Gets or sets scale95.
    /// </summary>
    public ScaleBuilder Scale95 => ChainWithScale(ScaleEnum.Scale95);
    /// <summary>
    /// Gets or sets scale100.
    /// </summary>
    public ScaleBuilder Scale100 => ChainWithScale(ScaleEnum.Scale100);
    /// <summary>
    /// Gets or sets scale105.
    /// </summary>
    public ScaleBuilder Scale105 => ChainWithScale(ScaleEnum.Scale105);
    /// <summary>
    /// Gets or sets scale110.
    /// </summary>
    public ScaleBuilder Scale110 => ChainWithScale(ScaleEnum.Scale110);
    /// <summary>
    /// Gets or sets scale125.
    /// </summary>
    public ScaleBuilder Scale125 => ChainWithScale(ScaleEnum.Scale125);
    /// <summary>
    /// Gets or sets scale150.
    /// </summary>
    public ScaleBuilder Scale150 => ChainWithScale(ScaleEnum.Scale150);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScaleBuilder ChainWithScale(ScaleEnum scale)
    {
        _rules.Add(new ScaleRule(scale, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ScaleRule rule = _rules[0];
            return ClassWriter.Render(rule.Scale.Value, modifiers: rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ScaleRule rule = _rules[i];
                writer.Add(rule.Scale.Value, modifiers: rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
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
