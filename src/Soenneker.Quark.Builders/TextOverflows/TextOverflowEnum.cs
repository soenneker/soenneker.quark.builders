using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TextOverflowEnum
{
    public static readonly TextOverflowEnum Clip = new("text-clip");
    public static readonly TextOverflowEnum Ellipsis = new("text-ellipsis");
}
