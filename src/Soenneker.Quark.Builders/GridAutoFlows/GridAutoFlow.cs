namespace Soenneker.Quark;

/// <summary>
/// Represents the grid auto flow.
/// </summary>
[TailwindModifiers(typeof(GridAutoFlowBuilder))]
public static partial class GridAutoFlow
{
    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public static GridAutoFlowBuilder Row => new(GridAutoFlowEnum.Row);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public static GridAutoFlowBuilder Col => new(GridAutoFlowEnum.Col);
    /// <summary>
    /// Gets or sets dense.
    /// </summary>
    public static GridAutoFlowBuilder Dense => new(GridAutoFlowEnum.Dense);
    /// <summary>
    /// Gets or sets row dense.
    /// </summary>
    public static GridAutoFlowBuilder RowDense => new(GridAutoFlowEnum.RowDense);
    /// <summary>
    /// Gets or sets col dense.
    /// </summary>
    public static GridAutoFlowBuilder ColDense => new(GridAutoFlowEnum.ColDense);
    /// <summary>
    /// Adds an arbitrary grid auto flow utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GridAutoFlowBuilder Token(string value) => new(value.StartsWith("grid-flow-") ? value : $"grid-flow-{value}");
}
