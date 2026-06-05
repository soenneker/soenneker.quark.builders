namespace Soenneker.Quark;

/// <summary>
/// Represents the col end.
/// </summary>
[TailwindModifiers(typeof(ColEndBuilder))]
public static partial class ColEnd
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static ColEndBuilder Auto => new("col-end-auto");
    /// <summary>
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ColEndBuilder At(int value) => new(value.ToString());
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ColEndBuilder Token(string value) => new("col-end-" + value);
}
