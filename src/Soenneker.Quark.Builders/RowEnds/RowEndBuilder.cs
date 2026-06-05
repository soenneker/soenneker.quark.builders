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
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RowEndBuilder At(int value) => ChainValue(value.ToString());
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RowEndBuilder Token(string value) => ChainValue("row-end-" + value);

}
