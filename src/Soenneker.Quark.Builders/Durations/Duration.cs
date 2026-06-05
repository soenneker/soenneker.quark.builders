namespace Soenneker.Quark;

/// <summary>
/// Represents the duration.
/// </summary>
[TailwindModifiers(typeof(DurationBuilder))]
public static partial class Duration
{
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static DurationBuilder Is0 => new(DurationEnum.Is0);
    /// <summary>
    /// Gets or sets is75.
    /// </summary>
    public static DurationBuilder Is75 => new(DurationEnum.Is75);
    /// <summary>
    /// Gets or sets is100.
    /// </summary>
    public static DurationBuilder Is100 => new(DurationEnum.Is100);
    /// <summary>
    /// Gets or sets is150.
    /// </summary>
    public static DurationBuilder Is150 => new(DurationEnum.Is150);
    /// <summary>
    /// Gets or sets is200.
    /// </summary>
    public static DurationBuilder Is200 => new(DurationEnum.Is200);
    /// <summary>
    /// Gets or sets is300.
    /// </summary>
    public static DurationBuilder Is300 => new(DurationEnum.Is300);
    /// <summary>
    /// Gets or sets is500.
    /// </summary>
    public static DurationBuilder Is500 => new(DurationEnum.Is500);
    /// <summary>
    /// Gets or sets is700.
    /// </summary>
    public static DurationBuilder Is700 => new(DurationEnum.Is700);
    /// <summary>
    /// Gets or sets is1000.
    /// </summary>
    public static DurationBuilder Is1000 => new(DurationEnum.Is1000);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static DurationBuilder Token(string value) => new(value.StartsWith("duration-") ? value : "duration-" + value);
}
