
using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind font family utility builder.
/// </summary>
[TailwindPrefix("font-", Responsive = true)]
public sealed class FontFamilyBuilder : CssBuilderBase<FontFamilyBuilder>
{
    private RuleList<FontFamilyRule> _rules;

    internal FontFamilyBuilder()
    {
    }

    internal FontFamilyBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontFamilyRule(value, breakpoint));
    }

    internal FontFamilyBuilder(FontFamilyEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontFamilyRule(value.Value, breakpoint));
    }

    internal FontFamilyBuilder(List<FontFamilyRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the font family to sans.
    /// </summary>
    public FontFamilyBuilder Sans => Chain(FontFamilyEnum.SansValue);

    /// <summary>
    /// Sets the font family to serif.
    /// </summary>
    public FontFamilyBuilder Serif => Chain(FontFamilyEnum.SerifValue);

    /// <summary>
    /// Sets the font family to mono.
    /// </summary>
    public FontFamilyBuilder Mono => Chain(FontFamilyEnum.MonoValue);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontFamilyBuilder Chain(string value)
    {
        _rules.Add(new FontFamilyRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontFamilyBuilder Chain(FontFamilyEnum value)
    {
        _rules.Add(new FontFamilyRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            FontFamilyRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                FontFamilyRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
}

