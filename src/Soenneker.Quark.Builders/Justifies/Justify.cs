namespace Soenneker.Quark;

/// <summary>
/// Represents the justify.
/// </summary>
[TailwindModifiers(typeof(JustifyBuilder))]
public static partial class Justify
{
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public static JustifyBuilder Normal => new(JustifyEnum.Normal);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static JustifyBuilder Start => new(JustifyEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static JustifyBuilder End => new(JustifyEnum.End);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static JustifyBuilder Center => new(JustifyEnum.Center);
    /// <summary>
    /// Gets or sets between.
    /// </summary>
    public static JustifyBuilder Between => new(JustifyEnum.Between);
    /// <summary>
    /// Gets or sets around.
    /// </summary>
    public static JustifyBuilder Around => new(JustifyEnum.Around);
    /// <summary>
    /// Gets or sets evenly.
    /// </summary>
    public static JustifyBuilder Evenly => new(JustifyEnum.Evenly);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static JustifyBuilder Stretch => new(JustifyEnum.Stretch);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static JustifyBuilder Token(string value) => new("justify-" + value);
}
