namespace Soenneker.Quark;

/// <summary>
/// Static utility for scroll margin. Tailwind: scroll-m-*.
/// </summary>
[TailwindModifiers(typeof(ScrollMarginBuilder))]
public static partial class ScrollMargin
{
    /// <summary>
    /// Applies scroll margin on the horizontal axis (left and right).
    /// </summary>
    public static ScrollMarginBuilder OnX => new(ElementSideEnum.Horizontal);

    /// <summary>
    /// Applies scroll margin on the vertical axis (top and bottom).
    /// </summary>
    public static ScrollMarginBuilder OnY => new(ElementSideEnum.Vertical);

    /// <summary>
    /// Applies scroll margin from the top side.
    /// </summary>
    public static ScrollMarginBuilder FromTop => new(ElementSideEnum.Top);

    /// <summary>
    /// Applies scroll margin from the right side.
    /// </summary>
    public static ScrollMarginBuilder FromRight => new(ElementSideEnum.Right);

    /// <summary>
    /// Applies scroll margin from the bottom side.
    /// </summary>
    public static ScrollMarginBuilder FromBottom => new(ElementSideEnum.Bottom);

    /// <summary>
    /// Applies scroll margin from the left side.
    /// </summary>
    public static ScrollMarginBuilder FromLeft => new(ElementSideEnum.Left);

    /// <summary>
    /// Applies scroll margin from the inline start.
    /// </summary>
    public static ScrollMarginBuilder FromStart => new(ElementSideEnum.InlineStart);

    /// <summary>
    /// Applies scroll margin from the inline end.
    /// </summary>
    public static ScrollMarginBuilder FromEnd => new(ElementSideEnum.InlineEnd);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollMarginBuilder Is0 => new(ScrollMarginScaleEnum.Is0Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollMarginBuilder Is1 => new(ScrollMarginScaleEnum.Is1Value);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollMarginBuilder Is2 => new(ScrollMarginScaleEnum.Is2Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollMarginBuilder Is3 => new(ScrollMarginScaleEnum.Is3Value);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollMarginBuilder Is4 => new(ScrollMarginScaleEnum.Is4Value);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollMarginBuilder Is5 => new(ScrollMarginScaleEnum.Is5Value);
    /// <summary>
    /// Spacing/sizing scale step `24` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 24` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollMarginBuilder Is24 => new(ScrollMarginScaleEnum.Is24Value);
    /// <summary>
    /// One pixel (`px` unit) — hairline borders, fixed 1px tracks, etc.
    /// </summary>
    public static ScrollMarginBuilder Px => new(ScrollMarginScaleEnum.PxValue);
}
