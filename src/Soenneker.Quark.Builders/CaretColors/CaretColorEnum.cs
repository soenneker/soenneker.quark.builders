using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class CaretColorEnum
{
    public static readonly CaretColorEnum Primary = new("caret-primary");
    public static readonly CaretColorEnum Transparent = new("caret-transparent");
    public static readonly CaretColorEnum Current = new("caret-current");
}
