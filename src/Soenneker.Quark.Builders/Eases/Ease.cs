namespace Soenneker.Quark;

public static class Ease
{
    public static EaseBuilder Linear => new(EaseEnum.Linear);
    public static EaseBuilder In => new(EaseEnum.In);
    public static EaseBuilder Out => new(EaseEnum.Out);
    public static EaseBuilder InOut => new(EaseEnum.InOut);
    public static EaseBuilder Token(string value) => new(value);
}
