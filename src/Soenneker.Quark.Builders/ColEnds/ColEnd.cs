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
    /// Adds the at Col End utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ColEndBuilder At(int value) => new(value.ToString());
    /// <summary>
    /// Adds an arbitrary col end utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ColEndBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "col-end-"));
}
