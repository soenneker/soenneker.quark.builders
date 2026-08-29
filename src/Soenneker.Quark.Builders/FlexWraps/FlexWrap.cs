namespace Soenneker.Quark;

/// <summary>
/// Represents the flex wrap.
/// </summary>
[TailwindModifiers(typeof(FlexWrapBuilder))]
public static partial class FlexWrap
{
    /// <summary>
    /// Gets or sets wrap.
    /// </summary>
    public static FlexWrapBuilder Wrap => new(FlexWrapEnum.Wrap);
    /// <summary>
    /// Gets or sets wrap reverse.
    /// </summary>
    public static FlexWrapBuilder WrapReverse => new(FlexWrapEnum.WrapReverse);
    /// <summary>
    /// Gets or sets no wrap.
    /// </summary>
    public static FlexWrapBuilder NoWrap => new(FlexWrapEnum.NoWrap);
    /// <summary>
    /// Adds an arbitrary flex wrap utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static FlexWrapBuilder Token(string value) => new("flex-" + value);
}
