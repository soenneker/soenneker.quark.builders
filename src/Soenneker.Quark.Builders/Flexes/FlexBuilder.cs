namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility builder. Tailwind: flex-1, flex-auto, flex-initial, flex-none, flex-wrap, flex-row, flex-col.
/// </summary>
[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexBuilder : ResponsiveUtilityBuilder<FlexBuilder>
{
    internal FlexBuilder()
    {
    }

    internal FlexBuilder(FlexEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal FlexBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public FlexBuilder Is1 => ChainValue(FlexEnum.Is1Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public FlexBuilder Auto => ChainValue(FlexEnum.AutoValue);
    /// <summary>
    /// Gets or sets initial.
    /// </summary>
    public FlexBuilder Initial => ChainValue(FlexEnum.InitialValue);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public FlexBuilder None => ChainValue(FlexEnum.NoneValue);
    /// <summary>
    /// Gets or sets wrap.
    /// </summary>
    public FlexBuilder Wrap => ChainValue(FlexEnum.WrapValue);
    /// <summary>
    /// Gets or sets wrap reverse.
    /// </summary>
    public FlexBuilder WrapReverse => ChainValue(FlexEnum.WrapReverseValue);
    /// <summary>
    /// Gets or sets no wrap.
    /// </summary>
    public FlexBuilder NoWrap => ChainValue(FlexEnum.NoWrapValue);
    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public FlexBuilder Row => ChainValue(FlexEnum.RowValue);
    /// <summary>
    /// Gets or sets row reverse.
    /// </summary>
    public FlexBuilder RowReverse => ChainValue(FlexEnum.RowReverseValue);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public FlexBuilder Col => ChainValue(FlexEnum.ColValue);
    /// <summary>
    /// Gets or sets col reverse.
    /// </summary>
    public FlexBuilder ColReverse => ChainValue(FlexEnum.ColReverseValue);
    /// <summary>
    /// Adds an arbitrary flex utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FlexBuilder Token(string value) => ChainValue($"flex-{value}");
}
