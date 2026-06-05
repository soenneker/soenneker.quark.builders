using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the line clamp enum.
/// </summary>
[EnumValue<string>]
public sealed partial class LineClampEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly LineClampEnum None = new("line-clamp-none");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly LineClampEnum Is1 = new("line-clamp-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly LineClampEnum Is2 = new("line-clamp-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly LineClampEnum Is3 = new("line-clamp-3");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly LineClampEnum Is4 = new("line-clamp-4");
    /// <summary>
    /// The is5.
    /// </summary>
    public static readonly LineClampEnum Is5 = new("line-clamp-5");
    /// <summary>
    /// The is6.
    /// </summary>
    public static readonly LineClampEnum Is6 = new("line-clamp-6");
}
