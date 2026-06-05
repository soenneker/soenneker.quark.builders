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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static AppearanceBuilder Token(string value) => new(value.StartsWith("appearance-") ? value : $"appearance-{value}");
}
