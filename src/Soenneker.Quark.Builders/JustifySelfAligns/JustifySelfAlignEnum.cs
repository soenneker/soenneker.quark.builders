using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the justify self align enum.
/// </summary>
[EnumValue<string>]
public sealed partial class JustifySelfAlignEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly JustifySelfAlignEnum Auto = new("justify-self-auto");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly JustifySelfAlignEnum Start = new("justify-self-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly JustifySelfAlignEnum End = new("justify-self-end");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly JustifySelfAlignEnum Center = new("justify-self-center");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly JustifySelfAlignEnum Stretch = new("justify-self-stretch");
}
