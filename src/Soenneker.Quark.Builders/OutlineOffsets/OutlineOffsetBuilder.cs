namespace Soenneker.Quark;

/// <summary>
/// Represents the outline offset builder.
/// </summary>
[TailwindPrefix("outline-offset-", Responsive = true)]
public sealed class OutlineOffsetBuilder : FinalClassUtilityBuilder<OutlineOffsetBuilder>
{
    internal OutlineOffsetBuilder()
    {
    }

    internal OutlineOffsetBuilder(OutlineOffsetEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal OutlineOffsetBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public OutlineOffsetBuilder Is0 => ChainClass(OutlineOffsetEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public OutlineOffsetBuilder Is1 => ChainClass(OutlineOffsetEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public OutlineOffsetBuilder Is2 => ChainClass(OutlineOffsetEnum.Is2Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public OutlineOffsetBuilder Is4 => ChainClass(OutlineOffsetEnum.Is4Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public OutlineOffsetBuilder Is8 => ChainClass(OutlineOffsetEnum.Is8Value);
    /// <summary>
    /// Adds an arbitrary outline offset utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public OutlineOffsetBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "outline-offset-"));

}
