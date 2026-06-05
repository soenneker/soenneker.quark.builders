using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the box sizing enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BoxSizingEnum
{
    /// <summary>
    /// The border.
    /// </summary>
    public static readonly BoxSizingEnum Border = new("box-border");
    /// <summary>
    /// The content.
    /// </summary>
    public static readonly BoxSizingEnum Content = new("box-content");
}
