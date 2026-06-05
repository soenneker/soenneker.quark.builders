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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ItemsBuilder Token(string value) => new("items-" + value);
}
