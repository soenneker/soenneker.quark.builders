
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// High-performance font style builder with fluent API for chaining font style rules.
/// </summary>
[TailwindPrefix("italic", Responsive = true)]
public sealed class FontStyleBuilder : CssBuilderBase<FontStyleBuilder>
{
    private RuleList<FontStyleRule> _rules;

    internal FontStyleBuilder()
    {
    }

    internal FontStyleBuilder(FontStyleEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontStyleRule(value, breakpoint));
    }

    internal FontStyleBuilder(List<FontStyleRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the font style to italic.
    /// </summary>
    public FontStyleBuilder Italic => Chain(FontStyleEnum.Italic);
    /// <summary>
    /// Sets the font style to normal.
    /// </summary>
    public FontStyleBuilder Normal => Chain(FontStyleEnum.Normal);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontStyleBuilder Chain(FontStyleEnum value)
    {
        _rules.Add(new FontStyleRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            FontStyleRule rule = _rules[0];
            return ClassWriter.Render(ReferenceEquals(rule.Value, FontStyleEnum.Italic) ? FontStyleEnum.ItalicValue : ReferenceEquals(rule.Value, FontStyleEnum.Normal) ? FontStyleEnum.NormalValue : string.Empty, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                FontStyleRule rule = _rules[i];
                writer.Add(ReferenceEquals(rule.Value, FontStyleEnum.Italic) ? FontStyleEnum.ItalicValue : ReferenceEquals(rule.Value, FontStyleEnum.Normal) ? FontStyleEnum.NormalValue : string.Empty, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;
    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
