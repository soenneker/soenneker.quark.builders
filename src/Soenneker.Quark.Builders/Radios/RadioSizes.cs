namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style radio sizing.
/// </summary>
public static class RadioSizes
{
    public static RadioSizeBuilder Default => new("default");
    public static RadioSizeBuilder Xs => new("xs");
    public static RadioSizeBuilder Sm => new("sm");
    public static RadioSizeBuilder Md => new("md");
    public static RadioSizeBuilder Lg => new("lg");
    public static RadioSizeBuilder Xl => new("xl");
    public static RadioSizeBuilder Xxl => new("xxl");

    public static RadioSizeBuilder Token(string value) => new(value);
}
