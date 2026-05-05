
namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating opacity builders with predefined values.
/// </summary>
public static class Opacity
{
    /// <summary>
    /// Gets an opacity builder with value 0 (fully transparent).
    /// </summary>
    public static OpacityBuilder Is0 => new(OpacityEnum.Is0);
    /// <summary>
    /// Gets an opacity builder with value 25 (25% opacity).
    /// </summary>
    public static OpacityBuilder Is25 => new(OpacityEnum.Is25);
    /// <summary>
    /// Gets an opacity builder with value 50 (50% opacity).
    /// </summary>
    public static OpacityBuilder Is50 => new(OpacityEnum.Is50);
    /// <summary>
    /// Gets an opacity builder with value 60 (60% opacity).
    /// </summary>
    public static OpacityBuilder Is60 => new(OpacityEnum.Is60);
    /// <summary>
    /// Gets an opacity builder with value 70 (70% opacity).
    /// </summary>
    public static OpacityBuilder Is70 => new(OpacityEnum.Is70);
    /// <summary>
    /// Gets an opacity builder with value 75 (75% opacity).
    /// </summary>
    public static OpacityBuilder Is75 => new(OpacityEnum.Is75);
    /// <summary>
    /// Gets an opacity builder with value 100 (fully opaque).
    /// </summary>
    public static OpacityBuilder Is100 => new(OpacityEnum.Is100);
}
