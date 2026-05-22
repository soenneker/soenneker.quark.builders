using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class GridAutoFlowEnum
{
    public static readonly GridAutoFlowEnum Row = new("grid-flow-row");
    public static readonly GridAutoFlowEnum Col = new("grid-flow-col");
    public static readonly GridAutoFlowEnum Dense = new("grid-flow-dense");
    public static readonly GridAutoFlowEnum RowDense = new("grid-flow-row-dense");
    public static readonly GridAutoFlowEnum ColDense = new("grid-flow-col-dense");
}
