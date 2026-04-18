namespace Soenneker.Quark;

public static class Rotate
{
    public static RotateBuilder Is0 => new(RotateEnum.Is0);
    public static RotateBuilder Is1 => new(RotateEnum.Is1);
    public static RotateBuilder Is2 => new(RotateEnum.Is2);
    public static RotateBuilder Is3 => new(RotateEnum.Is3);
    public static RotateBuilder Is6 => new(RotateEnum.Is6);
    public static RotateBuilder Is12 => new(RotateEnum.Is12);
    public static RotateBuilder Is45 => new(RotateEnum.Is45);
    public static RotateBuilder Is90 => new(RotateEnum.Is90);
    public static RotateBuilder Is180 => new(RotateEnum.Is180);
    public static RotateBuilder Token(string value) => new(value);
}
