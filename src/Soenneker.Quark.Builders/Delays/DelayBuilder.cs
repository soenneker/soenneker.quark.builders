namespace Soenneker.Quark;

/// <summary>
/// Represents the delay builder.
/// </summary>
[TailwindPrefix("delay-", Responsive = true)]
public sealed class DelayBuilder : ResponsiveUtilityBuilder<DelayBuilder>
{
    internal DelayBuilder()
    {
    }

    internal DelayBuilder(DelayEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DelayBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is75.
    /// </summary>
    public DelayBuilder Is75 => ChainValue(DelayEnum.Is75Value);
    /// <summary>
    /// Gets or sets is100.
    /// </summary>
    public DelayBuilder Is100 => ChainValue(DelayEnum.Is100Value);
    /// <summary>
    /// Gets or sets is150.
    /// </summary>
    public DelayBuilder Is150 => ChainValue(DelayEnum.Is150Value);
    /// <summary>
    /// Gets or sets is200.
    /// </summary>
    public DelayBuilder Is200 => ChainValue(DelayEnum.Is200Value);
    /// <summary>
    /// Gets or sets is300.
    /// </summary>
    public DelayBuilder Is300 => ChainValue(DelayEnum.Is300Value);
    /// <summary>
    /// Gets or sets is500.
    /// </summary>
    public DelayBuilder Is500 => ChainValue(DelayEnum.Is500Value);
    /// <summary>
    /// Gets or sets is700.
    /// </summary>
    public DelayBuilder Is700 => ChainValue(DelayEnum.Is700Value);
    /// <summary>
    /// Gets or sets is1000.
    /// </summary>
    public DelayBuilder Is1000 => ChainValue(DelayEnum.Is1000Value);
    /// <summary>
    /// Adds an arbitrary delay utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DelayBuilder Token(string value) => ChainValue("delay-" + value);

}
