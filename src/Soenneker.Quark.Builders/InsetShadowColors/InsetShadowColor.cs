namespace Soenneker.Quark;

/// <summary>Creates Tailwind inset shadow color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(InsetShadowColorBuilder), IncludeColorPalettes = true)]
public static partial class InsetShadowColor
{
    /// <summary>Selects the mauve palette for the next color.</summary>
    public static ColorPaletteBuilder<InsetShadowColorBuilder> Mauve => new("mauve", Token);

    /// <summary>Selects the olive palette for the next color.</summary>
    public static ColorPaletteBuilder<InsetShadowColorBuilder> Olive => new("olive", Token);

    /// <summary>Selects the mist palette for the next color.</summary>
    public static ColorPaletteBuilder<InsetShadowColorBuilder> Mist => new("mist", Token);

    /// <summary>Selects the taupe palette for the next color.</summary>
    public static ColorPaletteBuilder<InsetShadowColorBuilder> Taupe => new("taupe", Token);

    /// <summary>Adds <c>inset-shadow-primary</c>.</summary>
    public static InsetShadowColorBuilder Primary => new(InsetShadowColorEnum.Primary);

    /// <summary>Adds <c>inset-shadow-primary-foreground</c>.</summary>
    public static InsetShadowColorBuilder PrimaryForeground => new(InsetShadowColorEnum.PrimaryForeground);

    /// <summary>Adds <c>inset-shadow-secondary</c>.</summary>
    public static InsetShadowColorBuilder Secondary => new(InsetShadowColorEnum.Secondary);

    /// <summary>Adds <c>inset-shadow-secondary-foreground</c>.</summary>
    public static InsetShadowColorBuilder SecondaryForeground => new(InsetShadowColorEnum.SecondaryForeground);

    /// <summary>Adds <c>inset-shadow-destructive</c>.</summary>
    public static InsetShadowColorBuilder Destructive => new(InsetShadowColorEnum.Destructive);

    /// <summary>Adds <c>inset-shadow-destructive-foreground</c>.</summary>
    public static InsetShadowColorBuilder DestructiveForeground => new(InsetShadowColorEnum.DestructiveForeground);

    /// <summary>Adds <c>inset-shadow-muted</c>.</summary>
    public static InsetShadowColorBuilder Muted => new(InsetShadowColorEnum.Muted);

    /// <summary>Adds <c>inset-shadow-muted-foreground</c>.</summary>
    public static InsetShadowColorBuilder MutedForeground => new(InsetShadowColorEnum.MutedForeground);

    /// <summary>Adds <c>inset-shadow-accent</c>.</summary>
    public static InsetShadowColorBuilder Accent => new(InsetShadowColorEnum.Accent);

    /// <summary>Adds <c>inset-shadow-accent-foreground</c>.</summary>
    public static InsetShadowColorBuilder AccentForeground => new(InsetShadowColorEnum.AccentForeground);

    /// <summary>Adds <c>inset-shadow-popover</c>.</summary>
    public static InsetShadowColorBuilder Popover => new(InsetShadowColorEnum.Popover);

    /// <summary>Adds <c>inset-shadow-popover-foreground</c>.</summary>
    public static InsetShadowColorBuilder PopoverForeground => new(InsetShadowColorEnum.PopoverForeground);

    /// <summary>Adds <c>inset-shadow-card</c>.</summary>
    public static InsetShadowColorBuilder Card => new(InsetShadowColorEnum.Card);

    /// <summary>Adds <c>inset-shadow-card-foreground</c>.</summary>
    public static InsetShadowColorBuilder CardForeground => new(InsetShadowColorEnum.CardForeground);

    /// <summary>Adds <c>inset-shadow-background</c>.</summary>
    public static InsetShadowColorBuilder Background => new(InsetShadowColorEnum.Background);

    /// <summary>Adds <c>inset-shadow-foreground</c>.</summary>
    public static InsetShadowColorBuilder Foreground => new(InsetShadowColorEnum.Foreground);

    /// <summary>Adds <c>inset-shadow-border</c>.</summary>
    public static InsetShadowColorBuilder Border => new(InsetShadowColorEnum.Border);

    /// <summary>Adds <c>inset-shadow-input</c>.</summary>
    public static InsetShadowColorBuilder Input => new(InsetShadowColorEnum.Input);

    /// <summary>Adds <c>inset-shadow-ring</c>.</summary>
    public static InsetShadowColorBuilder Ring => new(InsetShadowColorEnum.Ring);

    /// <summary>Adds <c>inset-shadow-ring/50</c>.</summary>
    public static InsetShadowColorBuilder Ring50 => new(InsetShadowColorEnum.Ring50);

    /// <summary>Adds <c>inset-shadow-success</c>.</summary>
    public static InsetShadowColorBuilder Success => new(InsetShadowColorEnum.Success);

    /// <summary>Adds <c>inset-shadow-warning</c>.</summary>
    public static InsetShadowColorBuilder Warning => new(InsetShadowColorEnum.Warning);

    /// <summary>Adds <c>inset-shadow-info</c>.</summary>
    public static InsetShadowColorBuilder Info => new(InsetShadowColorEnum.Info);

    /// <summary>Adds <c>inset-shadow-white</c>.</summary>
    public static InsetShadowColorBuilder White => new(InsetShadowColorEnum.White);

    /// <summary>Adds <c>inset-shadow-black</c>.</summary>
    public static InsetShadowColorBuilder Black => new(InsetShadowColorEnum.Black);

    /// <summary>Adds <c>inset-shadow-transparent</c>.</summary>
    public static InsetShadowColorBuilder Transparent => new(InsetShadowColorEnum.Transparent);

    /// <summary>Adds <c>inset-shadow-current</c>.</summary>
    public static InsetShadowColorBuilder Current => new(InsetShadowColorEnum.Current);

    /// <summary>Adds <c>inset-shadow-inherit</c>.</summary>
    public static InsetShadowColorBuilder Inherit => new(InsetShadowColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static InsetShadowColorBuilder Token(string token) => new(ColorUtility.CreateClass("inset-shadow-", token));

    /// <summary>Creates a utility from a complete class with the <c>inset-shadow-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static InsetShadowColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("inset-shadow-", utility));
}
