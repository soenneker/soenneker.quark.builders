namespace Soenneker.Quark;

/// <summary>Creates Tailwind decoration color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(DecorationColorBuilder), IncludeColorPalettes = true)]
public static partial class DecorationColor
{
    /// <summary>Selects the mauve palette for the next color.</summary>
    public static ColorPaletteBuilder<DecorationColorBuilder> Mauve => new("mauve", Token);

    /// <summary>Selects the olive palette for the next color.</summary>
    public static ColorPaletteBuilder<DecorationColorBuilder> Olive => new("olive", Token);

    /// <summary>Selects the mist palette for the next color.</summary>
    public static ColorPaletteBuilder<DecorationColorBuilder> Mist => new("mist", Token);

    /// <summary>Selects the taupe palette for the next color.</summary>
    public static ColorPaletteBuilder<DecorationColorBuilder> Taupe => new("taupe", Token);

    /// <summary>Adds <c>decoration-primary</c>.</summary>
    public static DecorationColorBuilder Primary => new(DecorationColorEnum.Primary);

    /// <summary>Adds <c>decoration-primary-foreground</c>.</summary>
    public static DecorationColorBuilder PrimaryForeground => new(DecorationColorEnum.PrimaryForeground);

    /// <summary>Adds <c>decoration-secondary</c>.</summary>
    public static DecorationColorBuilder Secondary => new(DecorationColorEnum.Secondary);

    /// <summary>Adds <c>decoration-secondary-foreground</c>.</summary>
    public static DecorationColorBuilder SecondaryForeground => new(DecorationColorEnum.SecondaryForeground);

    /// <summary>Adds <c>decoration-destructive</c>.</summary>
    public static DecorationColorBuilder Destructive => new(DecorationColorEnum.Destructive);

    /// <summary>Adds <c>decoration-destructive-foreground</c>.</summary>
    public static DecorationColorBuilder DestructiveForeground => new(DecorationColorEnum.DestructiveForeground);

    /// <summary>Adds <c>decoration-muted</c>.</summary>
    public static DecorationColorBuilder Muted => new(DecorationColorEnum.Muted);

    /// <summary>Adds <c>decoration-muted-foreground</c>.</summary>
    public static DecorationColorBuilder MutedForeground => new(DecorationColorEnum.MutedForeground);

    /// <summary>Adds <c>decoration-accent</c>.</summary>
    public static DecorationColorBuilder Accent => new(DecorationColorEnum.Accent);

    /// <summary>Adds <c>decoration-accent-foreground</c>.</summary>
    public static DecorationColorBuilder AccentForeground => new(DecorationColorEnum.AccentForeground);

    /// <summary>Adds <c>decoration-popover</c>.</summary>
    public static DecorationColorBuilder Popover => new(DecorationColorEnum.Popover);

    /// <summary>Adds <c>decoration-popover-foreground</c>.</summary>
    public static DecorationColorBuilder PopoverForeground => new(DecorationColorEnum.PopoverForeground);

    /// <summary>Adds <c>decoration-card</c>.</summary>
    public static DecorationColorBuilder Card => new(DecorationColorEnum.Card);

    /// <summary>Adds <c>decoration-card-foreground</c>.</summary>
    public static DecorationColorBuilder CardForeground => new(DecorationColorEnum.CardForeground);

    /// <summary>Adds <c>decoration-background</c>.</summary>
    public static DecorationColorBuilder Background => new(DecorationColorEnum.Background);

    /// <summary>Adds <c>decoration-foreground</c>.</summary>
    public static DecorationColorBuilder Foreground => new(DecorationColorEnum.Foreground);

    /// <summary>Adds <c>decoration-border</c>.</summary>
    public static DecorationColorBuilder Border => new(DecorationColorEnum.Border);

    /// <summary>Adds <c>decoration-input</c>.</summary>
    public static DecorationColorBuilder Input => new(DecorationColorEnum.Input);

    /// <summary>Adds <c>decoration-ring</c>.</summary>
    public static DecorationColorBuilder Ring => new(DecorationColorEnum.Ring);

    /// <summary>Adds <c>decoration-ring/50</c>.</summary>
    public static DecorationColorBuilder Ring50 => new(DecorationColorEnum.Ring50);

    /// <summary>Adds <c>decoration-success</c>.</summary>
    public static DecorationColorBuilder Success => new(DecorationColorEnum.Success);

    /// <summary>Adds <c>decoration-warning</c>.</summary>
    public static DecorationColorBuilder Warning => new(DecorationColorEnum.Warning);

    /// <summary>Adds <c>decoration-info</c>.</summary>
    public static DecorationColorBuilder Info => new(DecorationColorEnum.Info);

    /// <summary>Adds <c>decoration-white</c>.</summary>
    public static DecorationColorBuilder White => new(DecorationColorEnum.White);

    /// <summary>Adds <c>decoration-black</c>.</summary>
    public static DecorationColorBuilder Black => new(DecorationColorEnum.Black);

    /// <summary>Adds <c>decoration-transparent</c>.</summary>
    public static DecorationColorBuilder Transparent => new(DecorationColorEnum.Transparent);

    /// <summary>Adds <c>decoration-current</c>.</summary>
    public static DecorationColorBuilder Current => new(DecorationColorEnum.Current);

    /// <summary>Adds <c>decoration-inherit</c>.</summary>
    public static DecorationColorBuilder Inherit => new(DecorationColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static DecorationColorBuilder Token(string token) => new(ColorUtility.CreateClass("decoration-", token));

    /// <summary>Creates a utility from a complete class with the <c>decoration-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static DecorationColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("decoration-", utility));
}
