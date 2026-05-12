namespace Soenneker.Quark;

/// <summary>
/// Static utility for inset (position offset) builders. Tailwind: inset-*, top-*, right-*, bottom-*, left-*, start-*, end-*.
/// </summary>
[TailwindModifiers(typeof(InsetBuilder))]
public static partial class Inset
{
    /// <summary>
    /// Applies inset on the horizontal axis (left and right).
    /// </summary>
    public static InsetBuilder OnX => new(ElementSideEnum.Horizontal);

    /// <summary>
    /// Applies inset on the vertical axis (top and bottom).
    /// </summary>
    public static InsetBuilder OnY => new(ElementSideEnum.Vertical);

    /// <summary>
    /// Applies inset from the top side.
    /// </summary>
    public static InsetBuilder FromTop => new(ElementSideEnum.Top);

    /// <summary>
    /// Applies inset from the right side.
    /// </summary>
    public static InsetBuilder FromRight => new(ElementSideEnum.Right);

    /// <summary>
    /// Applies inset from the bottom side.
    /// </summary>
    public static InsetBuilder FromBottom => new(ElementSideEnum.Bottom);

    /// <summary>
    /// Applies inset from the left side.
    /// </summary>
    public static InsetBuilder FromLeft => new(ElementSideEnum.Left);

    /// <summary>
    /// Applies inset from the inline start.
    /// </summary>
    public static InsetBuilder FromStart => new(ElementSideEnum.InlineStart);

    /// <summary>
    /// Applies inset from the inline end.
    /// </summary>
    public static InsetBuilder FromEnd => new(ElementSideEnum.InlineEnd);

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static InsetBuilder Is0 => new(InsetScaleEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static InsetBuilder Is1 => new(InsetScaleEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static InsetBuilder Is2 => new(InsetScaleEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static InsetBuilder Is3 => new(InsetScaleEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static InsetBuilder Is4 => new(InsetScaleEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static InsetBuilder Is5 => new(InsetScaleEnum.Is5);
    /// <summary>
    /// One pixel (`px` unit) — hairline borders, fixed 1px tracks, etc.
    /// </summary>
    public static InsetBuilder Px => new(InsetScaleEnum.Px);
    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static InsetBuilder Auto => new(InsetScaleEnum.Auto);
}
