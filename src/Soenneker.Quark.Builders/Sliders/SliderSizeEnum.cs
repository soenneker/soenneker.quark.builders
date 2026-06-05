using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the slider size enum.
/// </summary>
[EnumValue<string>]
public sealed partial class SliderSizeEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly SliderSizeEnum Default = new("default");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly SliderSizeEnum Sm = new("sm");
    /// <summary>
    /// The lg.
    /// </summary>
    public static readonly SliderSizeEnum Lg = new("lg");
}
