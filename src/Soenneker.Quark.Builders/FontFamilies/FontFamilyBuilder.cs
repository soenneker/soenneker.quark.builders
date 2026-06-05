
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
    private readonly List<FontFamilyRule> _rules = new(4);

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
    public FontFamilyBuilder Sans => Chain(FontFamilyEnum.Sans);

    /// <summary>
    /// Sets the font family to serif.
    /// </summary>
    public FontFamilyBuilder Serif => Chain(FontFamilyEnum.Serif);

    /// <summary>
    /// Sets the font family to mono.
    /// </summary>
    public FontFamilyBuilder Mono => Chain(FontFamilyEnum.Mono);
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
    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            FontFamilyRule rule = _rules[i];
            string cls = rule.Value;

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}

