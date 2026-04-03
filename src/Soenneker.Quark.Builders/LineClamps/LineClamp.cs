namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn line clamp utility shortcuts.
/// </summary>
public static class LineClamp
{
    public static LineClampBuilder None => new("none");
    public static LineClampBuilder One => new("1");
    public static LineClampBuilder Two => new("2");
    public static LineClampBuilder Three => new("3");
    public static LineClampBuilder Four => new("4");
    public static LineClampBuilder Five => new("5");
    public static LineClampBuilder Six => new("6");
}
