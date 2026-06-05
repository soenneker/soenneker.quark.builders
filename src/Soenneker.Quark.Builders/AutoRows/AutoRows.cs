namespace Soenneker.Quark;

/// <summary>
/// Represents the auto rows.
/// </summary>
[TailwindModifiers(typeof(AutoRowsBuilder))]
public static partial class AutoRows
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static AutoRowsBuilder Auto => new(AutoRowsEnum.Auto);
    /// <summary>
    /// Gets or sets min.
    /// </summary>
    public static AutoRowsBuilder Min => new(AutoRowsEnum.Min);
    /// <summary>
    /// Gets or sets max.
    /// </summary>
    public static AutoRowsBuilder Max => new(AutoRowsEnum.Max);
    /// <summary>
    /// Gets or sets fr.
    /// </summary>
    public static AutoRowsBuilder Fr => new(AutoRowsEnum.Fr);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static AutoRowsBuilder Token(string value) => new($"auto-rows-{value}");
}
