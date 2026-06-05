using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the will change enum.
/// </summary>
[EnumValue<string>]
public sealed partial class WillChangeEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly WillChangeEnum Auto = new("will-change-auto");
    /// <summary>
    /// The scroll.
    /// </summary>
    public static readonly WillChangeEnum Scroll = new("will-change-scroll");
    /// <summary>
    /// The contents.
    /// </summary>
    public static readonly WillChangeEnum Contents = new("will-change-contents");
    /// <summary>
    /// The transform.
    /// </summary>
    public static readonly WillChangeEnum Transform = new("will-change-transform");
}
