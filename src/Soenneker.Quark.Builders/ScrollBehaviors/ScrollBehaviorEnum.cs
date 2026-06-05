using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the scroll behavior enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ScrollBehaviorEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly ScrollBehaviorEnum Auto = new("scroll-auto");
    /// <summary>
    /// The smooth.
    /// </summary>
    public static readonly ScrollBehaviorEnum Smooth = new("scroll-smooth");
}
