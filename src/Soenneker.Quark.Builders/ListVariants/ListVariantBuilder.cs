
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for Tailwind-aligned list layout variants.
/// </summary>
[TailwindPrefix("list-", Responsive = true)]
public sealed class ListVariantBuilder : CssBuilderBase<ListVariantBuilder>
{
    private readonly List<ListVariantRule> _rules = new(4);

    internal ListVariantBuilder()
    {
    }

    internal ListVariantBuilder(ListVariantType type, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ListVariantRule(type, breakpoint));
    }

    internal ListVariantBuilder(List<ListVariantRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Removes default list styling.
    /// </summary>
    public ListVariantBuilder None => Chain(ListVariantType.None);
    /// <summary>
    /// Sets the list variant to inline.
    /// </summary>
    public ListVariantBuilder Inline => Chain(ListVariantType.Inline);
    /// <summary>
    /// Sets the list variant to inline-item.
    /// </summary>
    public ListVariantBuilder InlineItem => Chain(ListVariantType.InlineItem);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ListVariantBuilder Chain(ListVariantType type)
    {
        _rules.Add(new ListVariantRule(type, null, ConsumePendingModifierChain()));
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
            ListVariantRule rule = _rules[i];
            string typeValue = rule.Type.Value;
            string cls = typeValue switch
            {
                "none" => "list-none p-0",
                "inline" => "flex flex-wrap items-center gap-2 list-none p-0",
                "inline-item" => "inline-block",
                _ => string.Empty
            };

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
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this list variant builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
