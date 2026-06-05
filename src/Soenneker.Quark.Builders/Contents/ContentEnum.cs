using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the content enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ContentEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly ContentEnum Normal = new("content-normal");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly ContentEnum Center = new("content-center");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly ContentEnum Start = new("content-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly ContentEnum End = new("content-end");
    /// <summary>
    /// The between.
    /// </summary>
    public static readonly ContentEnum Between = new("content-between");
    /// <summary>
    /// The around.
    /// </summary>
    public static readonly ContentEnum Around = new("content-around");
    /// <summary>
    /// The evenly.
    /// </summary>
    public static readonly ContentEnum Evenly = new("content-evenly");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly ContentEnum Stretch = new("content-stretch");
    /// <summary>
    /// The baseline.
    /// </summary>
    public static readonly ContentEnum Baseline = new("content-baseline");
}
