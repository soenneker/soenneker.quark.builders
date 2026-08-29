namespace Soenneker.Quark;

/// <summary>
/// Represents the appearance.
/// </summary>
[TailwindModifiers(typeof(AppearanceBuilder))]
public static partial class Appearance
{
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static AppearanceBuilder None => new(AppearanceEnum.None);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static AppearanceBuilder Auto => new(AppearanceEnum.Auto);
    /// <summary>
    /// Adds an arbitrary appearance utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static AppearanceBuilder Token(string value) => new(value.StartsWith("appearance-") ? value : $"appearance-{value}");
}
