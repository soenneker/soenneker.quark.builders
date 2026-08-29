namespace Soenneker.Quark;

/// <summary>
/// Represents the row start.
/// </summary>
[TailwindModifiers(typeof(RowStartBuilder))]
public static partial class RowStart
{
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static RowStartBuilder Is1 => new("row-start-1");
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static RowStartBuilder Auto => new("row-start-auto");
    /// <summary>
    /// Adds the at Row Start utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RowStartBuilder At(int value) => new(value.ToString());
    /// <summary>
    /// Adds an arbitrary row start utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RowStartBuilder Token(string value) => new("row-start-" + value);
}
