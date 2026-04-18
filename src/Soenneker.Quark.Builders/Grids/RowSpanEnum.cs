using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RowSpanEnum
{
    public static readonly RowSpanEnum Is1 = new("row-span-1");
    public static readonly RowSpanEnum Is2 = new("row-span-2");
    public static readonly RowSpanEnum Is3 = new("row-span-3");
    public static readonly RowSpanEnum Is4 = new("row-span-4");
    public static readonly RowSpanEnum Is5 = new("row-span-5");
    public static readonly RowSpanEnum Is6 = new("row-span-6");
    public static readonly RowSpanEnum Full = new("row-span-full");
}
