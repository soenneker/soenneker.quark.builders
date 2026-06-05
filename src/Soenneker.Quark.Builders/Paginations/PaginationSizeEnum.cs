using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the pagination size enum.
/// </summary>
[EnumValue<string>]
public sealed partial class PaginationSizeEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly PaginationSizeEnum Default = new("");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly PaginationSizeEnum Sm = new("pagination-sm");
    /// <summary>
    /// The lg.
    /// </summary>
    public static readonly PaginationSizeEnum Lg = new("pagination-lg");
}
