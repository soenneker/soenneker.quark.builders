using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OrderEnum
{
    public static readonly OrderEnum First = new("order-first");
    public static readonly OrderEnum Last = new("order-last");
    public static readonly OrderEnum None = new("order-none");
    public static readonly OrderEnum Is1 = new("order-1");
    public static readonly OrderEnum Is12 = new("order-12");
}
