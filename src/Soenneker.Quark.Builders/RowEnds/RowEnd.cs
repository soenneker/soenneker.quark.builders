namespace Soenneker.Quark;

/// <summary>
/// Represents the row end.
/// </summary>
[TailwindModifiers(typeof(RowEndBuilder))]
public static partial class RowEnd
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static RowEndBuilder Auto => new("row-end-auto");
    /// <summary>
    /// Adds the at Row End utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RowEndBuilder At(int value) => new(value.ToString());
    /// <summary>
    /// Adds an arbitrary row end utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RowEndBuilder Token(string value) => new("row-end-" + value);
}
