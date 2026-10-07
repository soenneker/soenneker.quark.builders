namespace Soenneker.Quark;

/// <summary>
/// Represents the delay builder.
/// </summary>
[TailwindPrefix("delay-", Responsive = true)]
public sealed class DelayBuilder : FinalClassUtilityBuilder<DelayBuilder>
{
    internal DelayBuilder()
    {
    }

    internal DelayBuilder(DelayEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal DelayBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is75.
    /// </summary>
    public DelayBuilder Is75 => ChainClass(DelayEnum.Is75Value);
    /// <summary>
    /// Gets or sets is100.
    /// </summary>
    public DelayBuilder Is100 => ChainClass(DelayEnum.Is100Value);
    /// <summary>
    /// Gets or sets is150.
    /// </summary>
    public DelayBuilder Is150 => ChainClass(DelayEnum.Is150Value);
    /// <summary>
    /// Gets or sets is200.
    /// </summary>
    public DelayBuilder Is200 => ChainClass(DelayEnum.Is200Value);
    /// <summary>
    /// Gets or sets is300.
    /// </summary>
    public DelayBuilder Is300 => ChainClass(DelayEnum.Is300Value);
    /// <summary>
    /// Gets or sets is500.
    /// </summary>
    public DelayBuilder Is500 => ChainClass(DelayEnum.Is500Value);
    /// <summary>
    /// Gets or sets is700.
    /// </summary>
    public DelayBuilder Is700 => ChainClass(DelayEnum.Is700Value);
    /// <summary>
    /// Gets or sets is1000.
    /// </summary>
    public DelayBuilder Is1000 => ChainClass(DelayEnum.Is1000Value);
    /// <summary>
    /// Adds an arbitrary delay utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DelayBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "delay-"));

}
