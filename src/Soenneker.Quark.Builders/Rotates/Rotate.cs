namespace Soenneker.Quark;

/// <summary>
/// Represents the rotate.
/// </summary>
[TailwindModifiers(typeof(RotateBuilder))]
public static partial class Rotate
{
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static RotateBuilder Is0 => new(RotateEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static RotateBuilder Is1 => new(RotateEnum.Is1);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static RotateBuilder Is2 => new(RotateEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static RotateBuilder Is3 => new(RotateEnum.Is3);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public static RotateBuilder Is6 => new(RotateEnum.Is6);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static RotateBuilder Is12 => new(RotateEnum.Is12);
    /// <summary>
    /// Gets or sets is45.
    /// </summary>
    public static RotateBuilder Is45 => new(RotateEnum.Is45);
    /// <summary>
    /// Gets or sets is90.
    /// </summary>
    public static RotateBuilder Is90 => new(RotateEnum.Is90);
    /// <summary>
    /// Gets or sets is180.
    /// </summary>
    public static RotateBuilder Is180 => new(RotateEnum.Is180);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static RotateBuilder Token(string value) => new("rotate-" + value);
}
