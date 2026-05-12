namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating text wrap builders with predefined values.
/// </summary>
[TailwindModifiers(typeof(TextWrapBuilder))]
public static partial class TextWrap
{
    /// <summary>
    /// Gets a text wrap builder with wrap value (text wraps to multiple lines).
    /// </summary>
    public static TextWrapBuilder Wrap => new(TextWrapEnum.Wrap);

    /// <summary>
    /// Gets a text wrap builder with balance value.
    /// </summary>
    public static TextWrapBuilder Balance => new(TextWrapEnum.Balance);
    /// <summary>
    /// Gets a text wrap builder with pretty value.
    /// </summary>
    public static TextWrapBuilder Pretty => new(TextWrapEnum.Pretty);
}
