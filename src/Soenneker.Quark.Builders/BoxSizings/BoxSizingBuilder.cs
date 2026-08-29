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
    /// Adds an arbitrary box sizing utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public BoxSizingBuilder Token(string value) => ChainClass(value.StartsWith("box-") ? value : $"box-{value}");
}
