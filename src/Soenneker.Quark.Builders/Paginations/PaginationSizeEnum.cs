using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PaginationSizeEnum
{
    public static readonly PaginationSizeEnum Default = new("");
    public static readonly PaginationSizeEnum Sm = new("pagination-sm");
    public static readonly PaginationSizeEnum Lg = new("pagination-lg");
}
