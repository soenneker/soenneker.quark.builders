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
    /// Adds the at Row Start utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RowStartBuilder At(int value) => ChainValue(value.ToString());
    /// <summary>
    /// Adds an arbitrary row start utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RowStartBuilder Token(string value) => ChainValue("row-start-" + value);

}
