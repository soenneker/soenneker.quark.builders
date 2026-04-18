using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class StrokeEnum
{
    public static readonly StrokeEnum None = new("stroke-none");
}
