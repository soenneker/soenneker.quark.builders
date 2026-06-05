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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public OutlineOffsetBuilder Token(string value) => ChainValue("outline-offset-" + value);

}
