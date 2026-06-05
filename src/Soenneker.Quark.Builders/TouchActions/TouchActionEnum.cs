using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the touch action enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TouchActionEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly TouchActionEnum Auto = new("touch-auto");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly TouchActionEnum None = new("touch-none");
    /// <summary>
    /// The pan x.
    /// </summary>
    public static readonly TouchActionEnum PanX = new("touch-pan-x");
    /// <summary>
    /// The pan y.
    /// </summary>
    public static readonly TouchActionEnum PanY = new("touch-pan-y");
    /// <summary>
    /// The manipulation.
    /// </summary>
    public static readonly TouchActionEnum Manipulation = new("touch-manipulation");
}
