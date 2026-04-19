namespace Soenneker.Quark;

public static class Duration
{
    public static DurationBuilder Is75 => new(DurationEnum.Is75);
    public static DurationBuilder Is100 => new(DurationEnum.Is100);
    public static DurationBuilder Is150 => new(DurationEnum.Is150);
    public static DurationBuilder Is200 => new(DurationEnum.Is200);
    public static DurationBuilder Is300 => new(DurationEnum.Is300);
    public static DurationBuilder Is500 => new(DurationEnum.Is500);
    public static DurationBuilder Is700 => new(DurationEnum.Is700);
    public static DurationBuilder Is1000 => new(DurationEnum.Is1000);
    public static DurationBuilder Token(string value) => new("duration-" + value);
}
