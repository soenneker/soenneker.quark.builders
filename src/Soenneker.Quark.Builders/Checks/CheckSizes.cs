namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style checkbox sizing.
/// </summary>
public static class CheckSizes
{
    public static CheckSizeBuilder Default => new("default");
    public static CheckSizeBuilder Xs => new("xs");
    public static CheckSizeBuilder Sm => new("sm");
    public static CheckSizeBuilder Md => new("md");
    public static CheckSizeBuilder Lg => new("lg");
    public static CheckSizeBuilder Xl => new("xl");
    public static CheckSizeBuilder Xxl => new("xxl");

    public static CheckSizeBuilder Token(string value) => new(value);
}
