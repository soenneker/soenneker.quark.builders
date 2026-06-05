namespace Soenneker.Quark;

/// <summary>
/// Represents the hyphen.
/// </summary>
[TailwindModifiers(typeof(HyphenBuilder))]
public static partial class Hyphen
{
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static HyphenBuilder None => new(HyphenEnum.None);
    /// <summary>
    /// Gets or sets manual.
    /// </summary>
    public static HyphenBuilder Manual => new(HyphenEnum.Manual);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static HyphenBuilder Auto => new(HyphenEnum.Auto);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static HyphenBuilder Token(string value) => new(value.StartsWith("hyphens-") ? value : $"hyphens-{value}");
}
