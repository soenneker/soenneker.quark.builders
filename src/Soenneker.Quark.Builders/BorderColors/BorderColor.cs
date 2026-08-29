namespace Soenneker.Quark;

/// <summary>
/// Border color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
[TailwindModifiers(typeof(BorderColorBuilder), IncludeColorPalettes = true)]
public static partial class BorderColor
{
    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public static BorderColorBuilder Primary => new(BorderColorEnum.Primary);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public static BorderColorBuilder Secondary => new(BorderColorEnum.Secondary);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public static BorderColorBuilder Destructive => new(BorderColorEnum.Destructive);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public static BorderColorBuilder Muted => new(BorderColorEnum.Muted);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public static BorderColorBuilder Accent => new(BorderColorEnum.Accent);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public static BorderColorBuilder Popover => new(BorderColorEnum.Popover);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public static BorderColorBuilder Card => new(BorderColorEnum.Card);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public static BorderColorBuilder Background => new(BorderColorEnum.Background);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public static BorderColorBuilder Border => new(BorderColorEnum.Border);
    /// <summary>
    /// Gets or sets input.
    /// </summary>
    public static BorderColorBuilder Input => new(BorderColorEnum.Input);
    /// <summary>
    /// Gets or sets ring.
    /// </summary>
    public static BorderColorBuilder Ring => new(BorderColorEnum.Ring);
    /// <summary>
    /// Gets or sets current.
    /// </summary>
    public static BorderColorBuilder Current => new(BorderColorEnum.Current);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public static BorderColorBuilder White => new(BorderColorEnum.White);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public static BorderColorBuilder Black => new(BorderColorEnum.Black);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public static BorderColorBuilder Transparent => new(BorderColorEnum.Transparent);

    /// <summary>
    /// Creates a border color builder from a Tailwind color token suffix such as <c>primary/30</c>, <c>zinc-300</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BorderColorBuilder Token(string token) => new(ColorUtility.CreateClass("border-", token));

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>border-primary/30</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BorderColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("border-", utility));
}
