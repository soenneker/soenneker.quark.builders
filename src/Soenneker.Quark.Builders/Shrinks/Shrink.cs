namespace Soenneker.Quark;

/// <summary>
/// Represents the shrink.
/// </summary>
[TailwindModifiers(typeof(ShrinkBuilder))]
public static partial class Shrink
{
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static ShrinkBuilder Is1 => new(ShrinkEnum.Is1);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static ShrinkBuilder Is0 => new(ShrinkEnum.Is0);
}
