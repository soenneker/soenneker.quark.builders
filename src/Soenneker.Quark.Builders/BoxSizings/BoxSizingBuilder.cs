namespace Soenneker.Quark;

/// <summary>
/// Represents the box sizing builder.
/// </summary>
[TailwindPrefix("box-", Responsive = true)]
public sealed class BoxSizingBuilder : FinalClassUtilityBuilder<BoxSizingBuilder>
{
    internal BoxSizingBuilder() {}
    internal BoxSizingBuilder(BoxSizingEnum value) : base(value.Value) {}
    internal BoxSizingBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public BoxSizingBuilder Border => ChainClass(BoxSizingEnum.Border.Value);
    /// <summary>
    /// Gets or sets content.
    /// </summary>
    public BoxSizingBuilder Content => ChainClass(BoxSizingEnum.Content.Value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public BoxSizingBuilder Token(string value) => ChainClass(value.StartsWith("box-") ? value : $"box-{value}");
}
