
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
    private readonly List<FontStyleRule> _rules = new(4);

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



    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            FontStyleRule rule = _rules[i];
            string cls;
            if (ReferenceEquals(rule.Value, FontStyleEnum.Italic))
                cls = FontStyleEnum.ItalicValue;
            else if (ReferenceEquals(rule.Value, FontStyleEnum.Normal))
                cls = FontStyleEnum.NormalValue;
            else
                cls = string.Empty;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;
    public override string ToString() => ToClass();
}
