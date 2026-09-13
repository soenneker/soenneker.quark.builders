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
    public static BackgroundColorBuilder Primary => new(BackgroundColorEnum.PrimaryValue);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public static BackgroundColorBuilder Secondary => new(BackgroundColorEnum.SecondaryValue);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public static BackgroundColorBuilder Destructive => new(BackgroundColorEnum.DestructiveValue);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public static BackgroundColorBuilder Muted => new(BackgroundColorEnum.MutedValue);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public static BackgroundColorBuilder Accent => new(BackgroundColorEnum.AccentValue);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public static BackgroundColorBuilder Popover => new(BackgroundColorEnum.PopoverValue);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public static BackgroundColorBuilder Card => new(BackgroundColorEnum.CardValue);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public static BackgroundColorBuilder Background => new(BackgroundColorEnum.BackgroundValue);
    /// <summary>
    /// Gets or sets foreground.
    /// </summary>
    public static BackgroundColorBuilder Foreground => new(BackgroundColorEnum.ForegroundValue);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public static BackgroundColorBuilder Border => new(BackgroundColorEnum.BorderValue);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public static BackgroundColorBuilder White => new(BackgroundColorEnum.WhiteValue);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public static BackgroundColorBuilder Black => new(BackgroundColorEnum.BlackValue);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public static BackgroundColorBuilder Transparent => new(BackgroundColorEnum.TransparentValue);

    /// <summary>
    /// Creates a background color builder from a Tailwind color token suffix such as <c>primary/20</c>, <c>zinc-900</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BackgroundColorBuilder Token(string token) => new(ColorUtility.CreateClass("bg-", token));

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>bg-primary/20</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BackgroundColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("bg-", utility));
}
