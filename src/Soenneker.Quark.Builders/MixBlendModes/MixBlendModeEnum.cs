using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the mix blend mode enum.
/// </summary>
[EnumValue<string>]
public sealed partial class MixBlendModeEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly MixBlendModeEnum Normal = new("mix-blend-normal");
    /// <summary>
    /// The multiply.
    /// </summary>
    public static readonly MixBlendModeEnum Multiply = new("mix-blend-multiply");
    /// <summary>
    /// The screen.
    /// </summary>
    public static readonly MixBlendModeEnum Screen = new("mix-blend-screen");
    /// <summary>
    /// The overlay.
    /// </summary>
    public static readonly MixBlendModeEnum Overlay = new("mix-blend-overlay");
    /// <summary>
    /// The darken.
    /// </summary>
    public static readonly MixBlendModeEnum Darken = new("mix-blend-darken");
    /// <summary>
    /// The lighten.
    /// </summary>
    public static readonly MixBlendModeEnum Lighten = new("mix-blend-lighten");
    /// <summary>
    /// The color dodge.
    /// </summary>
    public static readonly MixBlendModeEnum ColorDodge = new("mix-blend-color-dodge");
    /// <summary>
    /// The color burn.
    /// </summary>
    public static readonly MixBlendModeEnum ColorBurn = new("mix-blend-color-burn");
    /// <summary>
    /// The hard light.
    /// </summary>
    public static readonly MixBlendModeEnum HardLight = new("mix-blend-hard-light");
    /// <summary>
    /// The soft light.
    /// </summary>
    public static readonly MixBlendModeEnum SoftLight = new("mix-blend-soft-light");
    /// <summary>
    /// The difference.
    /// </summary>
    public static readonly MixBlendModeEnum Difference = new("mix-blend-difference");
    /// <summary>
    /// The exclusion.
    /// </summary>
    public static readonly MixBlendModeEnum Exclusion = new("mix-blend-exclusion");
    /// <summary>
    /// The hue.
    /// </summary>
    public static readonly MixBlendModeEnum Hue = new("mix-blend-hue");
    /// <summary>
    /// The saturation.
    /// </summary>
    public static readonly MixBlendModeEnum Saturation = new("mix-blend-saturation");
    /// <summary>
    /// The color.
    /// </summary>
    public static readonly MixBlendModeEnum Color = new("mix-blend-color");
    /// <summary>
    /// The luminosity.
    /// </summary>
    public static readonly MixBlendModeEnum Luminosity = new("mix-blend-luminosity");
    /// <summary>
    /// The plus darker.
    /// </summary>
    public static readonly MixBlendModeEnum PlusDarker = new("mix-blend-plus-darker");
    /// <summary>
    /// The plus lighter.
    /// </summary>
    public static readonly MixBlendModeEnum PlusLighter = new("mix-blend-plus-lighter");
}
