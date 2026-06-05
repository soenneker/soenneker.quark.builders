namespace Soenneker.Quark;

/// <summary>
/// Represents the col start builder.
/// </summary>
[TailwindPrefix("col-start-", Responsive = true)]
public sealed class ColStartBuilder : ResponsiveUtilityBuilder<ColStartBuilder>
{
    internal ColStartBuilder()
    {
    }

    internal ColStartBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public ColStartBuilder Is1 => ChainValue("col-start-1");
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public ColStartBuilder Is2 => ChainValue("col-start-2");
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public ColStartBuilder Auto => ChainValue("auto");
    /// <summary>
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public ColStartBuilder At(int value) => ChainValue(value.ToString());
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public ColStartBuilder Token(string value) => ChainValue("col-start-" + value);

}
