namespace Soenneker.Quark;

[TailwindModifiers(typeof(GrowBuilder))]
public static partial class Grow
{
    public static GrowBuilder Is1 => new(GrowEnum.Is1);
    public static GrowBuilder Is0 => new(GrowEnum.Is0);
}
