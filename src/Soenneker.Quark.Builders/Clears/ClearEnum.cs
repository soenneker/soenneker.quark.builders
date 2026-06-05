using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the clear enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ClearEnum
{
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly ClearEnum Start = new("clear-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly ClearEnum End = new("clear-end");
    /// <summary>
    /// The left.
    /// </summary>
    public static readonly ClearEnum Left = new("clear-left");
    /// <summary>
    /// The right.
    /// </summary>
    public static readonly ClearEnum Right = new("clear-right");
    /// <summary>
    /// The both.
    /// </summary>
    public static readonly ClearEnum Both = new("clear-both");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ClearEnum None = new("clear-none");
}
