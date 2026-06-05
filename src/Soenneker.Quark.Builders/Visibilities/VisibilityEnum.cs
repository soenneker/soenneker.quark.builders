using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the visibility enum.
/// </summary>
[EnumValue<string>]
public sealed partial class VisibilityEnum
{
    /// <summary>
    /// The visible.
    /// </summary>
    public static readonly VisibilityEnum Visible = new("visible");
    /// <summary>
    /// The invisible.
    /// </summary>
    public static readonly VisibilityEnum Invisible = new("invisible");
}
