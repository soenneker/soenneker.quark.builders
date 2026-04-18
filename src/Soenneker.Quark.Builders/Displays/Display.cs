namespace Soenneker.Quark;

/// <summary>
/// Simplified display utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
public static class Display
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
    /// Display table-cell.
    /// </summary>
    public static DisplayBuilder TableCell => new(DisplayEnum.TableCell);

    /// <summary>
    /// Display table-row.
    /// </summary>
    public static DisplayBuilder TableRow => new(DisplayEnum.TableRow);
}
