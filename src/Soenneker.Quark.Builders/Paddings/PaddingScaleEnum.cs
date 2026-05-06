using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PaddingScaleEnum
{
    public static readonly PaddingScaleEnum Is0 = new("p-0");
    public static readonly PaddingScaleEnum Is1 = new("p-1");
    public static readonly PaddingScaleEnum Is2 = new("p-2");
    public static readonly PaddingScaleEnum Is3 = new("p-3");
    public static readonly PaddingScaleEnum Is4 = new("p-4");
    public static readonly PaddingScaleEnum Is5 = new("p-5");
    public static readonly PaddingScaleEnum Is6 = new("p-6");
    public static readonly PaddingScaleEnum Is8 = new("p-8");
    public static readonly PaddingScaleEnum Is16 = new("p-16");
}
