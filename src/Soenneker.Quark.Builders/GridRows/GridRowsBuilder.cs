namespace Soenneker.Quark;

/// <summary>
/// Represents the grid rows builder.
/// </summary>
[TailwindPrefix("grid-rows-", Responsive = true)]
public sealed class GridRowsBuilder : ResponsiveUtilityBuilder<GridRowsBuilder>
{
    internal GridRowsBuilder()
    {
    }

    internal GridRowsBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public GridRowsBuilder Is1 => ChainValue("grid-rows-1");
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public GridRowsBuilder Is2 => ChainValue("grid-rows-2");
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public GridRowsBuilder Is3 => ChainValue("grid-rows-3");
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public GridRowsBuilder Is4 => ChainValue("grid-rows-4");
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public GridRowsBuilder Is5 => ChainValue("grid-rows-5");
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public GridRowsBuilder Is6 => ChainValue("grid-rows-6");
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public GridRowsBuilder None => ChainValue("grid-rows-none");
    /// <summary>
    /// Gets or sets subgrid.
    /// </summary>
    public GridRowsBuilder Subgrid => ChainValue("grid-rows-subgrid");
    /// <summary>
    /// Executes the count operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public GridRowsBuilder Count(int value) => ChainValue("grid-rows-" + value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public GridRowsBuilder Token(string value) => ChainValue("grid-rows-" + value);

}
