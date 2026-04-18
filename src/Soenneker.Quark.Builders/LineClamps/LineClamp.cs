namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn line clamp utility shortcuts.
/// </summary>
public static class LineClamp
{
    public static LineClampBuilder None => new(LineClampEnum.None);
    public static LineClampBuilder One => new(LineClampEnum.One);
    public static LineClampBuilder Two => new(LineClampEnum.Two);
    public static LineClampBuilder Three => new(LineClampEnum.Three);
    public static LineClampBuilder Four => new(LineClampEnum.Four);
    public static LineClampBuilder Five => new(LineClampEnum.Five);
    public static LineClampBuilder Six => new(LineClampEnum.Six);
}
