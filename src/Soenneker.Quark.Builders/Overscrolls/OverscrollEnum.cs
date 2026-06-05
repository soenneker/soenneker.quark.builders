using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the overscroll enum.
/// </summary>
[EnumValue<string>]
public sealed partial class OverscrollEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly OverscrollEnum Auto = new("overscroll-auto");
    /// <summary>
    /// The contain.
    /// </summary>
    public static readonly OverscrollEnum Contain = new("overscroll-contain");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly OverscrollEnum None = new("overscroll-none");
    /// <summary>
    /// The x auto.
    /// </summary>
    public static readonly OverscrollEnum XAuto = new("overscroll-x-auto");
    /// <summary>
    /// The x contain.
    /// </summary>
    public static readonly OverscrollEnum XContain = new("overscroll-x-contain");
    /// <summary>
    /// The x none.
    /// </summary>
    public static readonly OverscrollEnum XNone = new("overscroll-x-none");
    /// <summary>
    /// The y auto.
    /// </summary>
    public static readonly OverscrollEnum YAuto = new("overscroll-y-auto");
    /// <summary>
    /// The y contain.
    /// </summary>
    public static readonly OverscrollEnum YContain = new("overscroll-y-contain");
    /// <summary>
    /// The y none.
    /// </summary>
    public static readonly OverscrollEnum YNone = new("overscroll-y-none");
}
