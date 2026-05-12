namespace Soenneker.Quark;

/// <summary>
/// Simplified display utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(DisplayBuilder))]
public static partial class Display
{
    /// <summary>
    /// Display none (hidden).
    /// </summary>
    public static DisplayBuilder None => new(DisplayEnum.None);

    /// <summary>
    /// Display inline.
    /// </summary>
    public static DisplayBuilder Inline => new(DisplayEnum.Inline);

    /// <summary>
    /// Display inline-block.
    /// </summary>
    public static DisplayBuilder InlineBlock => new(DisplayEnum.InlineBlock);

    /// <summary>
    /// Display block.
    /// </summary>
    public static DisplayBuilder Block => new(DisplayEnum.Block);

    /// <summary>
    /// Display flow-root.
    /// </summary>
    public static DisplayBuilder FlowRoot => new("flow-root");

    /// <summary>
    /// Display flex.
    /// </summary>
    public static DisplayBuilder Flex => new(DisplayEnum.Flex);

    /// <summary>
    /// Display inline-flex.
    /// </summary>
    public static DisplayBuilder InlineFlex => new(DisplayEnum.InlineFlex);

    /// <summary>
    /// Display grid.
    /// </summary>
    public static DisplayBuilder Grid => new(DisplayEnum.Grid);

    /// <summary>
    /// Display inline-grid.
    /// </summary>
    public static DisplayBuilder InlineGrid => new(DisplayEnum.InlineGrid);

    /// <summary>
    /// Display table.
    /// </summary>
    public static DisplayBuilder Table => new(DisplayEnum.Table);

    /// <summary>
    /// Display table-caption.
    /// </summary>
    public static DisplayBuilder TableCaption => new("table-caption");

    /// <summary>
    /// Display table-column.
    /// </summary>
    public static DisplayBuilder TableColumn => new("table-column");

    /// <summary>
    /// Display table-column-group.
    /// </summary>
    public static DisplayBuilder TableColumnGroup => new("table-column-group");

    /// <summary>
    /// Display table-footer-group.
    /// </summary>
    public static DisplayBuilder TableFooterGroup => new("table-footer-group");

    /// <summary>
    /// Display table-header-group.
    /// </summary>
    public static DisplayBuilder TableHeaderGroup => new("table-header-group");

    /// <summary>
    /// Display table-row-group.
    /// </summary>
    public static DisplayBuilder TableRowGroup => new("table-row-group");

    /// <summary>
    /// Display table-cell.
    /// </summary>
    public static DisplayBuilder TableCell => new(DisplayEnum.TableCell);

    /// <summary>
    /// Display table-row.
    /// </summary>
    public static DisplayBuilder TableRow => new(DisplayEnum.TableRow);

    /// <summary>
    /// Display contents.
    /// </summary>
    public static DisplayBuilder Contents => new("contents");

    /// <summary>
    /// Display list-item.
    /// </summary>
    public static DisplayBuilder ListItem => new("list-item");

    /// <summary>
    /// Creates an exact Tailwind display utility.
    /// </summary>
    public static DisplayBuilder Token(string value) => new(value);
}
