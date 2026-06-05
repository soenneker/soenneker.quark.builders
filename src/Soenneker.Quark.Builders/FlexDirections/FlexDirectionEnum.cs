using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the flex direction enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FlexDirectionEnum
{
    /// <summary>
    /// The row.
    /// </summary>
    public static readonly FlexDirectionEnum Row = new("flex-row");
    /// <summary>
    /// The row reverse.
    /// </summary>
    public static readonly FlexDirectionEnum RowReverse = new("flex-row-reverse");
    /// <summary>
    /// The col.
    /// </summary>
    public static readonly FlexDirectionEnum Col = new("flex-col");
    /// <summary>
    /// The col reverse.
    /// </summary>
    public static readonly FlexDirectionEnum ColReverse = new("flex-col-reverse");
}
