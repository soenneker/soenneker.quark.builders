using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the flex enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FlexEnum
{
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly FlexEnum Is1 = new("flex-1");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly FlexEnum Auto = new("flex-auto");
    /// <summary>
    /// The initial.
    /// </summary>
    public static readonly FlexEnum Initial = new("flex-initial");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly FlexEnum None = new("flex-none");
    /// <summary>
    /// The wrap.
    /// </summary>
    public static readonly FlexEnum Wrap = new("flex-wrap");
    /// <summary>
    /// The wrap reverse.
    /// </summary>
    public static readonly FlexEnum WrapReverse = new("flex-wrap-reverse");
    /// <summary>
    /// The no wrap.
    /// </summary>
    public static readonly FlexEnum NoWrap = new("flex-nowrap");
    /// <summary>
    /// The row.
    /// </summary>
    public static readonly FlexEnum Row = new("flex-row");
    /// <summary>
    /// The row reverse.
    /// </summary>
    public static readonly FlexEnum RowReverse = new("flex-row-reverse");
    /// <summary>
    /// The col.
    /// </summary>
    public static readonly FlexEnum Col = new("flex-col");
    /// <summary>
    /// The col reverse.
    /// </summary>
    public static readonly FlexEnum ColReverse = new("flex-col-reverse");
}
