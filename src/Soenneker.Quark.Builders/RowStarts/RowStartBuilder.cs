namespace Soenneker.Quark;

/// <summary>
/// Represents the row start builder.
/// </summary>
[TailwindPrefix("row-start-", Responsive = true)]
public sealed class RowStartBuilder : ResponsiveUtilityBuilder<RowStartBuilder>
{
    internal RowStartBuilder()
    {
    }

    internal RowStartBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public RowStartBuilder Is1 => ChainValue("row-start-1");
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public RowStartBuilder Auto => ChainValue("auto");
    /// <summary>
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RowStartBuilder At(int value) => ChainValue(value.ToString());
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RowStartBuilder Token(string value) => ChainValue("row-start-" + value);

}
