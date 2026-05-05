
namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating Z-index builders with predefined values.
/// </summary>
public static class ZIndex
{
    /// <summary>
    /// Gets a Z-index builder with value -1.
    /// </summary>
    public static ZIndexBuilder N1 => new(ZIndexEnum.N1);

    /// <summary>
    /// Gets a Z-index builder with value 0.
    /// </summary>
    public static ZIndexBuilder Z0 => new(ZIndexEnum.Z0);

    /// <summary>
    /// Gets a Z-index builder with value 1.
    /// </summary>
    public static ZIndexBuilder Z1 => new(ZIndexEnum.Z1);

    /// <summary>
    /// Gets a Z-index builder with value 2.
    /// </summary>
    public static ZIndexBuilder Z2 => new(ZIndexEnum.Z2);

    /// <summary>
    /// Gets a Z-index builder with value 3.
    /// </summary>
    public static ZIndexBuilder Z3 => new(ZIndexEnum.Z3);

    /// <summary>
    /// Gets a Z-index builder with value 10.
    /// </summary>
    public static ZIndexBuilder Z10 => new(ZIndexEnum.Z10);

    /// <summary>
    /// Gets a Z-index builder with value 50.
    /// </summary>
    public static ZIndexBuilder Z50 => new(ZIndexEnum.Z50);
}
