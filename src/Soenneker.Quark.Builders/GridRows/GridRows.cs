namespace Soenneker.Quark;

/// <summary>
/// Represents the grid rows.
/// </summary>
[TailwindModifiers(typeof(GridRowsBuilder))]
public static partial class GridRows
{
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static GridRowsBuilder Is1 => new("grid-rows-1");
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static GridRowsBuilder Is2 => new("grid-rows-2");
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static GridRowsBuilder Is3 => new("grid-rows-3");
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static GridRowsBuilder Is4 => new("grid-rows-4");
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static GridRowsBuilder Is5 => new("grid-rows-5");
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public static GridRowsBuilder Is6 => new("grid-rows-6");
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static GridRowsBuilder None => new("grid-rows-none");
    /// <summary>
    /// Gets or sets subgrid.
    /// </summary>
    public static GridRowsBuilder Subgrid => new("grid-rows-subgrid");
    /// <summary>
    /// Adds the count Grid Rows utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GridRowsBuilder Count(int value) => new("grid-rows-" + value);
    /// <summary>
    /// Adds an arbitrary grid rows utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GridRowsBuilder Token(string value) => new("grid-rows-" + value);
}
