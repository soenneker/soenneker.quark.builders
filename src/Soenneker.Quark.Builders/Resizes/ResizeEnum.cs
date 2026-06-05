using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the resize enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ResizeEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ResizeEnum None = new("resize-none");
    /// <summary>
    /// The both.
    /// </summary>
    public static readonly ResizeEnum Both = new("resize");
    /// <summary>
    /// The horizontal.
    /// </summary>
    public static readonly ResizeEnum Horizontal = new("resize-x");
    /// <summary>
    /// The vertical.
    /// </summary>
    public static readonly ResizeEnum Vertical = new("resize-y");
}
