using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the float enum.
/// </summary>
[EnumValue<string>]
public partial class FloatEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly FloatEnum None = new("float-none");
    /// <summary>
    /// The left.
    /// </summary>
    public static readonly FloatEnum Left = new("float-left");
    /// <summary>
    /// The right.
    /// </summary>
    public static readonly FloatEnum Right = new("float-right");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly FloatEnum Start = new("float-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly FloatEnum End = new("float-end");
}
