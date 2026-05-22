namespace Soenneker.Quark;

[TailwindPrefix("grid-flow-", Responsive = true)]
public sealed class GridAutoFlowBuilder : FinalClassUtilityBuilder<GridAutoFlowBuilder>
{
    internal GridAutoFlowBuilder() {}
    internal GridAutoFlowBuilder(GridAutoFlowEnum value) : base(value.Value) {}
    internal GridAutoFlowBuilder(string value) : base(value) {}

    public GridAutoFlowBuilder Row => ChainClass(GridAutoFlowEnum.Row.Value);
    public GridAutoFlowBuilder Col => ChainClass(GridAutoFlowEnum.Col.Value);
    public GridAutoFlowBuilder Dense => ChainClass(GridAutoFlowEnum.Dense.Value);
    public GridAutoFlowBuilder RowDense => ChainClass(GridAutoFlowEnum.RowDense.Value);
    public GridAutoFlowBuilder ColDense => ChainClass(GridAutoFlowEnum.ColDense.Value);
    public GridAutoFlowBuilder Token(string value) => ChainClass(value.StartsWith("grid-flow-") ? value : $"grid-flow-{value}");
}
