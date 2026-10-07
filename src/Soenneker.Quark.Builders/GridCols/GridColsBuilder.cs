namespace Soenneker.Quark;

/// <summary>
/// Represents the grid cols builder.
/// </summary>
[TailwindPrefix("grid-cols-", Responsive = true)]
public sealed class GridColsBuilder : FinalClassUtilityBuilder<GridColsBuilder>
{
    internal GridColsBuilder()
    {
    }

    internal GridColsBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public GridColsBuilder Is1 => ChainClass("grid-cols-1");
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public GridColsBuilder Is2 => ChainClass("grid-cols-2");
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public GridColsBuilder Is3 => ChainClass("grid-cols-3");
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public GridColsBuilder Is4 => ChainClass("grid-cols-4");
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public GridColsBuilder Is5 => ChainClass("grid-cols-5");
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public GridColsBuilder Is6 => ChainClass("grid-cols-6");
    /// <summary>
    /// Gets or sets is7.
    /// </summary>
    public GridColsBuilder Is7 => ChainClass("grid-cols-7");
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public GridColsBuilder Is8 => ChainClass("grid-cols-8");
    /// <summary>
    /// Gets or sets is9.
    /// </summary>
    public GridColsBuilder Is9 => ChainClass("grid-cols-9");
    /// <summary>
    /// Gets or sets is10.
    /// </summary>
    public GridColsBuilder Is10 => ChainClass("grid-cols-10");
    /// <summary>
    /// Gets or sets is11.
    /// </summary>
    public GridColsBuilder Is11 => ChainClass("grid-cols-11");
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public GridColsBuilder Is12 => ChainClass("grid-cols-12");
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public GridColsBuilder None => ChainClass("grid-cols-none");
    /// <summary>
    /// Gets or sets subgrid.
    /// </summary>
    public GridColsBuilder Subgrid => ChainClass("grid-cols-subgrid");
    /// <summary>
    /// Adds the count Grid Cols utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GridColsBuilder Count(int value) => ChainClass("grid-cols-" + value);
    /// <summary>
    /// Adds an arbitrary grid cols utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GridColsBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "grid-cols-"));

}
