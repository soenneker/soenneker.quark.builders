namespace Soenneker.Quark;

[TailwindModifiers(typeof(TouchActionBuilder))]
public static partial class TouchAction
{
    public static TouchActionBuilder Auto => new(TouchActionEnum.Auto);
    public static TouchActionBuilder None => new(TouchActionEnum.None);
    public static TouchActionBuilder PanX => new(TouchActionEnum.PanX);
    public static TouchActionBuilder PanY => new(TouchActionEnum.PanY);
    public static TouchActionBuilder Manipulation => new(TouchActionEnum.Manipulation);
    public static TouchActionBuilder Token(string value) => new(value.StartsWith("touch-") ? value : $"touch-{value}");
}
