namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned margin utility.
/// </summary>
public static class Margin
{
    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is0 => new(MarginScaleEnum.Is0Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is1 => new(MarginScaleEnum.Is1Value);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is2 => new(MarginScaleEnum.Is2Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is3 => new(MarginScaleEnum.Is3Value);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is4 => new(MarginScaleEnum.Is4Value);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is5 => new(MarginScaleEnum.Is5Value);
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is8 => new(MarginScaleEnum.Is8Value);
    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static MarginBuilder Auto => new(MarginScaleEnum.AutoValue);

    /// <summary>
    /// Creates a margin utility from an arbitrary Tailwind spacing token.
    /// </summary>
    public static MarginBuilder Token(string value) => new(value.StartsWith("-m-") || value.StartsWith("m-") ? value : value[0] == '-' ? "-m-" + value[1..] : "m-" + value);
}
