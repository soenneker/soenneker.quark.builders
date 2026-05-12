namespace Soenneker.Quark;

/// <summary>
/// Tailwind <c>size-*</c> utility with fluent API.
/// </summary>
public static class Size
{
    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is0 => new("size-0");
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is1 => new("size-1");
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is2 => new("size-2");
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is3 => new("size-3");
    public static SizeBuilder Is3_5 => new("size-3.5");
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is4 => new("size-4");
    public static SizeBuilder Is4_5 => new("size-4.5");
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is5 => new("size-5");
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is6 => new("size-6");
    public static SizeBuilder Is6_5 => new("size-6.5");
    /// <summary>
    /// Spacing/sizing scale step `7` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 7` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is7 => new("size-7");
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is8 => new("size-8");
    /// <summary>
    /// Spacing/sizing scale step `9` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 9` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is9 => new("size-9");
    /// <summary>
    /// Spacing/sizing scale step `10` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 10` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is10 => new("size-10");
    /// <summary>
    /// Spacing/sizing scale step `11` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 11` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is11 => new("size-11");
    /// <summary>
    /// Spacing/sizing scale step `12` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 12` for integer spacing utilities unless overridden).
    /// </summary>
    public static SizeBuilder Is12 => new("size-12");
    /// <summary>
    /// Spacing/sizing scale step `14`.
    /// </summary>
    public static SizeBuilder Is14 => new("size-14");
    /// <summary>
    /// Spacing/sizing scale step `16`.
    /// </summary>
    public static SizeBuilder Is16 => new("size-16");
    /// <summary>
    /// Spacing/sizing scale step `20`.
    /// </summary>
    public static SizeBuilder Is20 => new("size-20");
    /// <summary>
    /// Spacing/sizing scale step `24`.
    /// </summary>
    public static SizeBuilder Is24 => new("size-24");
    /// <summary>
    /// Spacing/sizing scale step `32`.
    /// </summary>
    public static SizeBuilder Is32 => new("size-32");
    public static SizeBuilder IsPx => new("size-px");
    public static SizeBuilder IsFull => new("size-full");
    public static SizeBuilder IsMin => new("size-min");
    public static SizeBuilder IsMax => new("size-max");
    public static SizeBuilder IsFit => new("size-fit");

    /// <summary>
    /// Create from an arbitrary Tailwind size token (e.g. "5", "full", "[18px]").
    /// </summary>
    public static SizeBuilder Token(string value) => new(value.StartsWith("size-") ? value : "size-" + value);
}
