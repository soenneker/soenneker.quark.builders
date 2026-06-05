using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the auto rows enum.
/// </summary>
[EnumValue<string>]
public sealed partial class AutoRowsEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly AutoRowsEnum Auto = new("auto-rows-auto");
    /// <summary>
    /// The min.
    /// </summary>
    public static readonly AutoRowsEnum Min = new("auto-rows-min");
    /// <summary>
    /// The max.
    /// </summary>
    public static readonly AutoRowsEnum Max = new("auto-rows-max");
    /// <summary>
    /// The fr.
    /// </summary>
    public static readonly AutoRowsEnum Fr = new("auto-rows-fr");
}
