namespace Soenneker.Quark;

/// <summary>
/// Represents the auto cols.
/// </summary>
[TailwindModifiers(typeof(AutoColsBuilder))]
public static partial class AutoCols
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static AutoColsBuilder Auto => new(AutoColsEnum.Auto);
    /// <summary>
    /// Gets or sets min.
    /// </summary>
    public static AutoColsBuilder Min => new(AutoColsEnum.Min);
    /// <summary>
    /// Gets or sets max.
    /// </summary>
    public static AutoColsBuilder Max => new(AutoColsEnum.Max);
    /// <summary>
    /// Gets or sets fr.
    /// </summary>
    public static AutoColsBuilder Fr => new(AutoColsEnum.Fr);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static AutoColsBuilder Token(string value) => new($"auto-cols-{value}");
}