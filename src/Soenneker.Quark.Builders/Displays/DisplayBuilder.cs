
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified display builder with fluent API for chaining display rules.
/// </summary>
[TailwindPrefix("block", Responsive = true)]
public sealed class DisplayBuilder : CssBuilderBase<DisplayBuilder>
{
    private RuleList<DisplayRule> _rules;

    internal DisplayBuilder()
    {
    }

    internal DisplayBuilder(DisplayEnum display, BreakpointType? breakpoint = null)
    {
        _rules.Add(new DisplayRule(display.Value, breakpoint));
    }

    internal DisplayBuilder(string display, BreakpointType? breakpoint = null)
    {
        _rules.Add(new DisplayRule(display, breakpoint));
    }

    internal DisplayBuilder(List<DisplayRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the display to none.
    /// </summary>
    public DisplayBuilder None => ChainWithDisplay(DisplayEnum.None);
    /// <summary>
    /// Sets the display to inline.
    /// </summary>
    public DisplayBuilder Inline => ChainWithDisplay(DisplayEnum.Inline);
    /// <summary>
    /// Sets the display to inline-block.
    /// </summary>
    public DisplayBuilder InlineBlock => ChainWithDisplay(DisplayEnum.InlineBlock);
    /// <summary>
    /// Sets the display to block.
    /// </summary>
    public DisplayBuilder Block => ChainWithDisplay(DisplayEnum.Block);
    /// <summary>
    /// Sets the display to flow-root.
    /// </summary>
    public DisplayBuilder FlowRoot => ChainWithDisplay("flow-root");
    /// <summary>
    /// Sets the display to flex.
    /// </summary>
    public DisplayBuilder Flex => ChainWithDisplay(DisplayEnum.Flex);
    /// <summary>
    /// Sets the display to inline-flex.
    /// </summary>
    public DisplayBuilder InlineFlex => ChainWithDisplay(DisplayEnum.InlineFlex);
    /// <summary>
    /// Sets the display to grid.
    /// </summary>
    public DisplayBuilder Grid => ChainWithDisplay(DisplayEnum.Grid);
    /// <summary>
    /// Sets the display to inline-grid.
    /// </summary>
    public DisplayBuilder InlineGrid => ChainWithDisplay(DisplayEnum.InlineGrid);
    /// <summary>
    /// Sets the display to table.
    /// </summary>
    public DisplayBuilder Table => ChainWithDisplay(DisplayEnum.Table);
    /// <summary>
    /// Sets the display to table-caption.
    /// </summary>
    public DisplayBuilder TableCaption => ChainWithDisplay("table-caption");
    /// <summary>
    /// Sets the display to table-column.
    /// </summary>
    public DisplayBuilder TableColumn => ChainWithDisplay("table-column");
    /// <summary>
    /// Sets the display to table-column-group.
    /// </summary>
    public DisplayBuilder TableColumnGroup => ChainWithDisplay("table-column-group");
    /// <summary>
    /// Sets the display to table-footer-group.
    /// </summary>
    public DisplayBuilder TableFooterGroup => ChainWithDisplay("table-footer-group");
    /// <summary>
    /// Sets the display to table-header-group.
    /// </summary>
    public DisplayBuilder TableHeaderGroup => ChainWithDisplay("table-header-group");
    /// <summary>
    /// Sets the display to table-row-group.
    /// </summary>
    public DisplayBuilder TableRowGroup => ChainWithDisplay("table-row-group");
    /// <summary>
    /// Sets the display to table-cell.
    /// </summary>
    public DisplayBuilder TableCell => ChainWithDisplay(DisplayEnum.TableCell);
    /// <summary>
    /// Sets the display to table-row.
    /// </summary>
    public DisplayBuilder TableRow => ChainWithDisplay(DisplayEnum.TableRow);
    /// <summary>
    /// Sets the display to contents.
    /// </summary>
    public DisplayBuilder Contents => ChainWithDisplay("contents");
    /// <summary>
    /// Sets the display to list-item.
    /// </summary>
    public DisplayBuilder ListItem => ChainWithDisplay("list-item");
    /// <summary>
    /// Applies an exact Tailwind display utility.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DisplayBuilder Token(string value) => ChainWithDisplay(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private DisplayBuilder ChainWithDisplay(DisplayEnum display)
    {
        return ChainWithDisplay(display.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private DisplayBuilder ChainWithDisplay(string display)
    {
        _rules.Add(new DisplayRule(display, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            DisplayRule rule = _rules[0];
            return ClassWriter.Render(rule.Display, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                DisplayRule rule = _rules[i];
                writer.Add(rule.Display, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
