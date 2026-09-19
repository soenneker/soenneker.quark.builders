namespace Soenneker.Quark;

/// <summary>Creates Tailwind outline color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(OutlineColorBuilder), IncludeColorPalettes = true)]
public static partial class OutlineColor
{
    /// <summary>Selects the mauve palette for the next color.</summary>
    public static ColorPaletteBuilder<OutlineColorBuilder> Mauve => new("mauve", Token);

    /// <summary>Selects the olive palette for the next color.</summary>
    public static ColorPaletteBuilder<OutlineColorBuilder> Olive => new("olive", Token);

    /// <summary>Selects the mist palette for the next color.</summary>
    public static ColorPaletteBuilder<OutlineColorBuilder> Mist => new("mist", Token);

    /// <summary>Selects the taupe palette for the next color.</summary>
    public static ColorPaletteBuilder<OutlineColorBuilder> Taupe => new("taupe", Token);

    /// <summary>Adds <c>outline-primary</c>.</summary>
    public static OutlineColorBuilder Primary => new(OutlineColorEnum.Primary);

    /// <summary>Adds <c>outline-primary-foreground</c>.</summary>
    public static OutlineColorBuilder PrimaryForeground => new(OutlineColorEnum.PrimaryForeground);

    /// <summary>Adds <c>outline-secondary</c>.</summary>
    public static OutlineColorBuilder Secondary => new(OutlineColorEnum.Secondary);

    /// <summary>Adds <c>outline-secondary-foreground</c>.</summary>
    public static OutlineColorBuilder SecondaryForeground => new(OutlineColorEnum.SecondaryForeground);

    /// <summary>Adds <c>outline-destructive</c>.</summary>
    public static OutlineColorBuilder Destructive => new(OutlineColorEnum.Destructive);

    /// <summary>Adds <c>outline-destructive-foreground</c>.</summary>
    public static OutlineColorBuilder DestructiveForeground => new(OutlineColorEnum.DestructiveForeground);

    /// <summary>Adds <c>outline-muted</c>.</summary>
    public static OutlineColorBuilder Muted => new(OutlineColorEnum.Muted);

    /// <summary>Adds <c>outline-muted-foreground</c>.</summary>
    public static OutlineColorBuilder MutedForeground => new(OutlineColorEnum.MutedForeground);

    /// <summary>Adds <c>outline-accent</c>.</summary>
    public static OutlineColorBuilder Accent => new(OutlineColorEnum.Accent);

    /// <summary>Adds <c>outline-accent-foreground</c>.</summary>
    public static OutlineColorBuilder AccentForeground => new(OutlineColorEnum.AccentForeground);

    /// <summary>Adds <c>outline-popover</c>.</summary>
    public static OutlineColorBuilder Popover => new(OutlineColorEnum.Popover);

    /// <summary>Adds <c>outline-popover-foreground</c>.</summary>
    public static OutlineColorBuilder PopoverForeground => new(OutlineColorEnum.PopoverForeground);

    /// <summary>Adds <c>outline-card</c>.</summary>
    public static OutlineColorBuilder Card => new(OutlineColorEnum.Card);

    /// <summary>Adds <c>outline-card-foreground</c>.</summary>
    public static OutlineColorBuilder CardForeground => new(OutlineColorEnum.CardForeground);

    /// <summary>Adds <c>outline-background</c>.</summary>
    public static OutlineColorBuilder Background => new(OutlineColorEnum.Background);

    /// <summary>Adds <c>outline-foreground</c>.</summary>
    public static OutlineColorBuilder Foreground => new(OutlineColorEnum.Foreground);

    /// <summary>Adds <c>outline-border</c>.</summary>
    public static OutlineColorBuilder Border => new(OutlineColorEnum.Border);

    /// <summary>Adds <c>outline-input</c>.</summary>
    public static OutlineColorBuilder Input => new(OutlineColorEnum.Input);

    /// <summary>Adds <c>outline-ring</c>.</summary>
    public static OutlineColorBuilder Ring => new(OutlineColorEnum.Ring);

    /// <summary>Adds <c>outline-ring/50</c>.</summary>
    public static OutlineColorBuilder Ring50 => new(OutlineColorEnum.Ring50);

    /// <summary>Adds <c>outline-success</c>.</summary>
    public static OutlineColorBuilder Success => new(OutlineColorEnum.Success);

    /// <summary>Adds <c>outline-warning</c>.</summary>
    public static OutlineColorBuilder Warning => new(OutlineColorEnum.Warning);

    /// <summary>Adds <c>outline-info</c>.</summary>
    public static OutlineColorBuilder Info => new(OutlineColorEnum.Info);

    /// <summary>Adds <c>outline-white</c>.</summary>
    public static OutlineColorBuilder White => new(OutlineColorEnum.White);

    /// <summary>Adds <c>outline-black</c>.</summary>
    public static OutlineColorBuilder Black => new(OutlineColorEnum.Black);

    /// <summary>Adds <c>outline-transparent</c>.</summary>
    public static OutlineColorBuilder Transparent => new(OutlineColorEnum.Transparent);

    /// <summary>Adds <c>outline-current</c>.</summary>
    public static OutlineColorBuilder Current => new(OutlineColorEnum.Current);

    /// <summary>Adds <c>outline-inherit</c>.</summary>
    public static OutlineColorBuilder Inherit => new(OutlineColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static OutlineColorBuilder Token(string token) => new(ColorUtility.CreateClass("outline-", token));

    /// <summary>Creates a utility from a complete class with the <c>outline-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static OutlineColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("outline-", utility));
}
