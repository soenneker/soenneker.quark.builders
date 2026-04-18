namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style button sizing.
/// </summary>
public static class ButtonSizes
{
    public static ButtonSizeBuilder Default => new("default");
    public static ButtonSizeBuilder Xs => new("xs");
    public static ButtonSizeBuilder Sm => new("sm");
    public static ButtonSizeBuilder Lg => new("lg");
    public static ButtonSizeBuilder Icon => new("icon");
    public static ButtonSizeBuilder IconXs => new("icon-xs");
    public static ButtonSizeBuilder IconSm => new("icon-sm");
    public static ButtonSizeBuilder IconLg => new("icon-lg");

    public static ButtonSizeBuilder Token(string value) => new(value);
}
