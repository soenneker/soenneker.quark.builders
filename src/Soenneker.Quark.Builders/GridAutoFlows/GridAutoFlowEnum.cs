using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the grid auto flow enum.
/// </summary>
[EnumValue<string>]
public sealed partial class GridAutoFlowEnum
{
    /// <summary>
    /// The row.
    /// </summary>
    public static readonly GridAutoFlowEnum Row = new("grid-flow-row");
    /// <summary>
    /// The col.
    /// </summary>
    public static readonly GridAutoFlowEnum Col = new("grid-flow-col");
    /// <summary>
    /// The dense.
    /// </summary>
    public static readonly GridAutoFlowEnum Dense = new("grid-flow-dense");
    /// <summary>
    /// The row dense.
    /// </summary>
    public static readonly GridAutoFlowEnum RowDense = new("grid-flow-row-dense");
    /// <summary>
    /// The col dense.
    /// </summary>
    public static readonly GridAutoFlowEnum ColDense = new("grid-flow-col-dense");
}
