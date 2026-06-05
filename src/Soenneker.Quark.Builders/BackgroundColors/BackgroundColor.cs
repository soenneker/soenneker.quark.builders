namespace Soenneker.Quark;

/// <summary>
/// Background color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
[TailwindModifiers(typeof(BackgroundColorBuilder), IncludeColorPalettes = true)]
public static partial class BackgroundColor
{
    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public static BackgroundColorBuilder Primary => new(BackgroundColorEnum.Primary);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public static BackgroundColorBuilder Secondary => new(BackgroundColorEnum.Secondary);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public static BackgroundColorBuilder Destructive => new(BackgroundColorEnum.Destructive);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public static BackgroundColorBuilder Muted => new(BackgroundColorEnum.Muted);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public static BackgroundColorBuilder Accent => new(BackgroundColorEnum.Accent);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public static BackgroundColorBuilder Popover => new(BackgroundColorEnum.Popover);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public static BackgroundColorBuilder Card => new(BackgroundColorEnum.Card);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public static BackgroundColorBuilder Background => new(BackgroundColorEnum.Background);
    /// <summary>
    /// Gets or sets foreground.
    /// </summary>
    public static BackgroundColorBuilder Foreground => new(BackgroundColorEnum.Foreground);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public static BackgroundColorBuilder Border => new(BackgroundColorEnum.Border);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public static BackgroundColorBuilder White => new(BackgroundColorEnum.White);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public static BackgroundColorBuilder Black => new(BackgroundColorEnum.Black);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public static BackgroundColorBuilder Transparent => new(BackgroundColorEnum.Transparent);

    /// <summary>
    /// Creates a background color builder from a Tailwind color token suffix such as <c>primary/20</c>, <c>zinc-900</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    public static BackgroundColorBuilder Token(string token) => new(ColorUtility.CreateClass("bg-", token));

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>bg-primary/20</c>.
    /// </summary>
    public static BackgroundColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("bg-", utility));
}
