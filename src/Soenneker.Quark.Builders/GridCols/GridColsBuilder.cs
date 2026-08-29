namespace Soenneker.Quark;

/// <summary>
/// Represents the grid cols builder.
/// </summary>
[TailwindPrefix("grid-cols-", Responsive = true)]
public sealed class GridColsBuilder : ResponsiveUtilityBuilder<GridColsBuilder>
{
    internal GridColsBuilder()
    {
    }

    internal GridColsBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public GridColsBuilder Is1 => ChainValue("grid-cols-1");
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public GridColsBuilder Is2 => ChainValue("grid-cols-2");
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public GridColsBuilder Is3 => ChainValue("grid-cols-3");
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public GridColsBuilder Is4 => ChainValue("grid-cols-4");
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public GridColsBuilder Is5 => ChainValue("grid-cols-5");
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public GridColsBuilder Is6 => ChainValue("grid-cols-6");
    /// <summary>
    /// Gets or sets is7.
    /// </summary>
    public GridColsBuilder Is7 => ChainValue("grid-cols-7");
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public GridColsBuilder Is8 => ChainValue("grid-cols-8");
    /// <summary>
    /// Gets or sets is9.
    /// </summary>
    public GridColsBuilder Is9 => ChainValue("grid-cols-9");
    /// <summary>
    /// Gets or sets is10.
    /// </summary>
    public GridColsBuilder Is10 => ChainValue("grid-cols-10");
    /// <summary>
    /// Gets or sets is11.
    /// </summary>
    public GridColsBuilder Is11 => ChainValue("grid-cols-11");
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public GridColsBuilder Is12 => ChainValue("grid-cols-12");
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public GridColsBuilder None => ChainValue("grid-cols-none");
    /// <summary>
    /// Gets or sets subgrid.
    /// </summary>
    public GridColsBuilder Subgrid => ChainValue("grid-cols-subgrid");
    /// <summary>
    /// Adds the count Grid Cols utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GridColsBuilder Count(int value) => ChainValue("grid-cols-" + value);
    /// <summary>
    /// Adds an arbitrary grid cols utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GridColsBuilder Token(string value) => ChainValue("grid-cols-" + value);

}
