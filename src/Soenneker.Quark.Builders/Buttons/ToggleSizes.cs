namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style toggle sizing.
/// </summary>
[TailwindModifiers(typeof(ToggleSizeBuilder))]
public static partial class ToggleSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static ToggleSizeBuilder Default => new("h-9 min-w-9 px-2");
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static ToggleSizeBuilder Sm => new("h-8 min-w-8 px-1.5");
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public static ToggleSizeBuilder Lg => new("h-10 min-w-10 px-2.5");

    /// <summary>
    /// Adds an arbitrary toggle sizes utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ToggleSizeBuilder Token(string value) => new(value);
}
