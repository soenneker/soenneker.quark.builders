using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the order enum.
/// </summary>
[EnumValue<string>]
public sealed partial class OrderEnum
{
    /// <summary>
    /// The first.
    /// </summary>
    public static readonly OrderEnum First = new("order-first");
    /// <summary>
    /// The last.
    /// </summary>
    public static readonly OrderEnum Last = new("order-last");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly OrderEnum None = new("order-none");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly OrderEnum Is1 = new("order-1");
    /// <summary>
    /// The is12.
    /// </summary>
    public static readonly OrderEnum Is12 = new("order-12");
}
