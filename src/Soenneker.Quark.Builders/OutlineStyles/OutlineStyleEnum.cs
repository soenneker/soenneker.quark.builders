using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the outline style enum.
/// </summary>
[EnumValue<string>]
public sealed partial class OutlineStyleEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly OutlineStyleEnum None = new("outline-none");
    /// <summary>
    /// The hidden.
    /// </summary>
    public static readonly OutlineStyleEnum Hidden = new("outline-hidden");
    /// <summary>
    /// The solid.
    /// </summary>
    public static readonly OutlineStyleEnum Solid = new("outline");
    /// <summary>
    /// The dashed.
    /// </summary>
    public static readonly OutlineStyleEnum Dashed = new("outline-dashed");
    /// <summary>
    /// The dotted.
    /// </summary>
    public static readonly OutlineStyleEnum Dotted = new("outline-dotted");
    /// <summary>
    /// The double.
    /// </summary>
    public static readonly OutlineStyleEnum Double = new("outline-double");
}
