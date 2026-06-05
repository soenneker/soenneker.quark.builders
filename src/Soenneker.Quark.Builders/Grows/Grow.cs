namespace Soenneker.Quark;

/// <summary>
/// Represents the grow.
/// </summary>
[TailwindModifiers(typeof(GrowBuilder))]
public static partial class Grow
{
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static GrowBuilder Is1 => new(GrowEnum.Is1);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static GrowBuilder Is0 => new(GrowEnum.Is0);
}
