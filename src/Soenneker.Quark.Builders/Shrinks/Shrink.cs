namespace Soenneker.Quark;

[TailwindModifiers(typeof(ShrinkBuilder))]
public static partial class Shrink
{
    public static ShrinkBuilder Is1 => new(ShrinkEnum.Is1);
    public static ShrinkBuilder Is0 => new(ShrinkEnum.Is0);
}
