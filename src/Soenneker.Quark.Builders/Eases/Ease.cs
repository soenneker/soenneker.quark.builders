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
    /// Adds an arbitrary ease utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static EaseBuilder Token(string value) => new("ease-" + value);
}
