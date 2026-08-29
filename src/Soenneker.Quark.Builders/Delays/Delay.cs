namespace Soenneker.Quark;

/// <summary>
/// Represents the delay.
/// </summary>
[TailwindModifiers(typeof(DelayBuilder))]
public static partial class Delay
{
    /// <summary>
    /// Gets or sets is75.
    /// </summary>
    public static DelayBuilder Is75 => new(DelayEnum.Is75);
    /// <summary>
    /// Gets or sets is100.
    /// </summary>
    public static DelayBuilder Is100 => new(DelayEnum.Is100);
    /// <summary>
    /// Gets or sets is150.
    /// </summary>
    public static DelayBuilder Is150 => new(DelayEnum.Is150);
    /// <summary>
    /// Gets or sets is200.
    /// </summary>
    public static DelayBuilder Is200 => new(DelayEnum.Is200);
    /// <summary>
    /// Gets or sets is300.
    /// </summary>
    public static DelayBuilder Is300 => new(DelayEnum.Is300);
    /// <summary>
    /// Gets or sets is500.
    /// </summary>
    public static DelayBuilder Is500 => new(DelayEnum.Is500);
    /// <summary>
    /// Gets or sets is700.
    /// </summary>
    public static DelayBuilder Is700 => new(DelayEnum.Is700);
    /// <summary>
    /// Gets or sets is1000.
    /// </summary>
    public static DelayBuilder Is1000 => new(DelayEnum.Is1000);
    /// <summary>
    /// Adds an arbitrary delay utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static DelayBuilder Token(string value) => new("delay-" + value);
}
