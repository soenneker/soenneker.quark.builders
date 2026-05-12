
namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating opacity builders with predefined values.
/// </summary>
[TailwindModifiers(typeof(OpacityBuilder))]
public static partial class Opacity
{
    /// <summary>
    /// Gets an opacity builder with value 0 (fully transparent).
    /// </summary>
    public static OpacityBuilder Is0 => new(OpacityEnum.Is0);
    public static OpacityBuilder Is5 => new(OpacityEnum.Is5);
    public static OpacityBuilder Is10 => new(OpacityEnum.Is10);
    public static OpacityBuilder Is15 => new(OpacityEnum.Is15);
    public static OpacityBuilder Is20 => new(OpacityEnum.Is20);
    /// <summary>
    /// Gets an opacity builder with value 25 (25% opacity).
    /// </summary>
    public static OpacityBuilder Is25 => new(OpacityEnum.Is25);
    public static OpacityBuilder Is30 => new(OpacityEnum.Is30);
    public static OpacityBuilder Is35 => new(OpacityEnum.Is35);
    public static OpacityBuilder Is40 => new(OpacityEnum.Is40);
    public static OpacityBuilder Is45 => new(OpacityEnum.Is45);
    /// <summary>
    /// Gets an opacity builder with value 50 (50% opacity).
    /// </summary>
    public static OpacityBuilder Is50 => new(OpacityEnum.Is50);
    public static OpacityBuilder Is55 => new(OpacityEnum.Is55);
    /// <summary>
    /// Gets an opacity builder with value 60 (60% opacity).
    /// </summary>
    public static OpacityBuilder Is60 => new(OpacityEnum.Is60);
    public static OpacityBuilder Is65 => new(OpacityEnum.Is65);
    /// <summary>
    /// Gets an opacity builder with value 70 (70% opacity).
    /// </summary>
    public static OpacityBuilder Is70 => new(OpacityEnum.Is70);
    /// <summary>
    /// Gets an opacity builder with value 75 (75% opacity).
    /// </summary>
    public static OpacityBuilder Is75 => new(OpacityEnum.Is75);
    public static OpacityBuilder Is80 => new(OpacityEnum.Is80);
    public static OpacityBuilder Is85 => new(OpacityEnum.Is85);
    public static OpacityBuilder Is90 => new(OpacityEnum.Is90);
    public static OpacityBuilder Is95 => new(OpacityEnum.Is95);
    /// <summary>
    /// Gets an opacity builder with value 100 (fully opaque).
    /// </summary>
    public static OpacityBuilder Is100 => new(OpacityEnum.Is100);

    public static OpacityBuilder Token(string value) => new(value.StartsWith("opacity-") ? value : "opacity-" + value);
}
