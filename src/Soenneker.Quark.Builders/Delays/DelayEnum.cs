using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the delay enum.
/// </summary>
[EnumValue<string>]
public sealed partial class DelayEnum
{
    /// <summary>
    /// The is75.
    /// </summary>
    public static readonly DelayEnum Is75 = new("delay-75");
    /// <summary>
    /// The is100.
    /// </summary>
    public static readonly DelayEnum Is100 = new("delay-100");
    /// <summary>
    /// The is150.
    /// </summary>
    public static readonly DelayEnum Is150 = new("delay-150");
    /// <summary>
    /// The is200.
    /// </summary>
    public static readonly DelayEnum Is200 = new("delay-200");
    /// <summary>
    /// The is300.
    /// </summary>
    public static readonly DelayEnum Is300 = new("delay-300");
    /// <summary>
    /// The is500.
    /// </summary>
    public static readonly DelayEnum Is500 = new("delay-500");
    /// <summary>
    /// The is700.
    /// </summary>
    public static readonly DelayEnum Is700 = new("delay-700");
    /// <summary>
    /// The is1000.
    /// </summary>
    public static readonly DelayEnum Is1000 = new("delay-1000");
}
