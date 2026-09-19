namespace Soenneker.Quark;

/// <summary>Creates Tailwind shadow color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(ShadowColorBuilder), IncludeColorPalettes = true)]
public static partial class ShadowColor
{
    /// <summary>Adds <c>shadow-primary</c>.</summary>
    public static ShadowColorBuilder Primary => new(ShadowColorEnum.Primary);

    /// <summary>Adds <c>shadow-primary-foreground</c>.</summary>
    public static ShadowColorBuilder PrimaryForeground => new(ShadowColorEnum.PrimaryForeground);

    /// <summary>Adds <c>shadow-secondary</c>.</summary>
    public static ShadowColorBuilder Secondary => new(ShadowColorEnum.Secondary);

    /// <summary>Adds <c>shadow-secondary-foreground</c>.</summary>
    public static ShadowColorBuilder SecondaryForeground => new(ShadowColorEnum.SecondaryForeground);

    /// <summary>Adds <c>shadow-destructive</c>.</summary>
    public static ShadowColorBuilder Destructive => new(ShadowColorEnum.Destructive);

    /// <summary>Adds <c>shadow-destructive-foreground</c>.</summary>
    public static ShadowColorBuilder DestructiveForeground => new(ShadowColorEnum.DestructiveForeground);

    /// <summary>Adds <c>shadow-muted</c>.</summary>
    public static ShadowColorBuilder Muted => new(ShadowColorEnum.Muted);

    /// <summary>Adds <c>shadow-muted-foreground</c>.</summary>
    public static ShadowColorBuilder MutedForeground => new(ShadowColorEnum.MutedForeground);

    /// <summary>Adds <c>shadow-accent</c>.</summary>
    public static ShadowColorBuilder Accent => new(ShadowColorEnum.Accent);

    /// <summary>Adds <c>shadow-accent-foreground</c>.</summary>
    public static ShadowColorBuilder AccentForeground => new(ShadowColorEnum.AccentForeground);

    /// <summary>Adds <c>shadow-popover</c>.</summary>
    public static ShadowColorBuilder Popover => new(ShadowColorEnum.Popover);

    /// <summary>Adds <c>shadow-popover-foreground</c>.</summary>
    public static ShadowColorBuilder PopoverForeground => new(ShadowColorEnum.PopoverForeground);

    /// <summary>Adds <c>shadow-card</c>.</summary>
    public static ShadowColorBuilder Card => new(ShadowColorEnum.Card);

    /// <summary>Adds <c>shadow-card-foreground</c>.</summary>
    public static ShadowColorBuilder CardForeground => new(ShadowColorEnum.CardForeground);

    /// <summary>Adds <c>shadow-background</c>.</summary>
    public static ShadowColorBuilder Background => new(ShadowColorEnum.Background);

    /// <summary>Adds <c>shadow-foreground</c>.</summary>
    public static ShadowColorBuilder Foreground => new(ShadowColorEnum.Foreground);

    /// <summary>Adds <c>shadow-border</c>.</summary>
    public static ShadowColorBuilder Border => new(ShadowColorEnum.Border);

    /// <summary>Adds <c>shadow-input</c>.</summary>
    public static ShadowColorBuilder Input => new(ShadowColorEnum.Input);

    /// <summary>Adds <c>shadow-ring</c>.</summary>
    public static ShadowColorBuilder Ring => new(ShadowColorEnum.Ring);

    /// <summary>Adds <c>shadow-ring/50</c>.</summary>
    public static ShadowColorBuilder Ring50 => new(ShadowColorEnum.Ring50);

    /// <summary>Adds <c>shadow-success</c>.</summary>
    public static ShadowColorBuilder Success => new(ShadowColorEnum.Success);

    /// <summary>Adds <c>shadow-warning</c>.</summary>
    public static ShadowColorBuilder Warning => new(ShadowColorEnum.Warning);

    /// <summary>Adds <c>shadow-info</c>.</summary>
    public static ShadowColorBuilder Info => new(ShadowColorEnum.Info);

    /// <summary>Adds <c>shadow-white</c>.</summary>
    public static ShadowColorBuilder White => new(ShadowColorEnum.White);

    /// <summary>Adds <c>shadow-black</c>.</summary>
    public static ShadowColorBuilder Black => new(ShadowColorEnum.Black);

    /// <summary>Adds <c>shadow-transparent</c>.</summary>
    public static ShadowColorBuilder Transparent => new(ShadowColorEnum.Transparent);

    /// <summary>Adds <c>shadow-current</c>.</summary>
    public static ShadowColorBuilder Current => new(ShadowColorEnum.Current);

    /// <summary>Adds <c>shadow-inherit</c>.</summary>
    public static ShadowColorBuilder Inherit => new(ShadowColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static ShadowColorBuilder Token(string token) => new(ColorUtility.CreateClass("shadow-", token));

    /// <summary>Creates a utility from a complete class with the <c>shadow-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static ShadowColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("shadow-", utility));
}
