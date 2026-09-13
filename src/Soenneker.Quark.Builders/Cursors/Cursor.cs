
namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned cursor utility.
/// </summary>
[TailwindModifiers(typeof(CursorBuilder))]
public static partial class Cursor
{
    /// <summary>
    /// `cursor-auto`
    /// </summary>
    public static CursorBuilder Auto => new(CursorEnum.AutoValue);

    /// <summary>
    /// Alias for `Auto`.
    /// </summary>
    public static CursorBuilder Default => new(CursorEnum.DefaultValue);

    /// <summary>
    /// `cursor-pointer`
    /// </summary>
    public static CursorBuilder Pointer => new(CursorEnum.PointerValue);

    /// <summary>
    /// `cursor-wait`
    /// </summary>
    public static CursorBuilder Wait => new(CursorEnum.WaitValue);

    /// <summary>
    /// `cursor-text`
    /// </summary>
    public static CursorBuilder Text => new(CursorEnum.TextValue);

    /// <summary>
    /// `cursor-move`
    /// </summary>
    public static CursorBuilder Move => new(CursorEnum.MoveValue);

    /// <summary>
    /// `cursor-help`
    /// </summary>
    public static CursorBuilder Help => new(CursorEnum.HelpValue);

    /// <summary>
    /// `cursor-not-allowed`
    /// </summary>
    public static CursorBuilder NotAllowed => new(CursorEnum.NotAllowedValue);

    /// <summary>
    /// `cursor-none`
    /// </summary>
    public static CursorBuilder None => new(CursorEnum.NoneValue);

    /// <summary>
    /// `cursor-context-menu`
    /// </summary>
    public static CursorBuilder ContextMenu => new(CursorEnum.ContextMenuValue);

    /// <summary>
    /// `cursor-progress`
    /// </summary>
    public static CursorBuilder Progress => new(CursorEnum.ProgressValue);

    /// <summary>
    /// `cursor-cell`
    /// </summary>
    public static CursorBuilder Cell => new(CursorEnum.CellValue);

    /// <summary>
    /// `cursor-crosshair`
    /// </summary>
    public static CursorBuilder Crosshair => new(CursorEnum.CrosshairValue);

    /// <summary>
    /// Gets or sets vertical text.
    /// </summary>
    public static CursorBuilder VerticalText => new(CursorEnum.VerticalTextValue);
    /// <summary>
    /// Gets or sets alias.
    /// </summary>
    public static CursorBuilder Alias => new(CursorEnum.AliasValue);
    /// <summary>
    /// Gets or sets copy.
    /// </summary>
    public static CursorBuilder Copy => new(CursorEnum.CopyValue);
    /// <summary>
    /// Gets or sets no drop.
    /// </summary>
    public static CursorBuilder NoDrop => new(CursorEnum.NoDropValue);
    /// <summary>
    /// Gets or sets grab.
    /// </summary>
    public static CursorBuilder Grab => new(CursorEnum.GrabValue);
    /// <summary>
    /// Gets or sets grabbing.
    /// </summary>
    public static CursorBuilder Grabbing => new(CursorEnum.GrabbingValue);
    /// <summary>
    /// Gets or sets all scroll.
    /// </summary>
    public static CursorBuilder AllScroll => new(CursorEnum.AllScrollValue);
    /// <summary>
    /// Gets or sets col resize.
    /// </summary>
    public static CursorBuilder ColResize => new(CursorEnum.ColResizeValue);
    /// <summary>
    /// Gets or sets row resize.
    /// </summary>
    public static CursorBuilder RowResize => new(CursorEnum.RowResizeValue);
    /// <summary>
    /// Gets or sets n resize.
    /// </summary>
    public static CursorBuilder NResize => new(CursorEnum.NResizeValue);
    /// <summary>
    /// Gets or sets e resize.
    /// </summary>
    public static CursorBuilder EResize => new(CursorEnum.EResizeValue);
    /// <summary>
    /// Gets or sets s resize.
    /// </summary>
    public static CursorBuilder SResize => new(CursorEnum.SResizeValue);
    /// <summary>
    /// Gets or sets w resize.
    /// </summary>
    public static CursorBuilder WResize => new(CursorEnum.WResizeValue);
    /// <summary>
    /// Gets or sets ne resize.
    /// </summary>
    public static CursorBuilder NeResize => new(CursorEnum.NeResizeValue);
    /// <summary>
    /// Gets or sets nw resize.
    /// </summary>
    public static CursorBuilder NwResize => new(CursorEnum.NwResizeValue);
    /// <summary>
    /// Gets or sets se resize.
    /// </summary>
    public static CursorBuilder SeResize => new(CursorEnum.SeResizeValue);
    /// <summary>
    /// Gets or sets sw resize.
    /// </summary>
    public static CursorBuilder SwResize => new(CursorEnum.SwResizeValue);
    /// <summary>
    /// Gets or sets ew resize.
    /// </summary>
    public static CursorBuilder EwResize => new(CursorEnum.EwResizeValue);
    /// <summary>
    /// Gets or sets ns resize.
    /// </summary>
    public static CursorBuilder NsResize => new(CursorEnum.NsResizeValue);
    /// <summary>
    /// Gets or sets nesw resize.
    /// </summary>
    public static CursorBuilder NeswResize => new(CursorEnum.NeswResizeValue);
    /// <summary>
    /// Gets or sets nwse resize.
    /// </summary>
    public static CursorBuilder NwseResize => new(CursorEnum.NwseResizeValue);
    /// <summary>
    /// Gets or sets zoom in.
    /// </summary>
    public static CursorBuilder ZoomIn => new(CursorEnum.ZoomInValue);
    /// <summary>
    /// Gets or sets zoom out.
    /// </summary>
    public static CursorBuilder ZoomOut => new(CursorEnum.ZoomOutValue);
}
