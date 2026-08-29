namespace Soenneker.Quark;

/// <summary>
/// Represents the grid auto flow builder.
/// </summary>
[TailwindPrefix("grid-flow-", Responsive = true)]
public sealed class GridAutoFlowBuilder : FinalClassUtilityBuilder<GridAutoFlowBuilder>
{
    internal GridAutoFlowBuilder() {}
    internal GridAutoFlowBuilder(GridAutoFlowEnum value) : base(value.Value) {}
    internal GridAutoFlowBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public GridAutoFlowBuilder Row => ChainClass(GridAutoFlowEnum.Row.Value);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public GridAutoFlowBuilder Col => ChainClass(GridAutoFlowEnum.Col.Value);
    /// <summary>
    /// Gets or sets dense.
    /// </summary>
    public GridAutoFlowBuilder Dense => ChainClass(GridAutoFlowEnum.Dense.Value);
    /// <summary>
    /// Gets or sets row dense.
    /// </summary>
    public GridAutoFlowBuilder RowDense => ChainClass(GridAutoFlowEnum.RowDense.Value);
    /// <summary>
    /// Gets or sets col dense.
    /// </summary>
    public GridAutoFlowBuilder ColDense => ChainClass(GridAutoFlowEnum.ColDense.Value);
    /// <summary>
    /// Adds an arbitrary grid auto flow utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GridAutoFlowBuilder Token(string value) => ChainClass(value.StartsWith("grid-flow-") ? value : $"grid-flow-{value}");
}
