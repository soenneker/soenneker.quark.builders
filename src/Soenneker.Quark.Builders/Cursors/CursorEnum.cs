using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class CursorEnum
{
    public static readonly CursorEnum Auto = new("cursor-auto");
    public static readonly CursorEnum Default = new("cursor-default");
    public static readonly CursorEnum Pointer = new("cursor-pointer");
    public static readonly CursorEnum Wait = new("cursor-wait");
    public static readonly CursorEnum Text = new("cursor-text");
    public static readonly CursorEnum Move = new("cursor-move");
    public static readonly CursorEnum Help = new("cursor-help");
    public static readonly CursorEnum NotAllowed = new("cursor-not-allowed");
    public static readonly CursorEnum None = new("cursor-none");
    public static readonly CursorEnum ContextMenu = new("cursor-context-menu");
    public static readonly CursorEnum Progress = new("cursor-progress");
    public static readonly CursorEnum Cell = new("cursor-cell");
    public static readonly CursorEnum Crosshair = new("cursor-crosshair");
    public static readonly CursorEnum VerticalText = new("cursor-vertical-text");
    public static readonly CursorEnum Alias = new("cursor-alias");
    public static readonly CursorEnum Copy = new("cursor-copy");
    public static readonly CursorEnum NoDrop = new("cursor-no-drop");
    public static readonly CursorEnum Grab = new("cursor-grab");
    public static readonly CursorEnum Grabbing = new("cursor-grabbing");
    public static readonly CursorEnum AllScroll = new("cursor-all-scroll");
    public static readonly CursorEnum ColResize = new("cursor-col-resize");
    public static readonly CursorEnum RowResize = new("cursor-row-resize");
    public static readonly CursorEnum NResize = new("cursor-n-resize");
    public static readonly CursorEnum EResize = new("cursor-e-resize");
    public static readonly CursorEnum SResize = new("cursor-s-resize");
    public static readonly CursorEnum WResize = new("cursor-w-resize");
    public static readonly CursorEnum NeResize = new("cursor-ne-resize");
    public static readonly CursorEnum NwResize = new("cursor-nw-resize");
    public static readonly CursorEnum SeResize = new("cursor-se-resize");
    public static readonly CursorEnum SwResize = new("cursor-sw-resize");
    public static readonly CursorEnum EwResize = new("cursor-ew-resize");
    public static readonly CursorEnum NsResize = new("cursor-ns-resize");
    public static readonly CursorEnum NeswResize = new("cursor-nesw-resize");
    public static readonly CursorEnum NwseResize = new("cursor-nwse-resize");
    public static readonly CursorEnum ZoomIn = new("cursor-zoom-in");
    public static readonly CursorEnum ZoomOut = new("cursor-zoom-out");
}
