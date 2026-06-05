namespace Soenneker.Quark;

/// <summary>
/// Represents the underline offset builder.
/// </summary>
[TailwindPrefix("underline-offset-", Responsive = true)]
public sealed class UnderlineOffsetBuilder : ResponsiveUtilityBuilder<UnderlineOffsetBuilder>
{
    internal UnderlineOffsetBuilder()
    {
    }

    internal UnderlineOffsetBuilder(UnderlineOffsetEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal UnderlineOffsetBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public UnderlineOffsetBuilder Auto => ChainValue(UnderlineOffsetEnum.AutoValue);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public UnderlineOffsetBuilder Is0 => ChainValue(UnderlineOffsetEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public UnderlineOffsetBuilder Is1 => ChainValue(UnderlineOffsetEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public UnderlineOffsetBuilder Is2 => ChainValue(UnderlineOffsetEnum.Is2Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public UnderlineOffsetBuilder Is4 => ChainValue(UnderlineOffsetEnum.Is4Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public UnderlineOffsetBuilder Is8 => ChainValue(UnderlineOffsetEnum.Is8Value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public UnderlineOffsetBuilder Token(string value) => ChainValue("underline-offset-" + value);

}
