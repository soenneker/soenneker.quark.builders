using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the radio size enum.
/// </summary>
[EnumValue<string>]
public sealed partial class RadioSizeEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly RadioSizeEnum Default = new("size-4");
    /// <summary>
    /// The xs.
    /// </summary>
    public static readonly RadioSizeEnum Xs = new("h-3 w-3");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly RadioSizeEnum Sm = new("h-3.5 w-3.5");
    /// <summary>
    /// The md.
    /// </summary>
    public static readonly RadioSizeEnum Md = new("h-4 w-4");
    /// <summary>
    /// The lg.
    /// </summary>
    public static readonly RadioSizeEnum Lg = new("h-5 w-5");
    /// <summary>
    /// The xl.
    /// </summary>
    public static readonly RadioSizeEnum Xl = new("h-7 w-7");
    /// <summary>
    /// The xxl.
    /// </summary>
    public static readonly RadioSizeEnum Xxl = new("h-8 w-8");
}
