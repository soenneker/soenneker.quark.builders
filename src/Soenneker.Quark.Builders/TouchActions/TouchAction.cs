namespace Soenneker.Quark;

/// <summary>
/// Represents the touch action.
/// </summary>
[TailwindModifiers(typeof(TouchActionBuilder))]
public static partial class TouchAction
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static TouchActionBuilder Auto => new(TouchActionEnum.Auto);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static TouchActionBuilder None => new(TouchActionEnum.None);
    /// <summary>
    /// Gets or sets pan x.
    /// </summary>
    public static TouchActionBuilder PanX => new(TouchActionEnum.PanX);
    /// <summary>
    /// Gets or sets pan y.
    /// </summary>
    public static TouchActionBuilder PanY => new(TouchActionEnum.PanY);
    /// <summary>
    /// Gets or sets manipulation.
    /// </summary>
    public static TouchActionBuilder Manipulation => new(TouchActionEnum.Manipulation);
    /// <summary>
    /// Adds an arbitrary touch action utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static TouchActionBuilder Token(string value) => new(value.StartsWith("touch-") ? value : $"touch-{value}");
}
