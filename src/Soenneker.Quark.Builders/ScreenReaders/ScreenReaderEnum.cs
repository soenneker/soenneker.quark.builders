using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScreenReaderEnum
{
    public static readonly ScreenReaderEnum Only = new("sr-only");
}
