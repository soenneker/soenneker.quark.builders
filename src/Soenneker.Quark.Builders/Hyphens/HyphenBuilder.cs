namespace Soenneker.Quark;

/// <summary>
/// Represents the hyphen builder.
/// </summary>
[TailwindPrefix("hyphens-", Responsive = true)]
public sealed class HyphenBuilder : FinalClassUtilityBuilder<HyphenBuilder>
{
    internal HyphenBuilder() {}
    internal HyphenBuilder(HyphenEnum value) : base(value.Value) {}
    internal HyphenBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public HyphenBuilder None => ChainClass(HyphenEnum.None.Value);
    /// <summary>
    /// Gets or sets manual.
    /// </summary>
    public HyphenBuilder Manual => ChainClass(HyphenEnum.Manual.Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public HyphenBuilder Auto => ChainClass(HyphenEnum.Auto.Value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public HyphenBuilder Token(string value) => ChainClass(value.StartsWith("hyphens-") ? value : $"hyphens-{value}");
}
