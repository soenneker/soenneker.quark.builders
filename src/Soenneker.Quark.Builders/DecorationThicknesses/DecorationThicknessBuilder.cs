namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration thickness builder.
/// </summary>
[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationThicknessBuilder : FinalClassUtilityBuilder<DecorationThicknessBuilder>
{
    internal DecorationThicknessBuilder()
    {
    }

    internal DecorationThicknessBuilder(DecorationThicknessEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal DecorationThicknessBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public DecorationThicknessBuilder Auto => ChainClass(DecorationThicknessEnum.AutoValue);
    /// <summary>
    /// Gets or sets from font.
    /// </summary>
    public DecorationThicknessBuilder FromFont => ChainClass(DecorationThicknessEnum.FromFontValue);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public DecorationThicknessBuilder Is0 => ChainClass(DecorationThicknessEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public DecorationThicknessBuilder Is1 => ChainClass(DecorationThicknessEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public DecorationThicknessBuilder Is2 => ChainClass(DecorationThicknessEnum.Is2Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public DecorationThicknessBuilder Is4 => ChainClass(DecorationThicknessEnum.Is4Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public DecorationThicknessBuilder Is8 => ChainClass(DecorationThicknessEnum.Is8Value);
    /// <summary>
    /// Adds an arbitrary decoration thickness utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DecorationThicknessBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "decoration-"));

}
