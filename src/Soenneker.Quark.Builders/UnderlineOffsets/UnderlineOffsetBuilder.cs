namespace Soenneker.Quark;

/// <summary>
/// Represents the underline offset builder.
/// </summary>
[TailwindPrefix("underline-offset-", Responsive = true)]
public sealed class UnderlineOffsetBuilder : FinalClassUtilityBuilder<UnderlineOffsetBuilder>
{
    internal UnderlineOffsetBuilder()
    {
    }

    internal UnderlineOffsetBuilder(UnderlineOffsetEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal UnderlineOffsetBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public UnderlineOffsetBuilder Auto => ChainClass(UnderlineOffsetEnum.AutoValue);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public UnderlineOffsetBuilder Is0 => ChainClass(UnderlineOffsetEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public UnderlineOffsetBuilder Is1 => ChainClass(UnderlineOffsetEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public UnderlineOffsetBuilder Is2 => ChainClass(UnderlineOffsetEnum.Is2Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public UnderlineOffsetBuilder Is4 => ChainClass(UnderlineOffsetEnum.Is4Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public UnderlineOffsetBuilder Is8 => ChainClass(UnderlineOffsetEnum.Is8Value);
    /// <summary>
    /// Adds an arbitrary underline offset utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public UnderlineOffsetBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "underline-offset-"));

}
