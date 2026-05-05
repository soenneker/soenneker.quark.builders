namespace Soenneker.Quark;

/// <summary>
/// Height utility with fluent API and Tailwind-first mappings.
/// </summary>
public static class Height
{
    /// <summary>
    /// Spacing/sizing scale step `25` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 25` for integer spacing utilities unless overridden).
    /// </summary>
    public static HeightBuilder Is25 => new("h-1/4");
    /// <summary>
    /// Spacing/sizing scale step `50` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 50` for integer spacing utilities unless overridden).
    /// </summary>
    public static HeightBuilder Is50 => new("h-1/2");
    /// <summary>
    /// Spacing/sizing scale step `75` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 75` for integer spacing utilities unless overridden).
    /// </summary>
    public static HeightBuilder Is75 => new("h-3/4");
    /// <summary>
    /// Spacing/sizing scale step `100` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 100` for integer spacing utilities unless overridden).
    /// </summary>
    public static HeightBuilder Is100 => new("h-full");

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static HeightBuilder Is0 => new("h-0");
    /// <summary>
    /// Spacing/sizing scale step `1`.
    /// </summary>
    public static HeightBuilder Is1 => new("h-1");
    /// <summary>
    /// Spacing/sizing scale step `2`.
    /// </summary>
    public static HeightBuilder Is2 => new("h-2");
    /// <summary>
    /// Spacing/sizing scale step `3`.
    /// </summary>
    public static HeightBuilder Is3 => new("h-3");
    /// <summary>
    /// Spacing/sizing scale step `4`.
    /// </summary>
    public static HeightBuilder Is4 => new("h-4");
    /// <summary>
    /// Spacing/sizing scale step `5`.
    /// </summary>
    public static HeightBuilder Is5 => new("h-5");
    /// <summary>
    /// Spacing/sizing scale step `6`.
    /// </summary>
    public static HeightBuilder Is6 => new("h-6");
    /// <summary>
    /// Spacing/sizing scale step `7`.
    /// </summary>
    public static HeightBuilder Is7 => new("h-7");
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public static HeightBuilder Is8 => new("h-8");
    /// <summary>
    /// Spacing/sizing scale step `9`.
    /// </summary>
    public static HeightBuilder Is9 => new("h-9");
    /// <summary>
    /// Spacing/sizing scale step `10`.
    /// </summary>
    public static HeightBuilder Is10 => new("h-10");
    /// <summary>
    /// Spacing/sizing scale step `11`.
    /// </summary>
    public static HeightBuilder Is11 => new("h-11");
    /// <summary>
    /// Spacing/sizing scale step `12`.
    /// </summary>
    public static HeightBuilder Is12 => new("h-12");
    /// <summary>
    /// Spacing/sizing scale step `14`.
    /// </summary>
    public static HeightBuilder Is14 => new("h-14");
    /// <summary>
    /// Spacing/sizing scale step `16` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 16` for integer spacing utilities unless overridden).
    /// </summary>
    public static HeightBuilder Is16 => new("h-16");
    /// <summary>
    /// Spacing/sizing scale step `20`.
    /// </summary>
    public static HeightBuilder Is20 => new("h-20");
    /// <summary>
    /// Spacing/sizing scale step `24`.
    /// </summary>
    public static HeightBuilder Is24 => new("h-24");
    /// <summary>
    /// Spacing/sizing scale step `32`.
    /// </summary>
    public static HeightBuilder Is32 => new("h-32");
    /// <summary>
    /// Spacing/sizing scale step `36`.
    /// </summary>
    public static HeightBuilder Is36 => new("h-36");
    /// <summary>
    /// Spacing/sizing scale step `40`.
    /// </summary>
    public static HeightBuilder Is40 => new("h-40");
    /// <summary>
    /// Spacing/sizing scale step `44`.
    /// </summary>
    public static HeightBuilder Is44 => new("h-44");
    /// <summary>
    /// Spacing/sizing scale step `48`.
    /// </summary>
    public static HeightBuilder Is48 => new("h-48");
    /// <summary>
    /// Spacing/sizing scale step `52`.
    /// </summary>
    public static HeightBuilder Is52 => new("h-52");
    /// <summary>
    /// Spacing/sizing scale step `56`.
    /// </summary>
    public static HeightBuilder Is56 => new("h-56");
    /// <summary>
    /// Spacing/sizing scale step `60`.
    /// </summary>
    public static HeightBuilder Is60 => new("h-60");
    /// <summary>
    /// Spacing/sizing scale step `64`.
    /// </summary>
    public static HeightBuilder Is64 => new("h-64");
    /// <summary>
    /// Spacing/sizing scale step `72`.
    /// </summary>
    public static HeightBuilder Is72 => new("h-72");
    /// <summary>
    /// Spacing/sizing scale step `80`.
    /// </summary>
    public static HeightBuilder Is80 => new("h-80");
    /// <summary>
    /// Spacing/sizing scale step `96`.
    /// </summary>
    public static HeightBuilder Is96 => new("h-96");
    /// <summary>
    /// Fluent step for `Is Px` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder IsPx => new("h-px");
    /// <summary>
    /// Fluent step for `Is Full` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder IsFull => new("h-full");
    /// <summary>
    /// Fluent step for `Is Screen` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder IsScreen => new("h-screen");
    /// <summary>
    /// Fluent step for `Is Fit` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder IsFit => new("h-fit");
    /// <summary>
    /// Fluent step for `Is Min` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder IsMin => new("h-min");
    /// <summary>
    /// Fluent step for `Is Max` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder IsMax => new("h-max");

    /// <summary>
    /// Fluent step for `Is1of2` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder Is1of2 => new("h-1/2");
    /// <summary>
    /// Fluent step for `Is1of3` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder Is1of3 => new("h-1/3");
    /// <summary>
    /// Fluent step for `Is2of3` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder Is2of3 => new("h-2/3");
    /// <summary>
    /// Fluent step for `Is1of4` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder Is1of4 => new("h-1/4");
    /// <summary>
    /// Fluent step for `Is3of4` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static HeightBuilder Is3of4 => new("h-3/4");

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static HeightBuilder Auto => new("h-auto");

    /// <summary>
    /// Create from an arbitrary Tailwind height token (e.g. "72", "[18rem]", "full").
    /// </summary>
    public static HeightBuilder Token(string token) => new(token.StartsWith("h-") ? token : "h-" + token);
}
