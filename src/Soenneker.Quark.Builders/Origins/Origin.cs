namespace Soenneker.Quark;

[TailwindModifiers(typeof(OriginBuilder))]
public static partial class Origin
{
    public static OriginBuilder Center => new(OriginEnum.Center);
    public static OriginBuilder Top => new(OriginEnum.Top);
    public static OriginBuilder TopRight => new(OriginEnum.TopRight);
    public static OriginBuilder Right => new(OriginEnum.Right);
    public static OriginBuilder BottomRight => new(OriginEnum.BottomRight);
    public static OriginBuilder Bottom => new(OriginEnum.Bottom);
    public static OriginBuilder BottomLeft => new(OriginEnum.BottomLeft);
    public static OriginBuilder Left => new(OriginEnum.Left);
    public static OriginBuilder TopLeft => new(OriginEnum.TopLeft);
    public static OriginBuilder Token(string value) => new("origin-" + value);
}
