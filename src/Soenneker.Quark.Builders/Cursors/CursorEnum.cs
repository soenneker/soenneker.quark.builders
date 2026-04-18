using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class CursorEnum
{
    public static readonly CursorEnum Auto = new("auto");
    public static readonly CursorEnum Default = Auto;
    public static readonly CursorEnum Pointer = new("pointer");
    public static readonly CursorEnum Wait = new("wait");
    public static readonly CursorEnum Text = new("text");
    public static readonly CursorEnum Move = new("move");
    public static readonly CursorEnum Help = new("help");
    public static readonly CursorEnum NotAllowed = new("not-allowed");
    public static readonly CursorEnum None = new("none");
    public static readonly CursorEnum ContextMenu = new("context-menu");
    public static readonly CursorEnum Progress = new("progress");
    public static readonly CursorEnum Cell = new("cell");
    public static readonly CursorEnum Crosshair = new("crosshair");
    public static readonly CursorEnum VerticalText = new("vertical-text");
    public static readonly CursorEnum Alias = new("alias");
    public static readonly CursorEnum Copy = new("copy");
    public static readonly CursorEnum NoDrop = new("no-drop");
    public static readonly CursorEnum Grab = new("grab");
    public static readonly CursorEnum Grabbing = new("grabbing");
    public static readonly CursorEnum AllScroll = new("all-scroll");
    public static readonly CursorEnum ColResize = new("col-resize");
    public static readonly CursorEnum RowResize = new("row-resize");
    public static readonly CursorEnum NResize = new("n-resize");
    public static readonly CursorEnum EResize = new("e-resize");
    public static readonly CursorEnum SResize = new("s-resize");
    public static readonly CursorEnum WResize = new("w-resize");
    public static readonly CursorEnum NeResize = new("ne-resize");
    public static readonly CursorEnum NwResize = new("nw-resize");
    public static readonly CursorEnum SeResize = new("se-resize");
    public static readonly CursorEnum SwResize = new("sw-resize");
    public static readonly CursorEnum EwResize = new("ew-resize");
    public static readonly CursorEnum NsResize = new("ns-resize");
    public static readonly CursorEnum NeswResize = new("nesw-resize");
    public static readonly CursorEnum NwseResize = new("nwse-resize");
    public static readonly CursorEnum ZoomIn = new("zoom-in");
    public static readonly CursorEnum ZoomOut = new("zoom-out");
}
