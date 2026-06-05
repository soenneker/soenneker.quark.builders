namespace Soenneker.Quark;

/// <summary>
/// Represents the ease.
/// </summary>
[TailwindModifiers(typeof(EaseBuilder))]
public static partial class Ease
{
    /// <summary>
    /// Gets or sets linear.
    /// </summary>
    public static EaseBuilder Linear => new(EaseEnum.Linear);
    /// <summary>
    /// Gets or sets in.
    /// </summary>
    public static EaseBuilder In => new(EaseEnum.In);
    /// <summary>
    /// Gets or sets out.
    /// </summary>
    public static EaseBuilder Out => new(EaseEnum.Out);
    /// <summary>
    /// Gets or sets in out.
    /// </summary>
    public static EaseBuilder InOut => new(EaseEnum.InOut);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static EaseBuilder Token(string value) => new("ease-" + value);
}
