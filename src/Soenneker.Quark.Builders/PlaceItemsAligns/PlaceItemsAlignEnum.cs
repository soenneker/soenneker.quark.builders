using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the place items align enum.
/// </summary>
[EnumValue<string>]
public sealed partial class PlaceItemsAlignEnum
{
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly PlaceItemsAlignEnum Start = new("place-items-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly PlaceItemsAlignEnum End = new("place-items-end");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly PlaceItemsAlignEnum Center = new("place-items-center");
    /// <summary>
    /// The baseline.
    /// </summary>
    public static readonly PlaceItemsAlignEnum Baseline = new("place-items-baseline");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly PlaceItemsAlignEnum Stretch = new("place-items-stretch");
}
