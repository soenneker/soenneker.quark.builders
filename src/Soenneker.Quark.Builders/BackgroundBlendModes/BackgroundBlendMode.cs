namespace Soenneker.Quark;

/// <summary>
/// Static utility for background-blend-mode. Tailwind: bg-blend-*.
/// </summary>
[TailwindModifiers(typeof(BackgroundBlendModeBuilder))]
public static partial class BackgroundBlendMode
{
    /// <summary>
    /// Fluent step for `Normal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Normal => new("bg-blend-normal");
    /// <summary>
    /// Fluent step for `Multiply` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Multiply => new("bg-blend-multiply");
    /// <summary>
    /// Viewport-relative size (e.g. `w-screen`, `min-h-screen`) tied to the viewport width/height.
    /// </summary>
    public static BackgroundBlendModeBuilder Screen => new("bg-blend-screen");
    /// <summary>
    /// Fluent step for `Overlay` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Overlay => new("bg-blend-overlay");
    /// <summary>
    /// Fluent step for `Darken` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Darken => new("bg-blend-darken");
    /// <summary>
    /// Fluent step for `Lighten` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Lighten => new("bg-blend-lighten");
    /// <summary>
    /// Fluent step for `Color Dodge` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder ColorDodge => new("bg-blend-color-dodge");
    /// <summary>
    /// Fluent step for `Color Burn` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder ColorBurn => new("bg-blend-color-burn");
    /// <summary>
    /// Fluent step for `Hard Light` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder HardLight => new("bg-blend-hard-light");
    /// <summary>
    /// Fluent step for `Soft Light` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder SoftLight => new("bg-blend-soft-light");
    /// <summary>
    /// Fluent step for `Difference` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Difference => new("bg-blend-difference");
    /// <summary>
    /// Fluent step for `Exclusion` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Exclusion => new("bg-blend-exclusion");
    /// <summary>
    /// Fluent step for `Hue` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Hue => new("bg-blend-hue");
    /// <summary>
    /// Fluent step for `Saturation` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Saturation => new("bg-blend-saturation");
    /// <summary>
    /// Fluent step for `Color` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Color => new("bg-blend-color");
    /// <summary>
    /// Fluent step for `Luminosity` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static BackgroundBlendModeBuilder Luminosity => new("bg-blend-luminosity");
}
