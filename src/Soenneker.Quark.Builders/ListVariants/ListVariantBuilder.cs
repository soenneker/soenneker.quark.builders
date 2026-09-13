
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
    private RuleList<ListVariantRule> _rules;

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
    /// Removes list markers and resets padding (list-none p-0).
    /// </summary>
    public ListVariantBuilder None => Chain(ListVariantType.None);
    /// <summary>
    /// Applies a wrapping flex row, centered items, gap-2, no list markers, and zero padding.
    /// </summary>
    public ListVariantBuilder Inline => Chain(ListVariantType.Inline);
    /// <summary>
    /// Sets the list item display to inline-block.
    /// </summary>
    public ListVariantBuilder InlineItem => Chain(ListVariantType.InlineItem);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ListVariantBuilder Chain(ListVariantType type)
    {
        _rules.Add(new ListVariantRule(type, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ListVariantRule rule = _rules[0];
            return ClassWriter.Render(rule.Type.Value switch { "none" => "list-none p-0", "inline" => "flex flex-wrap items-center gap-2 list-none p-0", "inline-item" => "inline-block", _ => string.Empty }, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ListVariantRule rule = _rules[i];
                writer.Add(rule.Type.Value switch { "none" => "list-none p-0", "inline" => "flex flex-wrap items-center gap-2 list-none p-0", "inline-item" => "inline-block", _ => string.Empty }, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// Returns the CSS class string representation of this list variant builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
