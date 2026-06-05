namespace Soenneker.Quark;

/// <summary>
/// Represents the justify self align.
/// </summary>
[TailwindModifiers(typeof(JustifySelfAlignBuilder))]
public static partial class JustifySelfAlign
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static JustifySelfAlignBuilder Auto => new(JustifySelfAlignEnum.Auto);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static JustifySelfAlignBuilder Start => new(JustifySelfAlignEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static JustifySelfAlignBuilder End => new(JustifySelfAlignEnum.End);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static JustifySelfAlignBuilder Center => new(JustifySelfAlignEnum.Center);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static JustifySelfAlignBuilder Stretch => new(JustifySelfAlignEnum.Stretch);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static JustifySelfAlignBuilder Token(string value) => new("justify-self-" + value);
}
