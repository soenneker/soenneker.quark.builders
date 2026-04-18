using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FontFamilyEnum
{
    public static readonly FontFamilyEnum Sans = new("font-sans");
    public static readonly FontFamilyEnum Serif = new("font-serif");
    public static readonly FontFamilyEnum Mono = new("font-mono");
}
