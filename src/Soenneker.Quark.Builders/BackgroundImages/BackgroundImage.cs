namespace Soenneker.Quark;

[TailwindModifiers(typeof(BackgroundImageBuilder))]
public static partial class BackgroundImage
{
    public static BackgroundImageBuilder None => new(BackgroundImageEnum.None);
    public static BackgroundImageBuilder LinearToT => new(BackgroundImageEnum.LinearToT);
    public static BackgroundImageBuilder LinearToR => new(BackgroundImageEnum.LinearToR);
    public static BackgroundImageBuilder LinearToB => new(BackgroundImageEnum.LinearToB);
    public static BackgroundImageBuilder LinearToL => new(BackgroundImageEnum.LinearToL);
    public static BackgroundImageBuilder Radial => new(BackgroundImageEnum.Radial);
    public static BackgroundImageBuilder Conic => new(BackgroundImageEnum.Conic);
    public static BackgroundImageBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
