using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the border style enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BorderStyleEnum
{
    /// <summary>
    /// The solid.
    /// </summary>
    public static readonly BorderStyleEnum Solid = new("border-solid");
    /// <summary>
    /// The dashed.
    /// </summary>
    public static readonly BorderStyleEnum Dashed = new("border-dashed");
    /// <summary>
    /// The dotted.
    /// </summary>
    public static readonly BorderStyleEnum Dotted = new("border-dotted");
    /// <summary>
    /// The double.
    /// </summary>
    public static readonly BorderStyleEnum Double = new("border-double");
    /// <summary>
    /// The hidden.
    /// </summary>
    public static readonly BorderStyleEnum Hidden = new("border-hidden");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly BorderStyleEnum None = new("border-none");
}
