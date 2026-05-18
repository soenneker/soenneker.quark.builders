namespace Soenneker.Quark;

/// <summary>
/// Ring color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
[TailwindModifiers(typeof(RingColorBuilder), IncludeColorPalettes = true)]
public static partial class RingColor
{
    /// <summary>
    /// Fluent step for `Primary` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Primary => new(RingColorEnum.Primary);
    /// <summary>
    /// Fluent step for `Primary Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder PrimaryForeground => new(RingColorEnum.PrimaryForeground);
    /// <summary>
    /// Fluent step for `Secondary` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Secondary => new(RingColorEnum.Secondary);
    /// <summary>
    /// Fluent step for `Secondary Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder SecondaryForeground => new(RingColorEnum.SecondaryForeground);
    /// <summary>
    /// Fluent step for `Destructive` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Destructive => new(RingColorEnum.Destructive);
    /// <summary>
    /// Fluent step for `Destructive Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder DestructiveForeground => new(RingColorEnum.DestructiveForeground);
    /// <summary>
    /// Fluent step for `Muted` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Muted => new(RingColorEnum.Muted);
    /// <summary>
    /// Fluent step for `Muted Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder MutedForeground => new(RingColorEnum.MutedForeground);
    /// <summary>
    /// Fluent step for `Accent` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Accent => new(RingColorEnum.Accent);
    /// <summary>
    /// Fluent step for `Accent Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder AccentForeground => new(RingColorEnum.AccentForeground);
    /// <summary>
    /// Fluent step for `Popover` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Popover => new(RingColorEnum.Popover);
    /// <summary>
    /// Fluent step for `Popover Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder PopoverForeground => new(RingColorEnum.PopoverForeground);
    /// <summary>
    /// Fluent step for `Card` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Card => new(RingColorEnum.Card);
    /// <summary>
    /// Fluent step for `Card Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder CardForeground => new(RingColorEnum.CardForeground);
    /// <summary>
    /// Fluent step for `Background` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Background => new(RingColorEnum.Background);
    /// <summary>
    /// Fluent step for `Foreground` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Foreground => new(RingColorEnum.Foreground);
    /// <summary>
    /// Fluent step for `Border` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Border => new(RingColorEnum.Border);
    /// <summary>
    /// Fluent step for `Input` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Input => new(RingColorEnum.Input);
    /// <summary>
    /// Fluent step for `Ring` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Ring => new(RingColorEnum.Ring);
    public static RingColorBuilder Ring50 => new(RingColorEnum.Ring50);
    /// <summary>
    /// Fluent step for `Success` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Success => new(RingColorEnum.Success);
    /// <summary>
    /// Fluent step for `Warning` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Warning => new(RingColorEnum.Warning);
    /// <summary>
    /// Fluent step for `Info` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Info => new(RingColorEnum.Info);
    /// <summary>
    /// Fluent step for `White` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder White => new(RingColorEnum.White);
    /// <summary>
    /// Fluent step for `Black` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingColorBuilder Black => new(RingColorEnum.Black);

    /// <summary>
    /// Creates a ring color builder from a Tailwind color token suffix such as <c>foreground/10</c>, <c>zinc-900</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    public static RingColorBuilder Token(string token) => new(ColorUtility.CreateClass("ring-", token));

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>ring-foreground/10</c>.
    /// </summary>
    public static RingColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("ring-", utility));
}
