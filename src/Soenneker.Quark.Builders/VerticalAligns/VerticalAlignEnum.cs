using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the vertical align enum.
/// </summary>
[EnumValue<string>]
public sealed partial class VerticalAlignEnum
{
    /// <summary>
    /// The baseline.
    /// </summary>
    public static readonly VerticalAlignEnum Baseline = new("align-baseline");
    /// <summary>
    /// The top.
    /// </summary>
    public static readonly VerticalAlignEnum Top = new("align-top");
    /// <summary>
    /// The middle.
    /// </summary>
    public static readonly VerticalAlignEnum Middle = new("align-middle");
    /// <summary>
    /// The bottom.
    /// </summary>
    public static readonly VerticalAlignEnum Bottom = new("align-bottom");
    /// <summary>
    /// The text top.
    /// </summary>
    public static readonly VerticalAlignEnum TextTop = new("align-text-top");
    /// <summary>
    /// The text bottom.
    /// </summary>
    public static readonly VerticalAlignEnum TextBottom = new("align-text-bottom");
}