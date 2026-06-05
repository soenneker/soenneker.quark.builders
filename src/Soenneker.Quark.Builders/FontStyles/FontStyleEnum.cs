using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the font style enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FontStyleEnum
{
    /// <summary>
    /// The italic.
    /// </summary>
    public static readonly FontStyleEnum Italic = new("italic");
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly FontStyleEnum Normal = new("not-italic");
}
