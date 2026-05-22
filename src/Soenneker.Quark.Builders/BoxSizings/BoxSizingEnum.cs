using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BoxSizingEnum
{
    public static readonly BoxSizingEnum Border = new("box-border");
    public static readonly BoxSizingEnum Content = new("box-content");
}
