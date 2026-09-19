namespace Soenneker.Quark;

/// <summary>Creates Tailwind inset ring color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(InsetRingColorBuilder), IncludeColorPalettes = true)]
public static partial class InsetRingColor
{
    /// <summary>Selects the mauve palette for the next color.</summary>
    public static ColorPaletteBuilder<InsetRingColorBuilder> Mauve => new("mauve", Token);

    /// <summary>Selects the olive palette for the next color.</summary>
    public static ColorPaletteBuilder<InsetRingColorBuilder> Olive => new("olive", Token);

    /// <summary>Selects the mist palette for the next color.</summary>
    public static ColorPaletteBuilder<InsetRingColorBuilder> Mist => new("mist", Token);

    /// <summary>Selects the taupe palette for the next color.</summary>
    public static ColorPaletteBuilder<InsetRingColorBuilder> Taupe => new("taupe", Token);

    /// <summary>Adds <c>inset-ring-primary</c>.</summary>
    public static InsetRingColorBuilder Primary => new(InsetRingColorEnum.Primary);

    /// <summary>Adds <c>inset-ring-primary-foreground</c>.</summary>
    public static InsetRingColorBuilder PrimaryForeground => new(InsetRingColorEnum.PrimaryForeground);

    /// <summary>Adds <c>inset-ring-secondary</c>.</summary>
    public static InsetRingColorBuilder Secondary => new(InsetRingColorEnum.Secondary);

    /// <summary>Adds <c>inset-ring-secondary-foreground</c>.</summary>
    public static InsetRingColorBuilder SecondaryForeground => new(InsetRingColorEnum.SecondaryForeground);

    /// <summary>Adds <c>inset-ring-destructive</c>.</summary>
    public static InsetRingColorBuilder Destructive => new(InsetRingColorEnum.Destructive);

    /// <summary>Adds <c>inset-ring-destructive-foreground</c>.</summary>
    public static InsetRingColorBuilder DestructiveForeground => new(InsetRingColorEnum.DestructiveForeground);

    /// <summary>Adds <c>inset-ring-muted</c>.</summary>
    public static InsetRingColorBuilder Muted => new(InsetRingColorEnum.Muted);

    /// <summary>Adds <c>inset-ring-muted-foreground</c>.</summary>
    public static InsetRingColorBuilder MutedForeground => new(InsetRingColorEnum.MutedForeground);

    /// <summary>Adds <c>inset-ring-accent</c>.</summary>
    public static InsetRingColorBuilder Accent => new(InsetRingColorEnum.Accent);

    /// <summary>Adds <c>inset-ring-accent-foreground</c>.</summary>
    public static InsetRingColorBuilder AccentForeground => new(InsetRingColorEnum.AccentForeground);

    /// <summary>Adds <c>inset-ring-popover</c>.</summary>
    public static InsetRingColorBuilder Popover => new(InsetRingColorEnum.Popover);

    /// <summary>Adds <c>inset-ring-popover-foreground</c>.</summary>
    public static InsetRingColorBuilder PopoverForeground => new(InsetRingColorEnum.PopoverForeground);

    /// <summary>Adds <c>inset-ring-card</c>.</summary>
    public static InsetRingColorBuilder Card => new(InsetRingColorEnum.Card);

    /// <summary>Adds <c>inset-ring-card-foreground</c>.</summary>
    public static InsetRingColorBuilder CardForeground => new(InsetRingColorEnum.CardForeground);

    /// <summary>Adds <c>inset-ring-background</c>.</summary>
    public static InsetRingColorBuilder Background => new(InsetRingColorEnum.Background);

    /// <summary>Adds <c>inset-ring-foreground</c>.</summary>
    public static InsetRingColorBuilder Foreground => new(InsetRingColorEnum.Foreground);

    /// <summary>Adds <c>inset-ring-border</c>.</summary>
    public static InsetRingColorBuilder Border => new(InsetRingColorEnum.Border);

    /// <summary>Adds <c>inset-ring-input</c>.</summary>
    public static InsetRingColorBuilder Input => new(InsetRingColorEnum.Input);

    /// <summary>Adds <c>inset-ring-ring</c>.</summary>
    public static InsetRingColorBuilder Ring => new(InsetRingColorEnum.Ring);

    /// <summary>Adds <c>inset-ring-ring/50</c>.</summary>
    public static InsetRingColorBuilder Ring50 => new(InsetRingColorEnum.Ring50);

    /// <summary>Adds <c>inset-ring-success</c>.</summary>
    public static InsetRingColorBuilder Success => new(InsetRingColorEnum.Success);

    /// <summary>Adds <c>inset-ring-warning</c>.</summary>
    public static InsetRingColorBuilder Warning => new(InsetRingColorEnum.Warning);

    /// <summary>Adds <c>inset-ring-info</c>.</summary>
    public static InsetRingColorBuilder Info => new(InsetRingColorEnum.Info);

    /// <summary>Adds <c>inset-ring-white</c>.</summary>
    public static InsetRingColorBuilder White => new(InsetRingColorEnum.White);

    /// <summary>Adds <c>inset-ring-black</c>.</summary>
    public static InsetRingColorBuilder Black => new(InsetRingColorEnum.Black);

    /// <summary>Adds <c>inset-ring-transparent</c>.</summary>
    public static InsetRingColorBuilder Transparent => new(InsetRingColorEnum.Transparent);

    /// <summary>Adds <c>inset-ring-current</c>.</summary>
    public static InsetRingColorBuilder Current => new(InsetRingColorEnum.Current);

    /// <summary>Adds <c>inset-ring-inherit</c>.</summary>
    public static InsetRingColorBuilder Inherit => new(InsetRingColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static InsetRingColorBuilder Token(string token) => new(ColorUtility.CreateClass("inset-ring-", token));

    /// <summary>Creates a utility from a complete class with the <c>inset-ring-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static InsetRingColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("inset-ring-", utility));
}
