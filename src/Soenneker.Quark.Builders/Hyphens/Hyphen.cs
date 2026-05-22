namespace Soenneker.Quark;

[TailwindModifiers(typeof(HyphenBuilder))]
public static partial class Hyphen
{
    public static HyphenBuilder None => new(HyphenEnum.None);
    public static HyphenBuilder Manual => new(HyphenEnum.Manual);
    public static HyphenBuilder Auto => new(HyphenEnum.Auto);
    public static HyphenBuilder Token(string value) => new(value.StartsWith("hyphens-") ? value : $"hyphens-{value}");
}
