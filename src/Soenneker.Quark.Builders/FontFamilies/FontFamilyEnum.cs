using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the font family enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FontFamilyEnum
{
    /// <summary>
    /// The sans.
    /// </summary>
    public static readonly FontFamilyEnum Sans = new("font-sans");
    /// <summary>
    /// The serif.
    /// </summary>
    public static readonly FontFamilyEnum Serif = new("font-serif");
    /// <summary>
    /// The mono.
    /// </summary>
    public static readonly FontFamilyEnum Mono = new("font-mono");
}
