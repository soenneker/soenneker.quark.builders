namespace Soenneker.Quark;

/// <summary>
/// Text color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
[TailwindModifiers(typeof(TextColorBuilder), IncludeColorPalettes = true)]
public static partial class TextColor
{
    public static TextColorBuilder Primary => new(TextColorEnum.Primary);
    public static TextColorBuilder PrimaryForeground => new(TextColorEnum.PrimaryForeground);
    public static TextColorBuilder Secondary => new(TextColorEnum.Secondary);
    public static TextColorBuilder SecondaryForeground => new(TextColorEnum.SecondaryForeground);
    public static TextColorBuilder Destructive => new(TextColorEnum.Destructive);
    public static TextColorBuilder DestructiveForeground => new(TextColorEnum.DestructiveForeground);
    public static TextColorBuilder MutedForeground => new(TextColorEnum.MutedForeground);
    public static TextColorBuilder Accent => new(TextColorEnum.Accent);
    public static TextColorBuilder AccentForeground => new(TextColorEnum.AccentForeground);
    public static TextColorBuilder PopoverForeground => new(TextColorEnum.PopoverForeground);
    public static TextColorBuilder CardForeground => new(TextColorEnum.CardForeground);
    public static TextColorBuilder Foreground => new(TextColorEnum.Foreground);
    public static TextColorBuilder White => new(TextColorEnum.White);
    public static TextColorBuilder Black => new(TextColorEnum.Black);

    /// <summary>
    /// Creates a text color builder from a Tailwind color token suffix such as <c>primary/80</c>, <c>zinc-700</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    public static TextColorBuilder Token(string token) => new(ColorUtility.CreateClass("text-", token));

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>text-primary/80</c>.
    /// </summary>
    public static TextColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("text-", utility));
}
