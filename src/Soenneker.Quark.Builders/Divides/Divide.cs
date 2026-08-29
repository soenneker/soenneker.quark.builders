namespace Soenneker.Quark;

/// <summary>
/// Represents the divide.
/// </summary>
[TailwindModifiers(typeof(DivideBuilder))]
public static partial class Divide
{
    /// <summary>
    /// Fluent step for `X` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static DivideBuilder X => new(DivideEnum.X);
    /// <summary>
    /// Fluent step for `Y` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static DivideBuilder Y => new(DivideEnum.Y);
    /// <summary>
    /// Fluent step for `XReverse` in this Tailwind/shadcn-aligned builder.
    /// </summary>
    public static DivideBuilder XReverse => new(DivideEnum.XReverse);
    /// <summary>
    /// Fluent step for `YReverse` in this Tailwind/shadcn-aligned builder.
    /// </summary>
    public static DivideBuilder YReverse => new(DivideEnum.YReverse);
    /// <summary>
    /// Fluent step for `Solid` in this Tailwind/shadcn-aligned builder.
    /// </summary>
    public static DivideBuilder Solid => new(DivideEnum.Solid);
    /// <summary>
    /// Fluent step for `Dashed` in this Tailwind/shadcn-aligned builder.
    /// </summary>
    public static DivideBuilder Dashed => new(DivideEnum.Dashed);
    /// <summary>
    /// Fluent step for `Dotted` in this Tailwind/shadcn-aligned builder.
    /// </summary>
    public static DivideBuilder Dotted => new(DivideEnum.Dotted);
    /// <summary>
    /// Fluent step for `Double` in this Tailwind/shadcn-aligned builder.
    /// </summary>
    public static DivideBuilder Double => new(DivideEnum.Double);
    /// <summary>
    /// Disables divide styling.
    /// </summary>
    public static DivideBuilder None => new(DivideEnum.None);
    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public static DivideBuilder Primary => new(DivideEnum.Primary);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public static DivideBuilder Secondary => new(DivideEnum.Secondary);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public static DivideBuilder Destructive => new(DivideEnum.Destructive);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public static DivideBuilder Muted => new(DivideEnum.Muted);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public static DivideBuilder Accent => new(DivideEnum.Accent);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public static DivideBuilder Popover => new(DivideEnum.Popover);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public static DivideBuilder Card => new(DivideEnum.Card);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public static DivideBuilder Background => new(DivideEnum.Background);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public static DivideBuilder Border => new(DivideEnum.Border);
    /// <summary>
    /// Gets or sets input.
    /// </summary>
    public static DivideBuilder Input => new(DivideEnum.Input);
    /// <summary>
    /// Gets or sets ring.
    /// </summary>
    public static DivideBuilder Ring => new(DivideEnum.Ring);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public static DivideBuilder White => new(DivideEnum.White);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public static DivideBuilder Black => new(DivideEnum.Black);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public static DivideBuilder Transparent => new(DivideEnum.Transparent);

    /// <summary>
    /// Creates a divide color utility from a Tailwind color token suffix such as <c>border</c>, <c>zinc-200</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static DivideBuilder Color(string value) => new DivideBuilder(string.Empty).Color(value);

    /// <summary>
    /// Passes through a fully-prefixed divide utility such as <c>divide-border</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static DivideBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("divide-", utility));
}
