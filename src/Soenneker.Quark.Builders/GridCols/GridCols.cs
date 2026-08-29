namespace Soenneker.Quark;

/// <summary>
/// Represents the grid cols.
/// </summary>
[TailwindModifiers(typeof(GridColsBuilder))]
public static partial class GridCols
{
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static GridColsBuilder Is1 => new("grid-cols-1");
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static GridColsBuilder Is2 => new("grid-cols-2");
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static GridColsBuilder Is3 => new("grid-cols-3");
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static GridColsBuilder Is4 => new("grid-cols-4");
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static GridColsBuilder Is5 => new("grid-cols-5");
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public static GridColsBuilder Is6 => new("grid-cols-6");
    /// <summary>
    /// Gets or sets is7.
    /// </summary>
    public static GridColsBuilder Is7 => new("grid-cols-7");
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static GridColsBuilder Is8 => new("grid-cols-8");
    /// <summary>
    /// Gets or sets is9.
    /// </summary>
    public static GridColsBuilder Is9 => new("grid-cols-9");
    /// <summary>
    /// Gets or sets is10.
    /// </summary>
    public static GridColsBuilder Is10 => new("grid-cols-10");
    /// <summary>
    /// Gets or sets is11.
    /// </summary>
    public static GridColsBuilder Is11 => new("grid-cols-11");
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static GridColsBuilder Is12 => new("grid-cols-12");
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static GridColsBuilder None => new("grid-cols-none");
    /// <summary>
    /// Gets or sets subgrid.
    /// </summary>
    public static GridColsBuilder Subgrid => new("grid-cols-subgrid");
    /// <summary>
    /// Adds the count Grid Cols utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GridColsBuilder Count(int value) => new("grid-cols-" + value);
    /// <summary>
    /// Adds an arbitrary grid cols utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GridColsBuilder Token(string value) => new("grid-cols-" + value);
}
