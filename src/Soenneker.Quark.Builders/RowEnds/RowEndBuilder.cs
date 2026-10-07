namespace Soenneker.Quark;

/// <summary>
/// Represents the row end builder.
/// </summary>
[TailwindPrefix("row-end-", Responsive = true)]
public sealed class RowEndBuilder : FinalClassUtilityBuilder<RowEndBuilder>
{
    internal RowEndBuilder()
    {
    }

    internal RowEndBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public RowEndBuilder Auto => ChainClass("row-end-auto");
    /// <summary>
    /// Adds the at Row End utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RowEndBuilder At(int value) => ChainClass("row-end-" + value);
    /// <summary>
    /// Adds an arbitrary row end utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RowEndBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "row-end-"));

}
