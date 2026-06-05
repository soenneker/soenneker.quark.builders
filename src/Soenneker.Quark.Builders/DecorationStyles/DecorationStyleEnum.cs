using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration style enum.
/// </summary>
[EnumValue<string>]
public sealed partial class DecorationStyleEnum
{
    /// <summary>
    /// The solid.
    /// </summary>
    public static readonly DecorationStyleEnum Solid = new("decoration-solid");
    /// <summary>
    /// The double.
    /// </summary>
    public static readonly DecorationStyleEnum Double = new("decoration-double");
    /// <summary>
    /// The dotted.
    /// </summary>
    public static readonly DecorationStyleEnum Dotted = new("decoration-dotted");
    /// <summary>
    /// The dashed.
    /// </summary>
    public static readonly DecorationStyleEnum Dashed = new("decoration-dashed");
    /// <summary>
    /// The wavy.
    /// </summary>
    public static readonly DecorationStyleEnum Wavy = new("decoration-wavy");
}
