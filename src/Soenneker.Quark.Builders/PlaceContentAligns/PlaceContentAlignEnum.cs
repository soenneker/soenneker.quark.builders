using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the place content align enum.
/// </summary>
[EnumValue<string>]
public sealed partial class PlaceContentAlignEnum
{
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly PlaceContentAlignEnum Center = new("place-content-center");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly PlaceContentAlignEnum Start = new("place-content-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly PlaceContentAlignEnum End = new("place-content-end");
    /// <summary>
    /// The between.
    /// </summary>
    public static readonly PlaceContentAlignEnum Between = new("place-content-between");
    /// <summary>
    /// The around.
    /// </summary>
    public static readonly PlaceContentAlignEnum Around = new("place-content-around");
    /// <summary>
    /// The evenly.
    /// </summary>
    public static readonly PlaceContentAlignEnum Evenly = new("place-content-evenly");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly PlaceContentAlignEnum Stretch = new("place-content-stretch");
    /// <summary>
    /// The baseline.
    /// </summary>
    public static readonly PlaceContentAlignEnum Baseline = new("place-content-baseline");
}
