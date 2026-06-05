namespace Soenneker.Quark;

/// <summary>
/// Represents the border style builder.
/// </summary>
[TailwindPrefix("border-", Responsive = true)]
public sealed class BorderStyleBuilder : FinalClassUtilityBuilder<BorderStyleBuilder>
{
    internal BorderStyleBuilder() {}
    internal BorderStyleBuilder(BorderStyleEnum value) : base(value.Value) {}
    internal BorderStyleBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets solid.
    /// </summary>
    public BorderStyleBuilder Solid => ChainClass(BorderStyleEnum.Solid.Value);
    /// <summary>
    /// Gets or sets dashed.
    /// </summary>
    public BorderStyleBuilder Dashed => ChainClass(BorderStyleEnum.Dashed.Value);
    /// <summary>
    /// Gets or sets dotted.
    /// </summary>
    public BorderStyleBuilder Dotted => ChainClass(BorderStyleEnum.Dotted.Value);
    /// <summary>
    /// Gets or sets double.
    /// </summary>
    public BorderStyleBuilder Double => ChainClass(BorderStyleEnum.Double.Value);
    /// <summary>
    /// Gets or sets hidden.
    /// </summary>
    public BorderStyleBuilder Hidden => ChainClass(BorderStyleEnum.Hidden.Value);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public BorderStyleBuilder None => ChainClass(BorderStyleEnum.None.Value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public BorderStyleBuilder Token(string value) => ChainClass(value.StartsWith("border-") ? value : $"border-{value}");
}
