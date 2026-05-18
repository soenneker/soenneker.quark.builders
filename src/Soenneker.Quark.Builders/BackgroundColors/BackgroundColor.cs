namespace Soenneker.Quark;

/// <summary>
/// Background color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
[TailwindModifiers(typeof(BackgroundColorBuilder), IncludeColorPalettes = true)]
public static partial class BackgroundColor
{
    public static BackgroundColorBuilder Primary => new(BackgroundColorEnum.Primary);
    public static BackgroundColorBuilder Secondary => new(BackgroundColorEnum.Secondary);
    public static BackgroundColorBuilder Destructive => new(BackgroundColorEnum.Destructive);
    public static BackgroundColorBuilder Muted => new(BackgroundColorEnum.Muted);
    public static BackgroundColorBuilder Accent => new(BackgroundColorEnum.Accent);
    public static BackgroundColorBuilder Popover => new(BackgroundColorEnum.Popover);
    public static BackgroundColorBuilder Card => new(BackgroundColorEnum.Card);
    public static BackgroundColorBuilder Background => new(BackgroundColorEnum.Background);
    public static BackgroundColorBuilder Foreground => new(BackgroundColorEnum.Foreground);
    public static BackgroundColorBuilder Border => new(BackgroundColorEnum.Border);
    public static BackgroundColorBuilder White => new(BackgroundColorEnum.White);
    public static BackgroundColorBuilder Black => new(BackgroundColorEnum.Black);
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
