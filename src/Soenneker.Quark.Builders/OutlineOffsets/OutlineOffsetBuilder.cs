namespace Soenneker.Quark;

/// <summary>
/// Represents the outline offset builder.
/// </summary>
[TailwindPrefix("outline-offset-", Responsive = true)]
public sealed class OutlineOffsetBuilder : ResponsiveUtilityBuilder<OutlineOffsetBuilder>
{
    internal OutlineOffsetBuilder()
    {
    }

    internal OutlineOffsetBuilder(OutlineOffsetEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal OutlineOffsetBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public OutlineOffsetBuilder Is0 => ChainValue(OutlineOffsetEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public OutlineOffsetBuilder Is1 => ChainValue(OutlineOffsetEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public OutlineOffsetBuilder Is2 => ChainValue(OutlineOffsetEnum.Is2Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public OutlineOffsetBuilder Is4 => ChainValue(OutlineOffsetEnum.Is4Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public OutlineOffsetBuilder Is8 => ChainValue(OutlineOffsetEnum.Is8Value);
    /// <summary>
    /// Adds an arbitrary outline offset utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public OutlineOffsetBuilder Token(string value) => ChainValue("outline-offset-" + value);

}
