using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the scroll snap align enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ScrollSnapAlignEnum
{
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly ScrollSnapAlignEnum Start = new("snap-start");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly ScrollSnapAlignEnum Center = new("snap-center");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly ScrollSnapAlignEnum End = new("snap-end");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ScrollSnapAlignEnum None = new("snap-align-none");
}
