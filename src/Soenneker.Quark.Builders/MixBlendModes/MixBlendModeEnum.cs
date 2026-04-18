using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class MixBlendModeEnum
{
    public static readonly MixBlendModeEnum Normal = new("mix-blend-normal");
    public static readonly MixBlendModeEnum Multiply = new("mix-blend-multiply");
    public static readonly MixBlendModeEnum Screen = new("mix-blend-screen");
    public static readonly MixBlendModeEnum Overlay = new("mix-blend-overlay");
    public static readonly MixBlendModeEnum Darken = new("mix-blend-darken");
    public static readonly MixBlendModeEnum Lighten = new("mix-blend-lighten");
    public static readonly MixBlendModeEnum ColorDodge = new("mix-blend-color-dodge");
    public static readonly MixBlendModeEnum ColorBurn = new("mix-blend-color-burn");
    public static readonly MixBlendModeEnum HardLight = new("mix-blend-hard-light");
    public static readonly MixBlendModeEnum SoftLight = new("mix-blend-soft-light");
    public static readonly MixBlendModeEnum Difference = new("mix-blend-difference");
    public static readonly MixBlendModeEnum Exclusion = new("mix-blend-exclusion");
    public static readonly MixBlendModeEnum Hue = new("mix-blend-hue");
    public static readonly MixBlendModeEnum Saturation = new("mix-blend-saturation");
    public static readonly MixBlendModeEnum Color = new("mix-blend-color");
    public static readonly MixBlendModeEnum Luminosity = new("mix-blend-luminosity");
    public static readonly MixBlendModeEnum PlusDarker = new("mix-blend-plus-darker");
    public static readonly MixBlendModeEnum PlusLighter = new("mix-blend-plus-lighter");
}
