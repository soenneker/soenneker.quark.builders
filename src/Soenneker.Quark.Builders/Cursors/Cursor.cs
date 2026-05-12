
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
    public static CursorBuilder Auto => new(CursorEnum.Auto);

    /// <summary>
    /// Alias for `Auto`.
    /// </summary>
    public static CursorBuilder Default => new(CursorEnum.Default);

    /// <summary>
    /// `cursor-pointer`
    /// </summary>
    public static CursorBuilder Pointer => new(CursorEnum.Pointer);

    /// <summary>
    /// `cursor-wait`
    /// </summary>
    public static CursorBuilder Wait => new(CursorEnum.Wait);

    /// <summary>
    /// `cursor-text`
    /// </summary>
    public static CursorBuilder Text => new(CursorEnum.Text);

    /// <summary>
    /// `cursor-move`
    /// </summary>
    public static CursorBuilder Move => new(CursorEnum.Move);

    /// <summary>
    /// `cursor-help`
    /// </summary>
    public static CursorBuilder Help => new(CursorEnum.Help);

    /// <summary>
    /// `cursor-not-allowed`
    /// </summary>
    public static CursorBuilder NotAllowed => new(CursorEnum.NotAllowed);

    /// <summary>
    /// `cursor-none`
    /// </summary>
    public static CursorBuilder None => new(CursorEnum.None);

    /// <summary>
    /// `cursor-context-menu`
    /// </summary>
    public static CursorBuilder ContextMenu => new(CursorEnum.ContextMenu);

    /// <summary>
    /// `cursor-progress`
    /// </summary>
    public static CursorBuilder Progress => new(CursorEnum.Progress);

    /// <summary>
    /// `cursor-cell`
    /// </summary>
    public static CursorBuilder Cell => new(CursorEnum.Cell);

    /// <summary>
    /// `cursor-crosshair`
    /// </summary>
    public static CursorBuilder Crosshair => new(CursorEnum.Crosshair);

    public static CursorBuilder VerticalText => new(CursorEnum.VerticalText);
    public static CursorBuilder Alias => new(CursorEnum.Alias);
    public static CursorBuilder Copy => new(CursorEnum.Copy);
    public static CursorBuilder NoDrop => new(CursorEnum.NoDrop);
    public static CursorBuilder Grab => new(CursorEnum.Grab);
    public static CursorBuilder Grabbing => new(CursorEnum.Grabbing);
    public static CursorBuilder AllScroll => new(CursorEnum.AllScroll);
    public static CursorBuilder ColResize => new(CursorEnum.ColResize);
    public static CursorBuilder RowResize => new(CursorEnum.RowResize);
    public static CursorBuilder NResize => new(CursorEnum.NResize);
    public static CursorBuilder EResize => new(CursorEnum.EResize);
    public static CursorBuilder SResize => new(CursorEnum.SResize);
    public static CursorBuilder WResize => new(CursorEnum.WResize);
    public static CursorBuilder NeResize => new(CursorEnum.NeResize);
    public static CursorBuilder NwResize => new(CursorEnum.NwResize);
    public static CursorBuilder SeResize => new(CursorEnum.SeResize);
    public static CursorBuilder SwResize => new(CursorEnum.SwResize);
    public static CursorBuilder EwResize => new(CursorEnum.EwResize);
    public static CursorBuilder NsResize => new(CursorEnum.NsResize);
    public static CursorBuilder NeswResize => new(CursorEnum.NeswResize);
    public static CursorBuilder NwseResize => new(CursorEnum.NwseResize);
    public static CursorBuilder ZoomIn => new(CursorEnum.ZoomIn);
    public static CursorBuilder ZoomOut => new(CursorEnum.ZoomOut);
}
