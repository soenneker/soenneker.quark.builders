namespace Soenneker.Quark;

[TailwindModifiers(typeof(ForcedColorAdjustBuilder))]
public static partial class ForcedColorAdjust
{
    public static ForcedColorAdjustBuilder Auto => new(ForcedColorAdjustEnum.Auto);
    public static ForcedColorAdjustBuilder None => new(ForcedColorAdjustEnum.None);
    public static ForcedColorAdjustBuilder Token(string value) => new(value.StartsWith("forced-color-adjust-") ? value : $"forced-color-adjust-{value}");
}
