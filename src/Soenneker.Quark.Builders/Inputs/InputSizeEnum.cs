using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the input size enum.
/// </summary>
[EnumValue<string>]
public sealed partial class InputSizeEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly InputSizeEnum Default = new("");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly InputSizeEnum Sm = new("h-9 text-xs");
    /// <summary>
    /// The lg.
    /// </summary>
    public static readonly InputSizeEnum Lg = new("h-11 text-base");
}
