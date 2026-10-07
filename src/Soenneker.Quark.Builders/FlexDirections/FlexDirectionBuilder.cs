namespace Soenneker.Quark;

/// <summary>
/// Builds flex-direction utilities without changing display. Set Display.Flex or Display.InlineFlex separately.
/// </summary>
[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexDirectionBuilder : FinalClassUtilityBuilder<FlexDirectionBuilder>
{
    internal FlexDirectionBuilder()
    {
    }

    internal FlexDirectionBuilder(FlexDirectionEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal FlexDirectionBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public FlexDirectionBuilder Row => ChainClass(FlexDirectionEnum.RowValue);
    /// <summary>
    /// Gets or sets row reverse.
    /// </summary>
    public FlexDirectionBuilder RowReverse => ChainClass(FlexDirectionEnum.RowReverseValue);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public FlexDirectionBuilder Col => ChainClass(FlexDirectionEnum.ColValue);
    /// <summary>
    /// Gets or sets col reverse.
    /// </summary>
    public FlexDirectionBuilder ColReverse => ChainClass(FlexDirectionEnum.ColReverseValue);
    /// <summary>
    /// Adds an arbitrary flex direction utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FlexDirectionBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "flex-"));
}
