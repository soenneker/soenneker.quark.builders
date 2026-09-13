namespace Soenneker.Quark;

/// <summary>
/// Builds flex-direction utilities without changing display. Set Display.Flex or Display.InlineFlex separately.
/// </summary>
[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexDirectionBuilder : ResponsiveUtilityBuilder<FlexDirectionBuilder>
{
    internal FlexDirectionBuilder()
    {
    }

    internal FlexDirectionBuilder(FlexDirectionEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal FlexDirectionBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public FlexDirectionBuilder Row => ChainValue(FlexDirectionEnum.RowValue);
    /// <summary>
    /// Gets or sets row reverse.
    /// </summary>
    public FlexDirectionBuilder RowReverse => ChainValue(FlexDirectionEnum.RowReverseValue);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public FlexDirectionBuilder Col => ChainValue(FlexDirectionEnum.ColValue);
    /// <summary>
    /// Gets or sets col reverse.
    /// </summary>
    public FlexDirectionBuilder ColReverse => ChainValue(FlexDirectionEnum.ColReverseValue);
    /// <summary>
    /// Adds an arbitrary flex direction utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FlexDirectionBuilder Token(string value) => ChainValue(UtilityToken.WithPrefix(value, "flex-"));
}
