namespace Soenneker.Quark;

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
    public static DivideBuilder Primary => new(DivideEnum.Primary);
    public static DivideBuilder Secondary => new(DivideEnum.Secondary);
    public static DivideBuilder Destructive => new(DivideEnum.Destructive);
    public static DivideBuilder Muted => new(DivideEnum.Muted);
    public static DivideBuilder Accent => new(DivideEnum.Accent);
    public static DivideBuilder Popover => new(DivideEnum.Popover);
    public static DivideBuilder Card => new(DivideEnum.Card);
    public static DivideBuilder Background => new(DivideEnum.Background);
    public static DivideBuilder Border => new(DivideEnum.Border);
    public static DivideBuilder Input => new(DivideEnum.Input);
    public static DivideBuilder Ring => new(DivideEnum.Ring);
    public static DivideBuilder White => new(DivideEnum.White);
    public static DivideBuilder Black => new(DivideEnum.Black);
    public static DivideBuilder Transparent => new(DivideEnum.Transparent);

    /// <summary>
    /// Creates a divide color utility from a Tailwind color token suffix such as <c>border</c>, <c>zinc-200</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    public static DivideBuilder Color(string value) => new DivideBuilder(string.Empty).Color(value);

    /// <summary>
    /// Passes through a fully-prefixed divide utility such as <c>divide-border</c>.
    /// </summary>
    public static DivideBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("divide-", utility));
}
