namespace Soenneker.Quark;

/// <summary>
/// Represents the col start.
/// </summary>
[TailwindModifiers(typeof(ColStartBuilder))]
public static partial class ColStart
{
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static ColStartBuilder Is1 => new("col-start-1");
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static ColStartBuilder Is2 => new("col-start-2");
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static ColStartBuilder Auto => new("col-start-auto");
    /// <summary>
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ColStartBuilder At(int value) => new(value.ToString());
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ColStartBuilder Token(string value) => new("col-start-" + value);
}
