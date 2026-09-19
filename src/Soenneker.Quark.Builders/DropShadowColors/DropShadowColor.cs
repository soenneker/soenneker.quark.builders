namespace Soenneker.Quark;

/// <summary>Creates Tailwind drop shadow color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(DropShadowColorBuilder), IncludeColorPalettes = true)]
public static partial class DropShadowColor
{
    /// <summary>Adds <c>drop-shadow-primary</c>.</summary>
    public static DropShadowColorBuilder Primary => new(DropShadowColorEnum.Primary);

    /// <summary>Adds <c>drop-shadow-primary-foreground</c>.</summary>
    public static DropShadowColorBuilder PrimaryForeground => new(DropShadowColorEnum.PrimaryForeground);

    /// <summary>Adds <c>drop-shadow-secondary</c>.</summary>
    public static DropShadowColorBuilder Secondary => new(DropShadowColorEnum.Secondary);

    /// <summary>Adds <c>drop-shadow-secondary-foreground</c>.</summary>
    public static DropShadowColorBuilder SecondaryForeground => new(DropShadowColorEnum.SecondaryForeground);

    /// <summary>Adds <c>drop-shadow-destructive</c>.</summary>
    public static DropShadowColorBuilder Destructive => new(DropShadowColorEnum.Destructive);

    /// <summary>Adds <c>drop-shadow-destructive-foreground</c>.</summary>
    public static DropShadowColorBuilder DestructiveForeground => new(DropShadowColorEnum.DestructiveForeground);

    /// <summary>Adds <c>drop-shadow-muted</c>.</summary>
    public static DropShadowColorBuilder Muted => new(DropShadowColorEnum.Muted);

    /// <summary>Adds <c>drop-shadow-muted-foreground</c>.</summary>
    public static DropShadowColorBuilder MutedForeground => new(DropShadowColorEnum.MutedForeground);

    /// <summary>Adds <c>drop-shadow-accent</c>.</summary>
    public static DropShadowColorBuilder Accent => new(DropShadowColorEnum.Accent);

    /// <summary>Adds <c>drop-shadow-accent-foreground</c>.</summary>
    public static DropShadowColorBuilder AccentForeground => new(DropShadowColorEnum.AccentForeground);

    /// <summary>Adds <c>drop-shadow-popover</c>.</summary>
    public static DropShadowColorBuilder Popover => new(DropShadowColorEnum.Popover);

    /// <summary>Adds <c>drop-shadow-popover-foreground</c>.</summary>
    public static DropShadowColorBuilder PopoverForeground => new(DropShadowColorEnum.PopoverForeground);

    /// <summary>Adds <c>drop-shadow-card</c>.</summary>
    public static DropShadowColorBuilder Card => new(DropShadowColorEnum.Card);

    /// <summary>Adds <c>drop-shadow-card-foreground</c>.</summary>
    public static DropShadowColorBuilder CardForeground => new(DropShadowColorEnum.CardForeground);

    /// <summary>Adds <c>drop-shadow-background</c>.</summary>
    public static DropShadowColorBuilder Background => new(DropShadowColorEnum.Background);

    /// <summary>Adds <c>drop-shadow-foreground</c>.</summary>
    public static DropShadowColorBuilder Foreground => new(DropShadowColorEnum.Foreground);

    /// <summary>Adds <c>drop-shadow-border</c>.</summary>
    public static DropShadowColorBuilder Border => new(DropShadowColorEnum.Border);

    /// <summary>Adds <c>drop-shadow-input</c>.</summary>
    public static DropShadowColorBuilder Input => new(DropShadowColorEnum.Input);

    /// <summary>Adds <c>drop-shadow-ring</c>.</summary>
    public static DropShadowColorBuilder Ring => new(DropShadowColorEnum.Ring);

    /// <summary>Adds <c>drop-shadow-ring/50</c>.</summary>
    public static DropShadowColorBuilder Ring50 => new(DropShadowColorEnum.Ring50);

    /// <summary>Adds <c>drop-shadow-success</c>.</summary>
    public static DropShadowColorBuilder Success => new(DropShadowColorEnum.Success);

    /// <summary>Adds <c>drop-shadow-warning</c>.</summary>
    public static DropShadowColorBuilder Warning => new(DropShadowColorEnum.Warning);

    /// <summary>Adds <c>drop-shadow-info</c>.</summary>
    public static DropShadowColorBuilder Info => new(DropShadowColorEnum.Info);

    /// <summary>Adds <c>drop-shadow-white</c>.</summary>
    public static DropShadowColorBuilder White => new(DropShadowColorEnum.White);

    /// <summary>Adds <c>drop-shadow-black</c>.</summary>
    public static DropShadowColorBuilder Black => new(DropShadowColorEnum.Black);

    /// <summary>Adds <c>drop-shadow-transparent</c>.</summary>
    public static DropShadowColorBuilder Transparent => new(DropShadowColorEnum.Transparent);

    /// <summary>Adds <c>drop-shadow-current</c>.</summary>
    public static DropShadowColorBuilder Current => new(DropShadowColorEnum.Current);

    /// <summary>Adds <c>drop-shadow-inherit</c>.</summary>
    public static DropShadowColorBuilder Inherit => new(DropShadowColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static DropShadowColorBuilder Token(string token) => new(ColorUtility.CreateClass("drop-shadow-", token));

    /// <summary>Creates a utility from a complete class with the <c>drop-shadow-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static DropShadowColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("drop-shadow-", utility));
}
