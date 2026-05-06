namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned padding utility.
/// </summary>
public static class Padding
{
    /// <summary>
    /// Applies padding on the horizontal axis (left and right).
    /// </summary>
    public static PaddingBuilder OnX => new(ElementSideEnum.Horizontal);

    /// <summary>
    /// Applies padding on the vertical axis (top and bottom).
    /// </summary>
    public static PaddingBuilder OnY => new(ElementSideEnum.Vertical);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is0 => new(PaddingScaleEnum.Is0Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is1 => new(PaddingScaleEnum.Is1Value);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is2 => new(PaddingScaleEnum.Is2Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is3 => new(PaddingScaleEnum.Is3Value);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is4 => new(PaddingScaleEnum.Is4Value);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is5 => new(PaddingScaleEnum.Is5Value);
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is6 => new(PaddingScaleEnum.Is6Value);
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is8 => new(PaddingScaleEnum.Is8Value);
    /// <summary>
    /// Spacing/sizing scale step `16` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 16` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is16 => new(PaddingScaleEnum.Is16Value);

    /// <summary>
    /// Creates a padding utility from an arbitrary Tailwind spacing token.
    /// </summary>
    public static PaddingBuilder Token(string value) => new(value.StartsWith("p-") ? value : "p-" + value);
}
