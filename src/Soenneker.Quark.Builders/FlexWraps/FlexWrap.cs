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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static FlexWrapBuilder Token(string value) => new("flex-" + value);
}
