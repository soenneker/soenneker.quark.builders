namespace Soenneker.Quark;

[TailwindModifiers(typeof(GridAutoFlowBuilder))]
public static partial class GridAutoFlow
{
    public static GridAutoFlowBuilder Row => new(GridAutoFlowEnum.Row);
    public static GridAutoFlowBuilder Col => new(GridAutoFlowEnum.Col);
    public static GridAutoFlowBuilder Dense => new(GridAutoFlowEnum.Dense);
    public static GridAutoFlowBuilder RowDense => new(GridAutoFlowEnum.RowDense);
    public static GridAutoFlowBuilder ColDense => new(GridAutoFlowEnum.ColDense);
    public static GridAutoFlowBuilder Token(string value) => new(value.StartsWith("grid-flow-") ? value : $"grid-flow-{value}");
}
