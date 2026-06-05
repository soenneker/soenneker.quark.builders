using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the shrink enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ShrinkEnum
{
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly ShrinkEnum Is1 = new("shrink");
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly ShrinkEnum Is0 = new("shrink-0");
}
