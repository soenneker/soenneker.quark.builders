namespace Soenneker.Quark;

/// <summary>Creates Tailwind scrollbar thumb color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(ScrollbarThumbColorBuilder), IncludeColorPalettes = true)]
public static partial class ScrollbarThumbColor
{
    /// <summary>Adds <c>scrollbar-thumb-primary</c>.</summary>
    public static ScrollbarThumbColorBuilder Primary => new(ScrollbarThumbColorEnum.Primary);

    /// <summary>Adds <c>scrollbar-thumb-primary-foreground</c>.</summary>
    public static ScrollbarThumbColorBuilder PrimaryForeground => new(ScrollbarThumbColorEnum.PrimaryForeground);

    /// <summary>Adds <c>scrollbar-thumb-secondary</c>.</summary>
    public static ScrollbarThumbColorBuilder Secondary => new(ScrollbarThumbColorEnum.Secondary);

    /// <summary>Adds <c>scrollbar-thumb-secondary-foreground</c>.</summary>
    public static ScrollbarThumbColorBuilder SecondaryForeground => new(ScrollbarThumbColorEnum.SecondaryForeground);

    /// <summary>Adds <c>scrollbar-thumb-destructive</c>.</summary>
    public static ScrollbarThumbColorBuilder Destructive => new(ScrollbarThumbColorEnum.Destructive);

    /// <summary>Adds <c>scrollbar-thumb-destructive-foreground</c>.</summary>
    public static ScrollbarThumbColorBuilder DestructiveForeground => new(ScrollbarThumbColorEnum.DestructiveForeground);

    /// <summary>Adds <c>scrollbar-thumb-muted</c>.</summary>
    public static ScrollbarThumbColorBuilder Muted => new(ScrollbarThumbColorEnum.Muted);

    /// <summary>Adds <c>scrollbar-thumb-muted-foreground</c>.</summary>
    public static ScrollbarThumbColorBuilder MutedForeground => new(ScrollbarThumbColorEnum.MutedForeground);

    /// <summary>Adds <c>scrollbar-thumb-accent</c>.</summary>
    public static ScrollbarThumbColorBuilder Accent => new(ScrollbarThumbColorEnum.Accent);

    /// <summary>Adds <c>scrollbar-thumb-accent-foreground</c>.</summary>
    public static ScrollbarThumbColorBuilder AccentForeground => new(ScrollbarThumbColorEnum.AccentForeground);

    /// <summary>Adds <c>scrollbar-thumb-popover</c>.</summary>
    public static ScrollbarThumbColorBuilder Popover => new(ScrollbarThumbColorEnum.Popover);

    /// <summary>Adds <c>scrollbar-thumb-popover-foreground</c>.</summary>
    public static ScrollbarThumbColorBuilder PopoverForeground => new(ScrollbarThumbColorEnum.PopoverForeground);

    /// <summary>Adds <c>scrollbar-thumb-card</c>.</summary>
    public static ScrollbarThumbColorBuilder Card => new(ScrollbarThumbColorEnum.Card);

    /// <summary>Adds <c>scrollbar-thumb-card-foreground</c>.</summary>
    public static ScrollbarThumbColorBuilder CardForeground => new(ScrollbarThumbColorEnum.CardForeground);

    /// <summary>Adds <c>scrollbar-thumb-background</c>.</summary>
    public static ScrollbarThumbColorBuilder Background => new(ScrollbarThumbColorEnum.Background);

    /// <summary>Adds <c>scrollbar-thumb-foreground</c>.</summary>
    public static ScrollbarThumbColorBuilder Foreground => new(ScrollbarThumbColorEnum.Foreground);

    /// <summary>Adds <c>scrollbar-thumb-border</c>.</summary>
    public static ScrollbarThumbColorBuilder Border => new(ScrollbarThumbColorEnum.Border);

    /// <summary>Adds <c>scrollbar-thumb-input</c>.</summary>
    public static ScrollbarThumbColorBuilder Input => new(ScrollbarThumbColorEnum.Input);

    /// <summary>Adds <c>scrollbar-thumb-ring</c>.</summary>
    public static ScrollbarThumbColorBuilder Ring => new(ScrollbarThumbColorEnum.Ring);

    /// <summary>Adds <c>scrollbar-thumb-ring/50</c>.</summary>
    public static ScrollbarThumbColorBuilder Ring50 => new(ScrollbarThumbColorEnum.Ring50);

    /// <summary>Adds <c>scrollbar-thumb-success</c>.</summary>
    public static ScrollbarThumbColorBuilder Success => new(ScrollbarThumbColorEnum.Success);

    /// <summary>Adds <c>scrollbar-thumb-warning</c>.</summary>
    public static ScrollbarThumbColorBuilder Warning => new(ScrollbarThumbColorEnum.Warning);

    /// <summary>Adds <c>scrollbar-thumb-info</c>.</summary>
    public static ScrollbarThumbColorBuilder Info => new(ScrollbarThumbColorEnum.Info);

    /// <summary>Adds <c>scrollbar-thumb-white</c>.</summary>
    public static ScrollbarThumbColorBuilder White => new(ScrollbarThumbColorEnum.White);

    /// <summary>Adds <c>scrollbar-thumb-black</c>.</summary>
    public static ScrollbarThumbColorBuilder Black => new(ScrollbarThumbColorEnum.Black);

    /// <summary>Adds <c>scrollbar-thumb-transparent</c>.</summary>
    public static ScrollbarThumbColorBuilder Transparent => new(ScrollbarThumbColorEnum.Transparent);

    /// <summary>Adds <c>scrollbar-thumb-current</c>.</summary>
    public static ScrollbarThumbColorBuilder Current => new(ScrollbarThumbColorEnum.Current);

    /// <summary>Adds <c>scrollbar-thumb-inherit</c>.</summary>
    public static ScrollbarThumbColorBuilder Inherit => new(ScrollbarThumbColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static ScrollbarThumbColorBuilder Token(string token) => new(ColorUtility.CreateClass("scrollbar-thumb-", token));

    /// <summary>Creates a utility from a complete class with the <c>scrollbar-thumb-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static ScrollbarThumbColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("scrollbar-thumb-", utility));
}
