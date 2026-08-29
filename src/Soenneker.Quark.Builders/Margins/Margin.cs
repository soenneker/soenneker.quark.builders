namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned margin utility.
/// </summary>
[TailwindModifiers(typeof(MarginBuilder))]
public static partial class Margin
{
    /// <summary>
    /// Applies margin on the horizontal axis (left and right).
    /// </summary>
    public static MarginBuilder OnX => new(ElementSideEnum.Horizontal);

    /// <summary>
    /// Applies margin on the vertical axis (top and bottom).
    /// </summary>
    public static MarginBuilder OnY => new(ElementSideEnum.Vertical);

    /// <summary>
    /// Applies margin from the top side.
    /// </summary>
    public static MarginBuilder FromTop => new(ElementSideEnum.Top);

    /// <summary>
    /// Applies margin from the right side.
    /// </summary>
    public static MarginBuilder FromRight => new(ElementSideEnum.Right);

    /// <summary>
    /// Applies margin from the bottom side.
    /// </summary>
    public static MarginBuilder FromBottom => new(ElementSideEnum.Bottom);

    /// <summary>
    /// Applies margin from the left side.
    /// </summary>
    public static MarginBuilder FromLeft => new(ElementSideEnum.Left);

    /// <summary>
    /// Applies margin from the inline start.
    /// </summary>
    public static MarginBuilder FromStart => new(ElementSideEnum.InlineStart);

    /// <summary>
    /// Applies margin from the inline end.
    /// </summary>
    public static MarginBuilder FromEnd => new(ElementSideEnum.InlineEnd);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is0 => new(MarginScaleEnum.Is0Value);
    /// <summary>
    /// Gets or sets is0 5.
    /// </summary>
    public static MarginBuilder Is0_5 => new(MarginScaleEnum.Is0_5Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is1 => new(MarginScaleEnum.Is1Value);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public static MarginBuilder Is1_5 => new(MarginScaleEnum.Is1_5Value);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is2 => new(MarginScaleEnum.Is2Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is3 => new(MarginScaleEnum.Is3Value);
    /// <summary>
    /// Gets or sets is3 5.
    /// </summary>
    public static MarginBuilder Is3_5 => new(MarginScaleEnum.Is3_5Value);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is4 => new(MarginScaleEnum.Is4Value);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is5 => new(MarginScaleEnum.Is5Value);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public static MarginBuilder Is6 => new(MarginScaleEnum.Is6Value);
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public static MarginBuilder Is8 => new(MarginScaleEnum.Is8Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static MarginBuilder Is12 => new(MarginScaleEnum.Is12Value);
    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static MarginBuilder Auto => new(MarginScaleEnum.AutoValue);
    /// <summary>
    /// Gets or sets negative1.
    /// </summary>
    public static MarginBuilder Negative1 => new(MarginScaleEnum.Negative1Value);
    /// <summary>
    /// Gets or sets negative2.
    /// </summary>
    public static MarginBuilder Negative2 => new(MarginScaleEnum.Negative2Value);

    /// <summary>
    /// Creates a margin utility from an arbitrary Tailwind spacing token.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static MarginBuilder Token(string value) => new(value.StartsWith("-m-") || value.StartsWith("m-") ? value : value[0] == '-' ? "-m-" + value[1..] : "m-" + value);
}
