namespace Soenneker.Quark;

/// <summary>
/// Static utility for scroll padding. Tailwind: scroll-p-*.
/// </summary>
[TailwindModifiers(typeof(ScrollPaddingBuilder))]
public static partial class ScrollPadding
{
    /// <summary>
    /// Applies scroll padding on the horizontal axis (left and right).
    /// </summary>
    public static ScrollPaddingBuilder OnX => new(ElementSideEnum.Horizontal);

    /// <summary>
    /// Applies scroll padding on the vertical axis (top and bottom).
    /// </summary>
    public static ScrollPaddingBuilder OnY => new(ElementSideEnum.Vertical);

    /// <summary>
    /// Applies scroll padding from the top side.
    /// </summary>
    public static ScrollPaddingBuilder FromTop => new(ElementSideEnum.Top);

    /// <summary>
    /// Applies scroll padding from the right side.
    /// </summary>
    public static ScrollPaddingBuilder FromRight => new(ElementSideEnum.Right);

    /// <summary>
    /// Applies scroll padding from the bottom side.
    /// </summary>
    public static ScrollPaddingBuilder FromBottom => new(ElementSideEnum.Bottom);

    /// <summary>
    /// Applies scroll padding from the left side.
    /// </summary>
    public static ScrollPaddingBuilder FromLeft => new(ElementSideEnum.Left);

    /// <summary>
    /// Applies scroll padding from the inline start.
    /// </summary>
    public static ScrollPaddingBuilder FromStart => new(ElementSideEnum.InlineStart);

    /// <summary>
    /// Applies scroll padding from the inline end.
    /// </summary>
    public static ScrollPaddingBuilder FromEnd => new(ElementSideEnum.InlineEnd);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollPaddingBuilder Is0 => new(ScrollPaddingScaleEnum.Is0Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollPaddingBuilder Is1 => new(ScrollPaddingScaleEnum.Is1Value);
    /// <summary>
    /// Spacing/sizing scale step `1.5` — uses Tailwind’s default spacing scale.
    /// </summary>
    public static ScrollPaddingBuilder Is1_5 => new(ScrollPaddingScaleEnum.Is1_5Value);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollPaddingBuilder Is2 => new(ScrollPaddingScaleEnum.Is2Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollPaddingBuilder Is3 => new(ScrollPaddingScaleEnum.Is3Value);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollPaddingBuilder Is4 => new(ScrollPaddingScaleEnum.Is4Value);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollPaddingBuilder Is5 => new(ScrollPaddingScaleEnum.Is5Value);
    /// <summary>
    /// One pixel (`px` unit) — hairline borders, fixed 1px tracks, etc.
    /// </summary>
    public static ScrollPaddingBuilder Px => new(ScrollPaddingScaleEnum.PxValue);
}
