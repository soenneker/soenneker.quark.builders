using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PaginationSizeEnum
{
    public static readonly PaginationSizeEnum Default = new("default");
    public static readonly PaginationSizeEnum Sm = new("sm");
    public static readonly PaginationSizeEnum Lg = new("lg");
}
