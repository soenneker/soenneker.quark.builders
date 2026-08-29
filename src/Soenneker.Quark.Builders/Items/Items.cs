namespace Soenneker.Quark;

/// <summary>
/// Represents the items.
/// </summary>
[TailwindModifiers(typeof(ItemsBuilder))]
public static partial class Items
{
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static ItemsBuilder Start => new(ItemsEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static ItemsBuilder End => new(ItemsEnum.End);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static ItemsBuilder Center => new(ItemsEnum.Center);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public static ItemsBuilder Baseline => new(ItemsEnum.Baseline);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static ItemsBuilder Stretch => new(ItemsEnum.Stretch);
    /// <summary>
    /// Adds an arbitrary items utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ItemsBuilder Token(string value) => new("items-" + value);
}
