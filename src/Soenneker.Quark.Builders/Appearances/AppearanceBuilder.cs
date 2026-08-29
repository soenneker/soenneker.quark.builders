namespace Soenneker.Quark;

/// <summary>
/// Represents the appearance builder.
/// </summary>
[TailwindPrefix("appearance-", Responsive = true)]
public sealed class AppearanceBuilder : FinalClassUtilityBuilder<AppearanceBuilder>
{
    internal AppearanceBuilder() {}
    internal AppearanceBuilder(AppearanceEnum value) : base(value.Value) {}
    internal AppearanceBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public AppearanceBuilder None => ChainClass(AppearanceEnum.None.Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public AppearanceBuilder Auto => ChainClass(AppearanceEnum.Auto.Value);
    /// <summary>
    /// Adds an arbitrary appearance utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public AppearanceBuilder Token(string value) => ChainClass(value.StartsWith("appearance-") ? value : $"appearance-{value}");
}
