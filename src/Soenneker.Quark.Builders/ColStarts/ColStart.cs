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
    /// Adds the at Col Start utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ColStartBuilder At(int value) => new(value.ToString());
    /// <summary>
    /// Adds an arbitrary col start utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ColStartBuilder Token(string value) => new("col-start-" + value);
}
