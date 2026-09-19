namespace Soenneker.Quark;

/// <summary>
/// Text color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
[TailwindModifiers(typeof(TextColorBuilder), IncludeColorPalettes = true)]
public static partial class TextColor
{
    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public static TextColorBuilder Primary => new(TextColorEnum.PrimaryValue);
    /// <summary>
    /// Gets or sets primary foreground.
    /// </summary>
    public static TextColorBuilder PrimaryForeground => new(TextColorEnum.PrimaryForegroundValue);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public static TextColorBuilder Secondary => new(TextColorEnum.SecondaryValue);
    /// <summary>
    /// Gets or sets secondary foreground.
    /// </summary>
    public static TextColorBuilder SecondaryForeground => new(TextColorEnum.SecondaryForegroundValue);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public static TextColorBuilder Destructive => new(TextColorEnum.DestructiveValue);
    /// <summary>
    /// Gets or sets destructive foreground.
    /// </summary>
    public static TextColorBuilder DestructiveForeground => new(TextColorEnum.DestructiveForegroundValue);
    /// <summary>
    /// Gets or sets muted foreground.
    /// </summary>
    public static TextColorBuilder MutedForeground => new(TextColorEnum.MutedForegroundValue);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public static TextColorBuilder Accent => new(TextColorEnum.AccentValue);
    /// <summary>
    /// Gets or sets accent foreground.
    /// </summary>
    public static TextColorBuilder AccentForeground => new(TextColorEnum.AccentForegroundValue);
    /// <summary>
    /// Gets or sets popover foreground.
    /// </summary>
    public static TextColorBuilder PopoverForeground => new(TextColorEnum.PopoverForegroundValue);
    /// <summary>
    /// Gets or sets card foreground.
    /// </summary>
    public static TextColorBuilder CardForeground => new(TextColorEnum.CardForegroundValue);
    /// <summary>
    /// Gets or sets foreground.
    /// </summary>
    public static TextColorBuilder Foreground => new(TextColorEnum.ForegroundValue);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public static TextColorBuilder White => new(TextColorEnum.WhiteValue);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public static TextColorBuilder Black => new(TextColorEnum.BlackValue);

    /// <summary>
    /// Creates a text color builder from a Tailwind color token suffix such as <c>primary/80</c>, <c>zinc-700</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static TextColorBuilder Token(string token) => new(ColorUtility.CreateClass("text-", token));

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>text-primary/80</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static TextColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("text-", utility));
}
