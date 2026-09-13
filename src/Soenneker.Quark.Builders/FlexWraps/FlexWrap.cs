namespace Soenneker.Quark;

/// <summary>
/// Creates flex-wrap utilities without changing display. Set Display.Flex or Display.InlineFlex separately.
/// </summary>
[TailwindModifiers(typeof(FlexWrapBuilder))]
public static partial class FlexWrap
{
    /// <summary>
    /// Creates flex-wrap. Does not enable flex display.
    /// </summary>
    public static FlexWrapBuilder Wrap => new(FlexWrapEnum.Wrap);
    /// <summary>
    /// Creates flex-wrap-reverse. Does not enable flex display.
    /// </summary>
    public static FlexWrapBuilder WrapReverse => new(FlexWrapEnum.WrapReverse);
    /// <summary>
    /// Creates flex-nowrap. Does not enable flex display.
    /// </summary>
    public static FlexWrapBuilder NoWrap => new(FlexWrapEnum.NoWrap);
    /// <summary>
    /// Adds an arbitrary flex wrap utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static FlexWrapBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "flex-"));
}
