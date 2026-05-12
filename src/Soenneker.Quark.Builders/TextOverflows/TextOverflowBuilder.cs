
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance text-overflow builder with fluent API for chaining rules.
/// </summary>
[TailwindPrefix("text-", Responsive = true)]
public sealed class TextOverflowBuilder : CssBuilderBase<TextOverflowBuilder>
{
    private readonly List<TextOverflowRule> _rules = new(4);

    internal TextOverflowBuilder()
    {
    }

    internal TextOverflowBuilder(TextOverflowEnum textOverflow, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextOverflowRule(textOverflow.Value, breakpoint));
    }

    internal TextOverflowBuilder(List<TextOverflowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    // ----- Fluent chaining (TextOverflow enum) -----
    /// <summary>
    /// Sets the text overflow to clip.
    /// </summary>
    public TextOverflowBuilder Clip => Chain(TextOverflowEnum.Clip);
    /// <summary>
    /// Sets the text overflow to ellipsis.
    /// </summary>
    public TextOverflowBuilder Ellipsis => Chain(TextOverflowEnum.Ellipsis);

    // ----- BreakpointType chaining -----

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextOverflowBuilder Chain(TextOverflowEnum value)
    {
        BreakpointType? breakpoint = null;
        _rules.Add(new TextOverflowRule(value.Value, breakpoint, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>Gets the CSS class string for the current configuration.</summary>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            TextOverflowRule rule = _rules[i];

            // Only Clip/Ellipsis map to utility classes; keywords don't.
            string baseClass = rule.Value;
            if (baseClass.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                baseClass = BreakpointUtil.ApplyTailwindBreakpoint(baseClass, bp);

            if (rule.ModifierChain is { Length: > 0 })
                baseClass = BreakpointUtil.ApplyTailwindModifiers(baseClass, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(baseClass);
        }

        return sb.ToString();
    }

    /// <summary>Gets the CSS style string for the current configuration.</summary>
    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
