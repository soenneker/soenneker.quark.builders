using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the row span enum.
/// </summary>
[EnumValue<string>]
public sealed partial class RowSpanEnum
{
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly RowSpanEnum Is1 = new("row-span-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly RowSpanEnum Is2 = new("row-span-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly RowSpanEnum Is3 = new("row-span-3");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly RowSpanEnum Is4 = new("row-span-4");
    /// <summary>
    /// The is5.
    /// </summary>
    public static readonly RowSpanEnum Is5 = new("row-span-5");
    /// <summary>
    /// The is6.
    /// </summary>
    public static readonly RowSpanEnum Is6 = new("row-span-6");
    /// <summary>
    /// The full.
    /// </summary>
    public static readonly RowSpanEnum Full = new("row-span-full");
}
