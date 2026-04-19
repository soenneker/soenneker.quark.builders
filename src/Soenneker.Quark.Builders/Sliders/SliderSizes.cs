namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style slider sizing.
/// </summary>
public static class SliderSizes
{
    public static SliderSizeBuilder Default => new("default");
    public static SliderSizeBuilder Sm => new("sm");
    public static SliderSizeBuilder Lg => new("lg");

    public static SliderSizeBuilder Token(string value) => new(value);
}
