using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the justify enum.
/// </summary>
[EnumValue<string>]
public sealed partial class JustifyEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly JustifyEnum Normal = new("justify-normal");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly JustifyEnum Start = new("justify-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly JustifyEnum End = new("justify-end");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly JustifyEnum Center = new("justify-center");
    /// <summary>
    /// The between.
    /// </summary>
    public static readonly JustifyEnum Between = new("justify-between");
    /// <summary>
    /// The around.
    /// </summary>
    public static readonly JustifyEnum Around = new("justify-around");
    /// <summary>
    /// The evenly.
    /// </summary>
    public static readonly JustifyEnum Evenly = new("justify-evenly");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly JustifyEnum Stretch = new("justify-stretch");
}
