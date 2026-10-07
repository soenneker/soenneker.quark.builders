namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility builder. Tailwind: flex-1, flex-auto, flex-initial, flex-none, flex-wrap, flex-row, flex-col.
/// </summary>
[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexBuilder : FinalClassUtilityBuilder<FlexBuilder>
{
    internal FlexBuilder()
    {
    }

    internal FlexBuilder(FlexEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal FlexBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public FlexBuilder Is1 => ChainClass(FlexEnum.Is1Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public FlexBuilder Auto => ChainClass(FlexEnum.AutoValue);
    /// <summary>
    /// Gets or sets initial.
    /// </summary>
    public FlexBuilder Initial => ChainClass(FlexEnum.InitialValue);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public FlexBuilder None => ChainClass(FlexEnum.NoneValue);
    /// <summary>
    /// Gets or sets wrap.
    /// </summary>
    public FlexBuilder Wrap => ChainClass(FlexEnum.WrapValue);
    /// <summary>
    /// Gets or sets wrap reverse.
    /// </summary>
    public FlexBuilder WrapReverse => ChainClass(FlexEnum.WrapReverseValue);
    /// <summary>
    /// Gets or sets no wrap.
    /// </summary>
    public FlexBuilder NoWrap => ChainClass(FlexEnum.NoWrapValue);
    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public FlexBuilder Row => ChainClass(FlexEnum.RowValue);
    /// <summary>
    /// Gets or sets row reverse.
    /// </summary>
    public FlexBuilder RowReverse => ChainClass(FlexEnum.RowReverseValue);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public FlexBuilder Col => ChainClass(FlexEnum.ColValue);
    /// <summary>
    /// Gets or sets col reverse.
    /// </summary>
    public FlexBuilder ColReverse => ChainClass(FlexEnum.ColReverseValue);
    /// <summary>
    /// Adds an arbitrary flex utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the flex prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FlexBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "flex-"));
}
