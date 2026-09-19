namespace Soenneker.Quark;

/// <summary>Creates Tailwind scrollbar track color utilities from semantic colors, palettes, and arbitrary values.</summary>
[TailwindModifiers(typeof(ScrollbarTrackColorBuilder), IncludeColorPalettes = true)]
public static partial class ScrollbarTrackColor
{
    /// <summary>Adds <c>scrollbar-track-primary</c>.</summary>
    public static ScrollbarTrackColorBuilder Primary => new(ScrollbarTrackColorEnum.Primary);

    /// <summary>Adds <c>scrollbar-track-primary-foreground</c>.</summary>
    public static ScrollbarTrackColorBuilder PrimaryForeground => new(ScrollbarTrackColorEnum.PrimaryForeground);

    /// <summary>Adds <c>scrollbar-track-secondary</c>.</summary>
    public static ScrollbarTrackColorBuilder Secondary => new(ScrollbarTrackColorEnum.Secondary);

    /// <summary>Adds <c>scrollbar-track-secondary-foreground</c>.</summary>
    public static ScrollbarTrackColorBuilder SecondaryForeground => new(ScrollbarTrackColorEnum.SecondaryForeground);

    /// <summary>Adds <c>scrollbar-track-destructive</c>.</summary>
    public static ScrollbarTrackColorBuilder Destructive => new(ScrollbarTrackColorEnum.Destructive);

    /// <summary>Adds <c>scrollbar-track-destructive-foreground</c>.</summary>
    public static ScrollbarTrackColorBuilder DestructiveForeground => new(ScrollbarTrackColorEnum.DestructiveForeground);

    /// <summary>Adds <c>scrollbar-track-muted</c>.</summary>
    public static ScrollbarTrackColorBuilder Muted => new(ScrollbarTrackColorEnum.Muted);

    /// <summary>Adds <c>scrollbar-track-muted-foreground</c>.</summary>
    public static ScrollbarTrackColorBuilder MutedForeground => new(ScrollbarTrackColorEnum.MutedForeground);

    /// <summary>Adds <c>scrollbar-track-accent</c>.</summary>
    public static ScrollbarTrackColorBuilder Accent => new(ScrollbarTrackColorEnum.Accent);

    /// <summary>Adds <c>scrollbar-track-accent-foreground</c>.</summary>
    public static ScrollbarTrackColorBuilder AccentForeground => new(ScrollbarTrackColorEnum.AccentForeground);

    /// <summary>Adds <c>scrollbar-track-popover</c>.</summary>
    public static ScrollbarTrackColorBuilder Popover => new(ScrollbarTrackColorEnum.Popover);

    /// <summary>Adds <c>scrollbar-track-popover-foreground</c>.</summary>
    public static ScrollbarTrackColorBuilder PopoverForeground => new(ScrollbarTrackColorEnum.PopoverForeground);

    /// <summary>Adds <c>scrollbar-track-card</c>.</summary>
    public static ScrollbarTrackColorBuilder Card => new(ScrollbarTrackColorEnum.Card);

    /// <summary>Adds <c>scrollbar-track-card-foreground</c>.</summary>
    public static ScrollbarTrackColorBuilder CardForeground => new(ScrollbarTrackColorEnum.CardForeground);

    /// <summary>Adds <c>scrollbar-track-background</c>.</summary>
    public static ScrollbarTrackColorBuilder Background => new(ScrollbarTrackColorEnum.Background);

    /// <summary>Adds <c>scrollbar-track-foreground</c>.</summary>
    public static ScrollbarTrackColorBuilder Foreground => new(ScrollbarTrackColorEnum.Foreground);

    /// <summary>Adds <c>scrollbar-track-border</c>.</summary>
    public static ScrollbarTrackColorBuilder Border => new(ScrollbarTrackColorEnum.Border);

    /// <summary>Adds <c>scrollbar-track-input</c>.</summary>
    public static ScrollbarTrackColorBuilder Input => new(ScrollbarTrackColorEnum.Input);

    /// <summary>Adds <c>scrollbar-track-ring</c>.</summary>
    public static ScrollbarTrackColorBuilder Ring => new(ScrollbarTrackColorEnum.Ring);

    /// <summary>Adds <c>scrollbar-track-ring/50</c>.</summary>
    public static ScrollbarTrackColorBuilder Ring50 => new(ScrollbarTrackColorEnum.Ring50);

    /// <summary>Adds <c>scrollbar-track-success</c>.</summary>
    public static ScrollbarTrackColorBuilder Success => new(ScrollbarTrackColorEnum.Success);

    /// <summary>Adds <c>scrollbar-track-warning</c>.</summary>
    public static ScrollbarTrackColorBuilder Warning => new(ScrollbarTrackColorEnum.Warning);

    /// <summary>Adds <c>scrollbar-track-info</c>.</summary>
    public static ScrollbarTrackColorBuilder Info => new(ScrollbarTrackColorEnum.Info);

    /// <summary>Adds <c>scrollbar-track-white</c>.</summary>
    public static ScrollbarTrackColorBuilder White => new(ScrollbarTrackColorEnum.White);

    /// <summary>Adds <c>scrollbar-track-black</c>.</summary>
    public static ScrollbarTrackColorBuilder Black => new(ScrollbarTrackColorEnum.Black);

    /// <summary>Adds <c>scrollbar-track-transparent</c>.</summary>
    public static ScrollbarTrackColorBuilder Transparent => new(ScrollbarTrackColorEnum.Transparent);

    /// <summary>Adds <c>scrollbar-track-current</c>.</summary>
    public static ScrollbarTrackColorBuilder Current => new(ScrollbarTrackColorEnum.Current);

    /// <summary>Adds <c>scrollbar-track-inherit</c>.</summary>
    public static ScrollbarTrackColorBuilder Inherit => new(ScrollbarTrackColorEnum.Inherit);

    /// <summary>Creates a utility from a color suffix, including palette shades, opacity, or arbitrary values.</summary>
    /// <param name="token">A color suffix such as <c>red-500/50</c> or <c>[var(--brand)]</c>.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static ScrollbarTrackColorBuilder Token(string token) => new(ColorUtility.CreateClass("scrollbar-track-", token));

    /// <summary>Creates a utility from a complete class with the <c>scrollbar-track-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>A new builder containing the color utility.</returns>
    public static ScrollbarTrackColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("scrollbar-track-", utility));
}
