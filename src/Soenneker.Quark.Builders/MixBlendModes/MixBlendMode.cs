namespace Soenneker.Quark;

/// <summary>
/// Static utility for mix-blend-mode. Tailwind: mix-blend-*.
/// </summary>
[TailwindModifiers(typeof(MixBlendModeBuilder))]
public static partial class MixBlendMode
{
    /// <summary>
    /// Fluent step for `Normal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Normal => new(MixBlendModeEnum.NormalValue);
    /// <summary>
    /// Fluent step for `Multiply` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Multiply => new(MixBlendModeEnum.MultiplyValue);
    /// <summary>
    /// Viewport-relative size (e.g. `w-screen`, `min-h-screen`) tied to the viewport width/height.
    /// </summary>
    public static MixBlendModeBuilder Screen => new(MixBlendModeEnum.ScreenValue);
    /// <summary>
    /// Fluent step for `Overlay` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Overlay => new(MixBlendModeEnum.OverlayValue);
    /// <summary>
    /// Fluent step for `Darken` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Darken => new(MixBlendModeEnum.DarkenValue);
    /// <summary>
    /// Fluent step for `Lighten` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Lighten => new(MixBlendModeEnum.LightenValue);
    /// <summary>
    /// Fluent step for `Color Dodge` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder ColorDodge => new(MixBlendModeEnum.ColorDodgeValue);
    /// <summary>
    /// Fluent step for `Color Burn` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder ColorBurn => new(MixBlendModeEnum.ColorBurnValue);
    /// <summary>
    /// Fluent step for `Hard Light` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder HardLight => new(MixBlendModeEnum.HardLightValue);
    /// <summary>
    /// Fluent step for `Soft Light` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder SoftLight => new(MixBlendModeEnum.SoftLightValue);
    /// <summary>
    /// Fluent step for `Difference` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Difference => new(MixBlendModeEnum.DifferenceValue);
    /// <summary>
    /// Fluent step for `Exclusion` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Exclusion => new(MixBlendModeEnum.ExclusionValue);
    /// <summary>
    /// Fluent step for `Hue` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Hue => new(MixBlendModeEnum.HueValue);
    /// <summary>
    /// Fluent step for `Saturation` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Saturation => new(MixBlendModeEnum.SaturationValue);
    /// <summary>
    /// Fluent step for `Color` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Color => new(MixBlendModeEnum.ColorValue);
    /// <summary>
    /// Fluent step for `Luminosity` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder Luminosity => new(MixBlendModeEnum.LuminosityValue);
    /// <summary>
    /// Fluent step for `Plus Darker` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder PlusDarker => new(MixBlendModeEnum.PlusDarkerValue);
    /// <summary>
    /// Fluent step for `Plus Lighter` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MixBlendModeBuilder PlusLighter => new(MixBlendModeEnum.PlusLighterValue);
}
