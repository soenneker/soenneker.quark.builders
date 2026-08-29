namespace Soenneker.Quark;

/// <summary>
/// Represents the will change.
/// </summary>
[TailwindModifiers(typeof(WillChangeBuilder))]
public static partial class WillChange
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static WillChangeBuilder Auto => new(WillChangeEnum.Auto);
    /// <summary>
    /// Gets or sets scroll.
    /// </summary>
    public static WillChangeBuilder Scroll => new(WillChangeEnum.Scroll);
    /// <summary>
    /// Gets or sets contents.
    /// </summary>
    public static WillChangeBuilder Contents => new(WillChangeEnum.Contents);
    /// <summary>
    /// Gets or sets transform.
    /// </summary>
    public static WillChangeBuilder Transform => new(WillChangeEnum.Transform);
    /// <summary>
    /// Adds an arbitrary will change utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static WillChangeBuilder Token(string value) => new(value.StartsWith("will-change-") ? value : $"will-change-{value}");
}
