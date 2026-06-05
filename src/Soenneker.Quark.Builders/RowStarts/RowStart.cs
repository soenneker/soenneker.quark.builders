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
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static RowStartBuilder At(int value) => new(value.ToString());
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static RowStartBuilder Token(string value) => new("row-start-" + value);
}
