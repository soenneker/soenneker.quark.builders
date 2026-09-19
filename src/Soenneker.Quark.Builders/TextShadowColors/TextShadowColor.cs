namespace Soenneker.Quark;

/// <summary>Creates Tailwind text shadow color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(TextShadowColorBuilder), IncludeColorPalettes = true)]
public static partial class TextShadowColor
{
    /// <summary>Adds <c>text-shadow-primary</c>.</summary>
    public static TextShadowColorBuilder Primary => new(TextShadowColorEnum.Primary);

    /// <summary>Adds <c>text-shadow-primary-foreground</c>.</summary>
    public static TextShadowColorBuilder PrimaryForeground => new(TextShadowColorEnum.PrimaryForeground);

    /// <summary>Adds <c>text-shadow-secondary</c>.</summary>
    public static TextShadowColorBuilder Secondary => new(TextShadowColorEnum.Secondary);

    /// <summary>Adds <c>text-shadow-secondary-foreground</c>.</summary>
    public static TextShadowColorBuilder SecondaryForeground => new(TextShadowColorEnum.SecondaryForeground);

    /// <summary>Adds <c>text-shadow-destructive</c>.</summary>
    public static TextShadowColorBuilder Destructive => new(TextShadowColorEnum.Destructive);

    /// <summary>Adds <c>text-shadow-destructive-foreground</c>.</summary>
    public static TextShadowColorBuilder DestructiveForeground => new(TextShadowColorEnum.DestructiveForeground);

    /// <summary>Adds <c>text-shadow-muted</c>.</summary>
    public static TextShadowColorBuilder Muted => new(TextShadowColorEnum.Muted);

    /// <summary>Adds <c>text-shadow-muted-foreground</c>.</summary>
    public static TextShadowColorBuilder MutedForeground => new(TextShadowColorEnum.MutedForeground);

    /// <summary>Adds <c>text-shadow-accent</c>.</summary>
    public static TextShadowColorBuilder Accent => new(TextShadowColorEnum.Accent);

    /// <summary>Adds <c>text-shadow-accent-foreground</c>.</summary>
    public static TextShadowColorBuilder AccentForeground => new(TextShadowColorEnum.AccentForeground);

    /// <summary>Adds <c>text-shadow-popover</c>.</summary>
    public static TextShadowColorBuilder Popover => new(TextShadowColorEnum.Popover);

    /// <summary>Adds <c>text-shadow-popover-foreground</c>.</summary>
    public static TextShadowColorBuilder PopoverForeground => new(TextShadowColorEnum.PopoverForeground);

    /// <summary>Adds <c>text-shadow-card</c>.</summary>
    public static TextShadowColorBuilder Card => new(TextShadowColorEnum.Card);

    /// <summary>Adds <c>text-shadow-card-foreground</c>.</summary>
    public static TextShadowColorBuilder CardForeground => new(TextShadowColorEnum.CardForeground);

    /// <summary>Adds <c>text-shadow-background</c>.</summary>
    public static TextShadowColorBuilder Background => new(TextShadowColorEnum.Background);

    /// <summary>Adds <c>text-shadow-foreground</c>.</summary>
    public static TextShadowColorBuilder Foreground => new(TextShadowColorEnum.Foreground);

    /// <summary>Adds <c>text-shadow-border</c>.</summary>
    public static TextShadowColorBuilder Border => new(TextShadowColorEnum.Border);

    /// <summary>Adds <c>text-shadow-input</c>.</summary>
    public static TextShadowColorBuilder Input => new(TextShadowColorEnum.Input);

    /// <summary>Adds <c>text-shadow-ring</c>.</summary>
    public static TextShadowColorBuilder Ring => new(TextShadowColorEnum.Ring);

    /// <summary>Adds <c>text-shadow-ring/50</c>.</summary>
    public static TextShadowColorBuilder Ring50 => new(TextShadowColorEnum.Ring50);

    /// <summary>Adds <c>text-shadow-success</c>.</summary>
    public static TextShadowColorBuilder Success => new(TextShadowColorEnum.Success);

    /// <summary>Adds <c>text-shadow-warning</c>.</summary>
    public static TextShadowColorBuilder Warning => new(TextShadowColorEnum.Warning);

    /// <summary>Adds <c>text-shadow-info</c>.</summary>
    public static TextShadowColorBuilder Info => new(TextShadowColorEnum.Info);

    /// <summary>Adds <c>text-shadow-white</c>.</summary>
    public static TextShadowColorBuilder White => new(TextShadowColorEnum.White);

    /// <summary>Adds <c>text-shadow-black</c>.</summary>
    public static TextShadowColorBuilder Black => new(TextShadowColorEnum.Black);

    /// <summary>Adds <c>text-shadow-transparent</c>.</summary>
    public static TextShadowColorBuilder Transparent => new(TextShadowColorEnum.Transparent);

    /// <summary>Adds <c>text-shadow-current</c>.</summary>
    public static TextShadowColorBuilder Current => new(TextShadowColorEnum.Current);

    /// <summary>Adds <c>text-shadow-inherit</c>.</summary>
    public static TextShadowColorBuilder Inherit => new(TextShadowColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static TextShadowColorBuilder Token(string token) => new(ColorUtility.CreateClass("text-shadow-", token));

    /// <summary>Creates a utility from a complete class with the <c>text-shadow-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static TextShadowColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("text-shadow-", utility));
}
