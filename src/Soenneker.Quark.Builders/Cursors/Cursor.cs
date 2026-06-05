
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

    /// <summary>
    /// Gets or sets vertical text.
    /// </summary>
    public static CursorBuilder VerticalText => new(CursorEnum.VerticalText);
    /// <summary>
    /// Gets or sets alias.
    /// </summary>
    public static CursorBuilder Alias => new(CursorEnum.Alias);
    /// <summary>
    /// Gets or sets copy.
    /// </summary>
    public static CursorBuilder Copy => new(CursorEnum.Copy);
    /// <summary>
    /// Gets or sets no drop.
    /// </summary>
    public static CursorBuilder NoDrop => new(CursorEnum.NoDrop);
    /// <summary>
    /// Gets or sets grab.
    /// </summary>
    public static CursorBuilder Grab => new(CursorEnum.Grab);
    /// <summary>
    /// Gets or sets grabbing.
    /// </summary>
    public static CursorBuilder Grabbing => new(CursorEnum.Grabbing);
    /// <summary>
    /// Gets or sets all scroll.
    /// </summary>
    public static CursorBuilder AllScroll => new(CursorEnum.AllScroll);
    /// <summary>
    /// Gets or sets col resize.
    /// </summary>
    public static CursorBuilder ColResize => new(CursorEnum.ColResize);
    /// <summary>
    /// Gets or sets row resize.
    /// </summary>
    public static CursorBuilder RowResize => new(CursorEnum.RowResize);
    /// <summary>
    /// Gets or sets n resize.
    /// </summary>
    public static CursorBuilder NResize => new(CursorEnum.NResize);
    /// <summary>
    /// Gets or sets e resize.
    /// </summary>
    public static CursorBuilder EResize => new(CursorEnum.EResize);
    /// <summary>
    /// Gets or sets s resize.
    /// </summary>
    public static CursorBuilder SResize => new(CursorEnum.SResize);
    /// <summary>
    /// Gets or sets w resize.
    /// </summary>
    public static CursorBuilder WResize => new(CursorEnum.WResize);
    /// <summary>
    /// Gets or sets ne resize.
    /// </summary>
    public static CursorBuilder NeResize => new(CursorEnum.NeResize);
    /// <summary>
    /// Gets or sets nw resize.
    /// </summary>
    public static CursorBuilder NwResize => new(CursorEnum.NwResize);
    /// <summary>
    /// Gets or sets se resize.
    /// </summary>
    public static CursorBuilder SeResize => new(CursorEnum.SeResize);
    /// <summary>
    /// Gets or sets sw resize.
    /// </summary>
    public static CursorBuilder SwResize => new(CursorEnum.SwResize);
    /// <summary>
    /// Gets or sets ew resize.
    /// </summary>
    public static CursorBuilder EwResize => new(CursorEnum.EwResize);
    /// <summary>
    /// Gets or sets ns resize.
    /// </summary>
    public static CursorBuilder NsResize => new(CursorEnum.NsResize);
    /// <summary>
    /// Gets or sets nesw resize.
    /// </summary>
    public static CursorBuilder NeswResize => new(CursorEnum.NeswResize);
    /// <summary>
    /// Gets or sets nwse resize.
    /// </summary>
    public static CursorBuilder NwseResize => new(CursorEnum.NwseResize);
    /// <summary>
    /// Gets or sets zoom in.
    /// </summary>
    public static CursorBuilder ZoomIn => new(CursorEnum.ZoomIn);
    /// <summary>
    /// Gets or sets zoom out.
    /// </summary>
    public static CursorBuilder ZoomOut => new(CursorEnum.ZoomOut);
}
