namespace Soenneker.Quark;

/// <summary>
/// Border color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
public static class BorderColor
{
    public static BorderColorBuilder Primary => new(BorderColorEnum.Primary);
    public static BorderColorBuilder Secondary => new(BorderColorEnum.Secondary);
    public static BorderColorBuilder Destructive => new(BorderColorEnum.Destructive);
    public static BorderColorBuilder Muted => new(BorderColorEnum.Muted);
    public static BorderColorBuilder Accent => new(BorderColorEnum.Accent);
    public static BorderColorBuilder Popover => new(BorderColorEnum.Popover);
    public static BorderColorBuilder Card => new(BorderColorEnum.Card);
    public static BorderColorBuilder Background => new(BorderColorEnum.Background);
    public static BorderColorBuilder Border => new(BorderColorEnum.Border);
    public static BorderColorBuilder Input => new(BorderColorEnum.Input);
    public static BorderColorBuilder Ring => new(BorderColorEnum.Ring);
    public static BorderColorBuilder White => new(BorderColorEnum.White);
    public static BorderColorBuilder Black => new(BorderColorEnum.Black);
    public static BorderColorBuilder Transparent => new(BorderColorEnum.Transparent);

    /// <summary>
    /// Creates a border color builder from a Tailwind color token suffix such as <c>primary/30</c>, <c>zinc-300</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    public static BorderColorBuilder Token(string token) => new(token);

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>border-primary/30</c>.
    /// </summary>
    public static BorderColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("border-", utility));
}
