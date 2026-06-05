
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
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static OpacityBuilder Is5 => new(OpacityEnum.Is5);
    /// <summary>
    /// Gets or sets is10.
    /// </summary>
    public static OpacityBuilder Is10 => new(OpacityEnum.Is10);
    /// <summary>
    /// Gets or sets is15.
    /// </summary>
    public static OpacityBuilder Is15 => new(OpacityEnum.Is15);
    /// <summary>
    /// Gets or sets is20.
    /// </summary>
    public static OpacityBuilder Is20 => new(OpacityEnum.Is20);
    /// <summary>
    /// Gets an opacity builder with value 25 (25% opacity).
    /// </summary>
    public static OpacityBuilder Is25 => new(OpacityEnum.Is25);
    /// <summary>
    /// Gets or sets is30.
    /// </summary>
    public static OpacityBuilder Is30 => new(OpacityEnum.Is30);
    /// <summary>
    /// Gets or sets is35.
    /// </summary>
    public static OpacityBuilder Is35 => new(OpacityEnum.Is35);
    /// <summary>
    /// Gets or sets is40.
    /// </summary>
    public static OpacityBuilder Is40 => new(OpacityEnum.Is40);
    /// <summary>
    /// Gets or sets is45.
    /// </summary>
    public static OpacityBuilder Is45 => new(OpacityEnum.Is45);
    /// <summary>
    /// Gets an opacity builder with value 50 (50% opacity).
    /// </summary>
    public static OpacityBuilder Is50 => new(OpacityEnum.Is50);
    /// <summary>
    /// Gets or sets is55.
    /// </summary>
    public static OpacityBuilder Is55 => new(OpacityEnum.Is55);
    /// <summary>
    /// Gets an opacity builder with value 60 (60% opacity).
    /// </summary>
    public static OpacityBuilder Is60 => new(OpacityEnum.Is60);
    /// <summary>
    /// Gets or sets is65.
    /// </summary>
    public static OpacityBuilder Is65 => new(OpacityEnum.Is65);
    /// <summary>
    /// Gets an opacity builder with value 70 (70% opacity).
    /// </summary>
    public static OpacityBuilder Is70 => new(OpacityEnum.Is70);
    /// <summary>
    /// Gets an opacity builder with value 75 (75% opacity).
    /// </summary>
    public static OpacityBuilder Is75 => new(OpacityEnum.Is75);
    /// <summary>
    /// Gets or sets is80.
    /// </summary>
    public static OpacityBuilder Is80 => new(OpacityEnum.Is80);
    /// <summary>
    /// Gets or sets is85.
    /// </summary>
    public static OpacityBuilder Is85 => new(OpacityEnum.Is85);
    /// <summary>
    /// Gets or sets is90.
    /// </summary>
    public static OpacityBuilder Is90 => new(OpacityEnum.Is90);
    /// <summary>
    /// Gets or sets is95.
    /// </summary>
    public static OpacityBuilder Is95 => new(OpacityEnum.Is95);
    /// <summary>
    /// Gets an opacity builder with value 100 (fully opaque).
    /// </summary>
    public static OpacityBuilder Is100 => new(OpacityEnum.Is100);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static OpacityBuilder Token(string value) => new(value.StartsWith("opacity-") ? value : "opacity-" + value);
}
