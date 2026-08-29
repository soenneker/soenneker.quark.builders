namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration thickness builder.
/// </summary>
[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationThicknessBuilder : ResponsiveUtilityBuilder<DecorationThicknessBuilder>
{
    internal DecorationThicknessBuilder()
    {
    }

    internal DecorationThicknessBuilder(DecorationThicknessEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DecorationThicknessBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public DecorationThicknessBuilder Auto => ChainValue(DecorationThicknessEnum.AutoValue);
    /// <summary>
    /// Gets or sets from font.
    /// </summary>
    public DecorationThicknessBuilder FromFont => ChainValue(DecorationThicknessEnum.FromFontValue);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public DecorationThicknessBuilder Is0 => ChainValue(DecorationThicknessEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public DecorationThicknessBuilder Is1 => ChainValue(DecorationThicknessEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public DecorationThicknessBuilder Is2 => ChainValue(DecorationThicknessEnum.Is2Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public DecorationThicknessBuilder Is4 => ChainValue(DecorationThicknessEnum.Is4Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public DecorationThicknessBuilder Is8 => ChainValue(DecorationThicknessEnum.Is8Value);
    /// <summary>
    /// Adds an arbitrary decoration thickness utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DecorationThicknessBuilder Token(string value) => ChainValue("decoration-" + value);

}
