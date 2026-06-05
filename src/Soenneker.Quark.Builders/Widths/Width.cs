namespace Soenneker.Quark;

/// <summary>
/// Width utility with fluent API and Tailwind-first mappings.
/// </summary>
[TailwindModifiers(typeof(WidthBuilder))]
public static partial class Width
{
    /// <summary>
    /// <c>w-25</c> — width from the same spacing scale as padding/margin (<c>25</c> → <c>6.25rem</c> in Tailwind’s default theme).
    /// </summary>
    public static WidthBuilder Is25 => new("w-1/4");
    /// <summary>
    /// <c>w-50</c> — spacing scale step <c>50</c> (<c>12.5rem</c> by default).
    /// </summary>
    public static WidthBuilder Is50 => new("w-1/2");
    /// <summary>
    /// <c>w-75</c> — spacing scale step <c>75</c> (<c>18.75rem</c> by default).
    /// </summary>
    public static WidthBuilder Is75 => new("w-3/4");
    /// <summary>
    /// <c>w-100</c> — spacing scale step <c>100</c> (<c>25rem</c> by default).
    /// </summary>
    public static WidthBuilder Is100 => new("w-full");

    /// <summary>
    /// <c>w-0</c> — <c>width: 0px</c>.
    /// </summary>
    public static WidthBuilder Is0 => new("w-0");
    /// <summary>
    /// Gets or sets is0 5.
    /// </summary>
    public static WidthBuilder Is0_5 => new("w-0.5");
    /// <summary>
    /// Spacing/sizing scale step `1`.
    /// </summary>
    public static WidthBuilder Is1 => new("w-1");
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public static WidthBuilder Is1_5 => new("w-1.5");
    /// <summary>
    /// Spacing/sizing scale step `2`.
    /// </summary>
    public static WidthBuilder Is2 => new("w-2");
    /// <summary>
    /// Spacing/sizing scale step `3`.
    /// </summary>
    public static WidthBuilder Is3 => new("w-3");
    /// <summary>
    /// Spacing/sizing scale step `4`.
    /// </summary>
    public static WidthBuilder Is4 => new("w-4");
    /// <summary>
    /// Spacing/sizing scale step `5`.
    /// </summary>
    public static WidthBuilder Is5 => new("w-5");
    /// <summary>
    /// Spacing/sizing scale step `6`.
    /// </summary>
    public static WidthBuilder Is6 => new("w-6");
    /// <summary>
    /// Spacing/sizing scale step `7`.
    /// </summary>
    public static WidthBuilder Is7 => new("w-7");
    /// <summary>
    /// Spacing/sizing scale step `8`.
    /// </summary>
    public static WidthBuilder Is8 => new("w-8");
    /// <summary>
    /// Spacing/sizing scale step `9`.
    /// </summary>
    public static WidthBuilder Is9 => new("w-9");
    /// <summary>
    /// Spacing/sizing scale step `10`.
    /// </summary>
    public static WidthBuilder Is10 => new("w-10");
    /// <summary>
    /// Spacing/sizing scale step `11`.
    /// </summary>
    public static WidthBuilder Is11 => new("w-11");
    /// <summary>
    /// Spacing/sizing scale step `12`.
    /// </summary>
    public static WidthBuilder Is12 => new("w-12");
    /// <summary>
    /// Spacing/sizing scale step `14`.
    /// </summary>
    public static WidthBuilder Is14 => new("w-14");
    /// <summary>
    /// Spacing/sizing scale step `16`.
    /// </summary>
    public static WidthBuilder Is16 => new("w-16");
    /// <summary>
    /// Spacing/sizing scale step `20`.
    /// </summary>
    public static WidthBuilder Is20 => new("w-20");
    /// <summary>
    /// Spacing/sizing scale step `24`.
    /// </summary>
    public static WidthBuilder Is24 => new("w-24");
    /// <summary>
    /// Spacing/sizing scale step `32`.
    /// </summary>
    public static WidthBuilder Is32 => new("w-32");
    /// <summary>
    /// Spacing/sizing scale step `36`.
    /// </summary>
    public static WidthBuilder Is36 => new("w-36");
    /// <summary>
    /// Spacing/sizing scale step `40`.
    /// </summary>
    public static WidthBuilder Is40 => new("w-40");
    /// <summary>
    /// Spacing/sizing scale step `44`.
    /// </summary>
    public static WidthBuilder Is44 => new("w-44");
    /// <summary>
    /// Spacing/sizing scale step `48`.
    /// </summary>
    public static WidthBuilder Is48 => new("w-48");
    /// <summary>
    /// Spacing/sizing scale step `52`.
    /// </summary>
    public static WidthBuilder Is52 => new("w-52");
    /// <summary>
    /// Spacing/sizing scale step `56`.
    /// </summary>
    public static WidthBuilder Is56 => new("w-56");
    /// <summary>
    /// Spacing/sizing scale step `60`.
    /// </summary>
    public static WidthBuilder Is60 => new("w-60");
    /// <summary>
    /// Spacing/sizing scale step `64`.
    /// </summary>
    public static WidthBuilder Is64 => new("w-64");
    /// <summary>
    /// Spacing/sizing scale step `72`.
    /// </summary>
    public static WidthBuilder Is72 => new("w-72");
    /// <summary>
    /// Spacing/sizing scale step `80`.
    /// </summary>
    public static WidthBuilder Is80 => new("w-80");
    /// <summary>
    /// Spacing/sizing scale step `96`.
    /// </summary>
    public static WidthBuilder Is96 => new("w-96");
    /// <summary>
    /// <c>w-px</c> — fixed <c>1px</c> width (hairline columns/dividers).
    /// </summary>
    public static WidthBuilder IsPx => new("w-px");
    /// <summary>
    /// <c>w-full</c> — <c>width: 100%</c> of the parent (block-level fill).
    /// </summary>
    public static WidthBuilder IsFull => new("w-full");
    /// <summary>
    /// <c>w-screen</c> — <c>100vw</c> (viewport width; can overflow if scrollbars differ from <c>100%</c>).
    /// </summary>
    public static WidthBuilder IsScreen => new("w-screen");
    /// <summary>
    /// <c>w-fit</c> — <c>width: fit-content</c> (shrink-wrap to content).
    /// </summary>
    public static WidthBuilder IsFit => new("w-fit");
    /// <summary>
    /// <c>w-min</c> — <c>width: min-content</c> (as narrow as content allows).
    /// </summary>
    public static WidthBuilder IsMin => new("w-min");
    /// <summary>
    /// <c>w-max</c> — <c>width: max-content</c> (as wide as content needs).
    /// </summary>
    public static WidthBuilder IsMax => new("w-max");

    /// <summary>
    /// <c>w-1/2</c> — <c>width: 50%</c> of the container (flex/grid column layouts).
    /// </summary>
    public static WidthBuilder Is1of2 => new("w-1/2");
    /// <summary>
    /// <c>w-1/3</c> — <c>width: 33.333333%</c>.
    /// </summary>
    public static WidthBuilder Is1of3 => new("w-1/3");
    /// <summary>
    /// <c>w-2/3</c> — <c>width: 66.666667%</c>.
    /// </summary>
    public static WidthBuilder Is2of3 => new("w-2/3");
    /// <summary>
    /// <c>w-1/4</c> — <c>width: 25%</c>.
    /// </summary>
    public static WidthBuilder Is1of4 => new("w-1/4");
    /// <summary>
    /// <c>w-3/4</c> — <c>width: 75%</c>.
    /// </summary>
    public static WidthBuilder Is3of4 => new("w-3/4");
    /// <summary>
    /// <c>w-1/5</c> — <c>width: 20%</c>.
    /// </summary>
    public static WidthBuilder Is1of5 => new("w-1/5");
    /// <summary>
    /// <c>w-2/5</c> — <c>width: 40%</c>.
    /// </summary>
    public static WidthBuilder Is2of5 => new("w-2/5");
    /// <summary>
    /// <c>w-3/5</c> — <c>width: 60%</c>.
    /// </summary>
    public static WidthBuilder Is3of5 => new("w-3/5");
    /// <summary>
    /// <c>w-4/5</c> — <c>width: 80%</c>.
    /// </summary>
    public static WidthBuilder Is4of5 => new("w-4/5");
    /// <summary>
    /// <c>w-1/6</c> — <c>width: 16.666667%</c>.
    /// </summary>
    public static WidthBuilder Is1of6 => new("w-1/6");
    /// <summary>
    /// <c>w-5/6</c> — <c>width: 83.333333%</c>.
    /// </summary>
    public static WidthBuilder Is5of6 => new("w-5/6");

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static WidthBuilder Auto => new("w-auto");

    /// <summary>
    /// Create from an arbitrary Tailwind width token (e.g. "72", "[18rem]", "full").
    /// </summary>
    public static WidthBuilder Token(string token) => new(token.StartsWith("w-") ? token : "w-" + token);
}
