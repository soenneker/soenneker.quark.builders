namespace Soenneker.Quark;

/// <summary>
/// Represents the row end builder.
/// </summary>
[TailwindPrefix("row-end-", Responsive = true)]
public sealed class RowEndBuilder : ResponsiveUtilityBuilder<RowEndBuilder>
{
    internal RowEndBuilder()
    {
    }

    internal RowEndBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public RowEndBuilder Auto => ChainValue("auto");
    /// <summary>
    /// Adds the at Row End utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RowEndBuilder At(int value) => ChainValue(value.ToString());
    /// <summary>
    /// Adds an arbitrary row end utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RowEndBuilder Token(string value) => ChainValue("row-end-" + value);

}
