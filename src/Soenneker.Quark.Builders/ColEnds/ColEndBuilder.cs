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
    /// Adds the at Col End utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ColEndBuilder At(int value) => ChainValue(value.ToString());
    /// <summary>
    /// Adds an arbitrary col end utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ColEndBuilder Token(string value) => ChainValue(UtilityToken.WithPrefix(value, "col-end-"));

}
