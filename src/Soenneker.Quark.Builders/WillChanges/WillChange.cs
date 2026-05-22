namespace Soenneker.Quark;

[TailwindModifiers(typeof(WillChangeBuilder))]
public static partial class WillChange
{
    public static WillChangeBuilder Auto => new(WillChangeEnum.Auto);
    public static WillChangeBuilder Scroll => new(WillChangeEnum.Scroll);
    public static WillChangeBuilder Contents => new(WillChangeEnum.Contents);
    public static WillChangeBuilder Transform => new(WillChangeEnum.Transform);
    public static WillChangeBuilder Token(string value) => new(value.StartsWith("will-change-") ? value : $"will-change-{value}");
}
