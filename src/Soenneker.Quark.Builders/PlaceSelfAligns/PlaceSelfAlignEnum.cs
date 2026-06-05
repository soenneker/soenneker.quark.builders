using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the place self align enum.
/// </summary>
[EnumValue<string>]
public sealed partial class PlaceSelfAlignEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly PlaceSelfAlignEnum Auto = new("place-self-auto");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly PlaceSelfAlignEnum Start = new("place-self-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly PlaceSelfAlignEnum End = new("place-self-end");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly PlaceSelfAlignEnum Center = new("place-self-center");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly PlaceSelfAlignEnum Stretch = new("place-self-stretch");
}
