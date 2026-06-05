namespace Soenneker.Quark;

/// <summary>
/// Represents the background image.
/// </summary>
[TailwindModifiers(typeof(BackgroundImageBuilder))]
public static partial class BackgroundImage
{
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static BackgroundImageBuilder None => new(BackgroundImageEnum.None);
    /// <summary>
    /// Gets or sets linear to t.
    /// </summary>
    public static BackgroundImageBuilder LinearToT => new(BackgroundImageEnum.LinearToT);
    /// <summary>
    /// Gets or sets linear to r.
    /// </summary>
    public static BackgroundImageBuilder LinearToR => new(BackgroundImageEnum.LinearToR);
    /// <summary>
    /// Gets or sets linear to b.
    /// </summary>
    public static BackgroundImageBuilder LinearToB => new(BackgroundImageEnum.LinearToB);
    /// <summary>
    /// Gets or sets linear to l.
    /// </summary>
    public static BackgroundImageBuilder LinearToL => new(BackgroundImageEnum.LinearToL);
    /// <summary>
    /// Gets or sets radial.
    /// </summary>
    public static BackgroundImageBuilder Radial => new(BackgroundImageEnum.Radial);
    /// <summary>
    /// Gets or sets conic.
    /// </summary>
    public static BackgroundImageBuilder Conic => new(BackgroundImageEnum.Conic);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static BackgroundImageBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
