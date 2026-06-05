using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the auto cols enum.
/// </summary>
[EnumValue<string>]
public sealed partial class AutoColsEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly AutoColsEnum Auto = new("auto-cols-auto");
    /// <summary>
    /// The min.
    /// </summary>
    public static readonly AutoColsEnum Min = new("auto-cols-min");
    /// <summary>
    /// The max.
    /// </summary>
    public static readonly AutoColsEnum Max = new("auto-cols-max");
    /// <summary>
    /// The fr.
    /// </summary>
    public static readonly AutoColsEnum Fr = new("auto-cols-fr");
}
