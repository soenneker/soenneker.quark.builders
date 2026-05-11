namespace Soenneker.Quark;

/// <summary>
/// Simplified display utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
public static class Display
{
    public static DisplayBuilder OnHover => new DisplayBuilder().OnHover;
    public static DisplayBuilder OnFocus => new DisplayBuilder().OnFocus;
    public static DisplayBuilder OnFocusVisible => new DisplayBuilder().OnFocusVisible;
    public static DisplayBuilder OnActive => new DisplayBuilder().OnActive;
    public static DisplayBuilder OnDisabled => new DisplayBuilder().OnDisabled;
    public static DisplayBuilder OnDark => new DisplayBuilder().OnDark;
    public static DisplayBuilder OnVisited => new DisplayBuilder().OnVisited;
    public static DisplayBuilder OnChecked => new DisplayBuilder().OnChecked;
    public static DisplayBuilder OnOpen => new DisplayBuilder().OnOpen;
    public static DisplayBuilder OnFirst => new DisplayBuilder().OnFirst;
    public static DisplayBuilder OnLast => new DisplayBuilder().OnLast;
    public static DisplayBuilder OnOdd => new DisplayBuilder().OnOdd;
    public static DisplayBuilder OnEven => new DisplayBuilder().OnEven;
    public static DisplayBuilder OnBefore => new DisplayBuilder().OnBefore;
    public static DisplayBuilder OnAfter => new DisplayBuilder().OnAfter;
    public static DisplayBuilder OnPlaceholder => new DisplayBuilder().OnPlaceholder;
    public static DisplayBuilder OnSelection => new DisplayBuilder().OnSelection;
    public static DisplayBuilder OnMarker => new DisplayBuilder().OnMarker;
    public static DisplayBuilder OnFirstLetter => new DisplayBuilder().OnFirstLetter;
    public static DisplayBuilder OnFirstLine => new DisplayBuilder().OnFirstLine;
    public static DisplayBuilder OnFile => new DisplayBuilder().OnFile;
    public static DisplayBuilder OnBackdrop => new DisplayBuilder().OnBackdrop;
    public static DisplayBuilder OnGroupHover => new DisplayBuilder().OnGroupHover;
    public static DisplayBuilder OnGroupFocus => new DisplayBuilder().OnGroupFocus;
    public static DisplayBuilder OnPeerHover => new DisplayBuilder().OnPeerHover;
    public static DisplayBuilder OnPeerFocus => new DisplayBuilder().OnPeerFocus;

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
