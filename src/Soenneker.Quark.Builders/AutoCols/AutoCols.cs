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
    /// Adds an arbitrary auto cols utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static AutoColsBuilder Token(string value) => new($"auto-cols-{value}");
}
