namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn line clamp utility shortcuts.
/// </summary>
[TailwindModifiers(typeof(LineClampBuilder))]
public static partial class LineClamp
{
    public static LineClampBuilder None => new(LineClampEnum.None);
    public static LineClampBuilder Is1 => new(LineClampEnum.Is1);
    public static LineClampBuilder Is2 => new(LineClampEnum.Is2);
    public static LineClampBuilder Is3 => new(LineClampEnum.Is3);
    public static LineClampBuilder Is4 => new(LineClampEnum.Is4);
    public static LineClampBuilder Is5 => new(LineClampEnum.Is5);
    public static LineClampBuilder Is6 => new(LineClampEnum.Is6);
    public static LineClampBuilder Token(string value) => new(value.StartsWith("line-clamp-") ? value : "line-clamp-" + value);
}
