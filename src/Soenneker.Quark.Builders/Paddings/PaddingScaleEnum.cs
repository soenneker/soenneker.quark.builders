using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PaddingScaleEnum
{
    public static readonly PaddingScaleEnum Is0 = new("0");
    public static readonly PaddingScaleEnum Is1 = new("1");
    public static readonly PaddingScaleEnum Is2 = new("2");
    public static readonly PaddingScaleEnum Is3 = new("3");
    public static readonly PaddingScaleEnum Is4 = new("4");
    public static readonly PaddingScaleEnum Is5 = new("5");
}
