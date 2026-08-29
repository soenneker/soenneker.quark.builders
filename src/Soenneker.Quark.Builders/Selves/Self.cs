namespace Soenneker.Quark;

/// <summary>
/// Represents the self.
/// </summary>
[TailwindModifiers(typeof(SelfBuilder))]
public static partial class Self
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static SelfBuilder Auto => new(SelfEnum.Auto);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static SelfBuilder Start => new(SelfEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static SelfBuilder End => new(SelfEnum.End);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static SelfBuilder Center => new(SelfEnum.Center);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static SelfBuilder Stretch => new(SelfEnum.Stretch);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public static SelfBuilder Baseline => new(SelfEnum.Baseline);
    /// <summary>
    /// Adds an arbitrary self utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static SelfBuilder Token(string value) => new("self-" + value);
}
