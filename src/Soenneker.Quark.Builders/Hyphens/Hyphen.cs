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
    /// Adds an arbitrary hyphen utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static HyphenBuilder Token(string value) => new(value.StartsWith("hyphens-") ? value : $"hyphens-{value}");
}
