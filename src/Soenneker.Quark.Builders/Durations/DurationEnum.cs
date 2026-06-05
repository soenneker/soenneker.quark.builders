using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the duration enum.
/// </summary>
[EnumValue<string>]
public sealed partial class DurationEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly DurationEnum Is0 = new("duration-0");
    /// <summary>
    /// The is75.
    /// </summary>
    public static readonly DurationEnum Is75 = new("duration-75");
    /// <summary>
    /// The is100.
    /// </summary>
    public static readonly DurationEnum Is100 = new("duration-100");
    /// <summary>
    /// The is150.
    /// </summary>
    public static readonly DurationEnum Is150 = new("duration-150");
    /// <summary>
    /// The is200.
    /// </summary>
    public static readonly DurationEnum Is200 = new("duration-200");
    /// <summary>
    /// The is300.
    /// </summary>
    public static readonly DurationEnum Is300 = new("duration-300");
    /// <summary>
    /// The is500.
    /// </summary>
    public static readonly DurationEnum Is500 = new("duration-500");
    /// <summary>
    /// The is700.
    /// </summary>
    public static readonly DurationEnum Is700 = new("duration-700");
    /// <summary>
    /// The is1000.
    /// </summary>
    public static readonly DurationEnum Is1000 = new("duration-1000");
}
