using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the cursor enum.
/// </summary>
[EnumValue<string>]
public sealed partial class CursorEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly CursorEnum Auto = new("cursor-auto");
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly CursorEnum Default = new("cursor-default");
    /// <summary>
    /// The pointer.
    /// </summary>
    public static readonly CursorEnum Pointer = new("cursor-pointer");
    /// <summary>
    /// The wait.
    /// </summary>
    public static readonly CursorEnum Wait = new("cursor-wait");
    /// <summary>
    /// The text.
    /// </summary>
    public static readonly CursorEnum Text = new("cursor-text");
    /// <summary>
    /// The move.
    /// </summary>
    public static readonly CursorEnum Move = new("cursor-move");
    /// <summary>
    /// The help.
    /// </summary>
    public static readonly CursorEnum Help = new("cursor-help");
    /// <summary>
    /// The not allowed.
    /// </summary>
    public static readonly CursorEnum NotAllowed = new("cursor-not-allowed");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly CursorEnum None = new("cursor-none");
    /// <summary>
    /// The context menu.
    /// </summary>
    public static readonly CursorEnum ContextMenu = new("cursor-context-menu");
    /// <summary>
    /// The progress.
    /// </summary>
    public static readonly CursorEnum Progress = new("cursor-progress");
    /// <summary>
    /// The cell.
    /// </summary>
    public static readonly CursorEnum Cell = new("cursor-cell");
    /// <summary>
    /// The crosshair.
    /// </summary>
    public static readonly CursorEnum Crosshair = new("cursor-crosshair");
    /// <summary>
    /// The vertical text.
    /// </summary>
    public static readonly CursorEnum VerticalText = new("cursor-vertical-text");
    /// <summary>
    /// The alias.
    /// </summary>
    public static readonly CursorEnum Alias = new("cursor-alias");
    /// <summary>
    /// The copy.
    /// </summary>
    public static readonly CursorEnum Copy = new("cursor-copy");
    /// <summary>
    /// The no drop.
    /// </summary>
    public static readonly CursorEnum NoDrop = new("cursor-no-drop");
    /// <summary>
    /// The grab.
    /// </summary>
    public static readonly CursorEnum Grab = new("cursor-grab");
    /// <summary>
    /// The grabbing.
    /// </summary>
    public static readonly CursorEnum Grabbing = new("cursor-grabbing");
    /// <summary>
    /// The all scroll.
    /// </summary>
    public static readonly CursorEnum AllScroll = new("cursor-all-scroll");
    /// <summary>
    /// The col resize.
    /// </summary>
    public static readonly CursorEnum ColResize = new("cursor-col-resize");
    /// <summary>
    /// The row resize.
    /// </summary>
    public static readonly CursorEnum RowResize = new("cursor-row-resize");
    /// <summary>
    /// The n resize.
    /// </summary>
    public static readonly CursorEnum NResize = new("cursor-n-resize");
    /// <summary>
    /// The e resize.
    /// </summary>
    public static readonly CursorEnum EResize = new("cursor-e-resize");
    /// <summary>
    /// The s resize.
    /// </summary>
    public static readonly CursorEnum SResize = new("cursor-s-resize");
    /// <summary>
    /// The w resize.
    /// </summary>
    public static readonly CursorEnum WResize = new("cursor-w-resize");
    /// <summary>
    /// The ne resize.
    /// </summary>
    public static readonly CursorEnum NeResize = new("cursor-ne-resize");
    /// <summary>
    /// The nw resize.
    /// </summary>
    public static readonly CursorEnum NwResize = new("cursor-nw-resize");
    /// <summary>
    /// The se resize.
    /// </summary>
    public static readonly CursorEnum SeResize = new("cursor-se-resize");
    /// <summary>
    /// The sw resize.
    /// </summary>
    public static readonly CursorEnum SwResize = new("cursor-sw-resize");
    /// <summary>
    /// The ew resize.
    /// </summary>
    public static readonly CursorEnum EwResize = new("cursor-ew-resize");
    /// <summary>
    /// The ns resize.
    /// </summary>
    public static readonly CursorEnum NsResize = new("cursor-ns-resize");
    /// <summary>
    /// The nesw resize.
    /// </summary>
    public static readonly CursorEnum NeswResize = new("cursor-nesw-resize");
    /// <summary>
    /// The nwse resize.
    /// </summary>
    public static readonly CursorEnum NwseResize = new("cursor-nwse-resize");
    /// <summary>
    /// The zoom in.
    /// </summary>
    public static readonly CursorEnum ZoomIn = new("cursor-zoom-in");
    /// <summary>
    /// The zoom out.
    /// </summary>
    public static readonly CursorEnum ZoomOut = new("cursor-zoom-out");
}
