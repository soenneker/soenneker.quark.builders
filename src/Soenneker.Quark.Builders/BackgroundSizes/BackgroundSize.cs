namespace Soenneker.Quark;

[TailwindModifiers(typeof(BackgroundSizeBuilder))]
public static partial class BackgroundSize
{
    public static BackgroundSizeBuilder Auto => new(BackgroundSizeEnum.Auto);
    public static BackgroundSizeBuilder Cover => new(BackgroundSizeEnum.Cover);
    public static BackgroundSizeBuilder Contain => new(BackgroundSizeEnum.Contain);
    public static BackgroundSizeBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
