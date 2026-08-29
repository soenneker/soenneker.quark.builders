namespace Soenneker.Quark;

/// <summary>
/// Min-width utility with fluent API. Tailwind-first (min-w-*).
/// </summary>
public static class MinWidth
{
    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static MinWidthBuilder Is0 => new("min-w-0");
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static MinWidthBuilder Is5 => new("min-w-5");
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public static MinWidthBuilder Is16 => new("min-w-16");
    /// <summary>
    /// Spacing/sizing scale step `24`.
    /// </summary>
    public static MinWidthBuilder Is24 => new("min-w-24");
    /// <summary>
    /// Spacing/sizing scale step `32`.
    /// </summary>
    public static MinWidthBuilder Is32 => new("min-w-32");
    /// <summary>
    /// Gets or sets is36.
    /// </summary>
    public static MinWidthBuilder Is36 => new("min-w-36");
    /// <summary>
    /// Spacing/sizing scale step `56`.
    /// </summary>
    public static MinWidthBuilder Is56 => new("min-w-56");
    /// <summary>
    /// Fluent step for `Is Px` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MinWidthBuilder IsPx => new("min-w-px");
    /// <summary>
    /// Fluent step for `Is Full` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MinWidthBuilder IsFull => new("min-w-full");
    /// <summary>
    /// Fluent step for `Is Min` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MinWidthBuilder IsMin => new("min-w-min");
    /// <summary>
    /// Fluent step for `Is Max` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MinWidthBuilder IsMax => new("min-w-max");
    /// <summary>
    /// Fluent step for `Is Fit` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MinWidthBuilder IsFit => new("min-w-fit");

    /// <summary>
    /// Create from an arbitrary Tailwind min-width token (e.g. "24", "[8rem]", "[12rem]").
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static MinWidthBuilder Token(string token) => new(token.StartsWith("min-w-") ? token : "min-w-" + token);
}
