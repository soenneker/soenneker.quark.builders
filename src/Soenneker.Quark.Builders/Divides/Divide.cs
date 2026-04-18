namespace Soenneker.Quark;

public static class Divide
{
    /// <summary>
    /// Fluent step for `X` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static DivideBuilder X => new(DivideEnum.X);
    /// <summary>
    /// Fluent step for `Y` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static DivideBuilder Y => new(DivideEnum.Y);
    public static DivideBuilder Color(string value) => new($"divide-{value}");
}
