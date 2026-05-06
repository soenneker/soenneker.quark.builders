namespace Soenneker.Quark;

/// <summary>
/// Static utility for scroll padding. Tailwind: scroll-p-*.
/// </summary>
public static class ScrollPadding
{
    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollPaddingBuilder Is0 => new(ScrollPaddingScaleEnum.Is0Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static ScrollPaddingBuilder Is1 => new(ScrollPaddingScaleEnum.Is1Value);
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
