namespace Soenneker.Quark;

/// <summary>
/// Represents the col end builder.
/// </summary>
[TailwindPrefix("col-end-", Responsive = true)]
public sealed class ColEndBuilder : ResponsiveUtilityBuilder<ColEndBuilder>
{
    internal ColEndBuilder()
    {
    }

    internal ColEndBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public ColEndBuilder Auto => ChainValue("auto");
    /// <summary>
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public ColEndBuilder At(int value) => ChainValue(value.ToString());
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public ColEndBuilder Token(string value) => ChainValue("col-end-" + value);

}
