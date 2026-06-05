using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the grow enum.
/// </summary>
[EnumValue<string>]
public sealed partial class GrowEnum
{
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly GrowEnum Is1 = new("grow");
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly GrowEnum Is0 = new("grow-0");
}
