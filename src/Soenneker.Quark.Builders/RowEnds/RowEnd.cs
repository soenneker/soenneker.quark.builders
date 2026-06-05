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
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static RowEndBuilder At(int value) => new(value.ToString());
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static RowEndBuilder Token(string value) => new("row-end-" + value);
}
