using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FontStyleEnum
{
    public static readonly FontStyleEnum Italic = new("italic");
    public static readonly FontStyleEnum Normal = new("not-italic");
}
