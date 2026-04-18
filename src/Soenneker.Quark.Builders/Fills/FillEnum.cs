using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FillEnum
{
    public static readonly FillEnum None = new("fill-none");
    public static readonly FillEnum Current = new("fill-current");
}
