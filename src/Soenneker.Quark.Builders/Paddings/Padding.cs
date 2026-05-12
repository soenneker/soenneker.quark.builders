namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned padding utility.
/// </summary>
[TailwindModifiers(typeof(PaddingBuilder))]
public static partial class Padding
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
    /// Applies padding from the top side.
    /// </summary>
    public static PaddingBuilder FromTop => new(ElementSideEnum.Top);

    /// <summary>
    /// Applies padding from the right side.
    /// </summary>
    public static PaddingBuilder FromRight => new(ElementSideEnum.Right);

    /// <summary>
    /// Applies padding from the bottom side.
    /// </summary>
    public static PaddingBuilder FromBottom => new(ElementSideEnum.Bottom);

    /// <summary>
    /// Applies padding from the left side.
    /// </summary>
    public static PaddingBuilder FromLeft => new(ElementSideEnum.Left);

    /// <summary>
    /// Applies padding from the inline start.
    /// </summary>
    public static PaddingBuilder FromStart => new(ElementSideEnum.InlineStart);

    /// <summary>
    /// Applies padding from the inline end.
    /// </summary>
    public static PaddingBuilder FromEnd => new(ElementSideEnum.InlineEnd);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is0 => new(PaddingScaleEnum.Is0Value);
    public static PaddingBuilder Is0_5 => new(PaddingScaleEnum.Is0_5Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is1 => new(PaddingScaleEnum.Is1Value);
    public static PaddingBuilder Is1_5 => new(PaddingScaleEnum.Is1_5Value);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is2 => new(PaddingScaleEnum.Is2Value);
    public static PaddingBuilder Is2_5 => new(PaddingScaleEnum.Is2_5Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is3 => new(PaddingScaleEnum.Is3Value);
    public static PaddingBuilder Is3_5 => new(PaddingScaleEnum.Is3_5Value);
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
    public static PaddingBuilder Is7 => new(PaddingScaleEnum.Is7Value);
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is8 => new(PaddingScaleEnum.Is8Value);
    public static PaddingBuilder Is9 => new(PaddingScaleEnum.Is9Value);
    public static PaddingBuilder Is10 => new(PaddingScaleEnum.Is10Value);
    public static PaddingBuilder Is12 => new(PaddingScaleEnum.Is12Value);
    /// <summary>
    /// Spacing/sizing scale step `16` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 16` for integer spacing utilities unless overridden).
    /// </summary>
    public static PaddingBuilder Is16 => new(PaddingScaleEnum.Is16Value);
    public static PaddingBuilder IsPx => new(PaddingScaleEnum.IsPxValue);

    /// <summary>
    /// Creates a padding utility from an arbitrary Tailwind spacing token.
    /// </summary>
    public static PaddingBuilder Token(string value) => new(value.StartsWith("p-") ? value : "p-" + value);
}
