namespace Soenneker.Quark;

[TailwindModifiers(typeof(AppearanceBuilder))]
public static partial class Appearance
{
    public static AppearanceBuilder None => new(AppearanceEnum.None);
    public static AppearanceBuilder Auto => new(AppearanceEnum.Auto);
    public static AppearanceBuilder Token(string value) => new(value.StartsWith("appearance-") ? value : $"appearance-{value}");
}
