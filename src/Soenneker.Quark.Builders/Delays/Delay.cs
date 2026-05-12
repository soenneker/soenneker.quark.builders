namespace Soenneker.Quark;

[TailwindModifiers(typeof(DelayBuilder))]
public static partial class Delay
{
    public static DelayBuilder Is75 => new(DelayEnum.Is75);
    public static DelayBuilder Is100 => new(DelayEnum.Is100);
    public static DelayBuilder Is150 => new(DelayEnum.Is150);
    public static DelayBuilder Is200 => new(DelayEnum.Is200);
    public static DelayBuilder Is300 => new(DelayEnum.Is300);
    public static DelayBuilder Is500 => new(DelayEnum.Is500);
    public static DelayBuilder Is700 => new(DelayEnum.Is700);
    public static DelayBuilder Is1000 => new(DelayEnum.Is1000);
    public static DelayBuilder Token(string value) => new("delay-" + value);
}
