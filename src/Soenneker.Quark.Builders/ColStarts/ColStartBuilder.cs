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
    /// Adds the at Col Start utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ColStartBuilder At(int value) => ChainValue(value.ToString());
    /// <summary>
    /// Adds an arbitrary col start utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ColStartBuilder Token(string value) => ChainValue("col-start-" + value);

}
