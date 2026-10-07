namespace Soenneker.Quark;

/// <summary>
/// Represents the col start builder.
/// </summary>
[TailwindPrefix("col-start-", Responsive = true)]
public sealed class ColStartBuilder : FinalClassUtilityBuilder<ColStartBuilder>
{
    internal ColStartBuilder()
    {
    }

    internal ColStartBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public ColStartBuilder Is1 => ChainClass("col-start-1");
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public ColStartBuilder Is2 => ChainClass("col-start-2");
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public ColStartBuilder Auto => ChainClass("col-start-auto");
    /// <summary>
    /// Adds the at Col Start utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ColStartBuilder At(int value) => ChainClass("col-start-" + value);
    /// <summary>
    /// Adds an arbitrary col start utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ColStartBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "col-start-"));

}
