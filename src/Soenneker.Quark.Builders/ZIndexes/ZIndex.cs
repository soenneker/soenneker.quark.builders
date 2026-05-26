
namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating Z-index builders with predefined values.
/// </summary>
[TailwindModifiers(typeof(ZIndexBuilder))]
public static partial class ZIndex
{
    /// <summary>
    /// Gets a Z-index builder with value -1.
    /// </summary>
    public static ZIndexBuilder Negative1 => new(ZIndexEnum.Negative1);

    /// <summary>
    /// Gets a Z-index builder with value 0.
    /// </summary>
    public static ZIndexBuilder Is0 => new(ZIndexEnum.Is0);

    /// <summary>
    /// Gets a Z-index builder with value 1.
    /// </summary>
    public static ZIndexBuilder Is1 => new(ZIndexEnum.Is1);

    /// <summary>
    /// Gets a Z-index builder with value 2.
    /// </summary>
    public static ZIndexBuilder Is2 => new(ZIndexEnum.Is2);

    /// <summary>
    /// Gets a Z-index builder with value 3.
    /// </summary>
    public static ZIndexBuilder Is3 => new(ZIndexEnum.Is3);

    /// <summary>
    /// Gets a Z-index builder with value 10.
    /// </summary>
    public static ZIndexBuilder Is10 => new(ZIndexEnum.Is10);

    /// <summary>
    /// Gets a Z-index builder with value 50.
    /// </summary>
    public static ZIndexBuilder Is50 => new(ZIndexEnum.Is50);
}
