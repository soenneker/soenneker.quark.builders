namespace Soenneker.Quark;

/// <summary>
/// Builds flex-wrap utilities without changing display. Set Display.Flex or Display.InlineFlex separately.
/// </summary>
[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexWrapBuilder : ResponsiveUtilityBuilder<FlexWrapBuilder>
{
    internal FlexWrapBuilder()
    {
    }

    internal FlexWrapBuilder(FlexWrapEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal FlexWrapBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Adds flex-wrap. Does not enable flex display.
    /// </summary>
    public FlexWrapBuilder Wrap => ChainValue(FlexWrapEnum.WrapValue);
    /// <summary>
    /// Adds flex-wrap-reverse. Does not enable flex display.
    /// </summary>
    public FlexWrapBuilder WrapReverse => ChainValue(FlexWrapEnum.WrapReverseValue);
    /// <summary>
    /// Adds flex-nowrap. Does not enable flex display.
    /// </summary>
    public FlexWrapBuilder NoWrap => ChainValue(FlexWrapEnum.NoWrapValue);
    /// <summary>
    /// Adds an arbitrary flex wrap utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FlexWrapBuilder Token(string value) => ChainValue(UtilityToken.WithPrefix(value, "flex-"));
}
