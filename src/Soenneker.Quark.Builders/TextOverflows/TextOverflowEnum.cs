using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the text overflow enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TextOverflowEnum
{
    /// <summary>
    /// The clip.
    /// </summary>
    public static readonly TextOverflowEnum Clip = new("text-clip");
    /// <summary>
    /// The ellipsis.
    /// </summary>
    public static readonly TextOverflowEnum Ellipsis = new("text-ellipsis");
}
