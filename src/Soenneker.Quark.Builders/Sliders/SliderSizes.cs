namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style slider sizing.
/// </summary>
public static class SliderSizes
{
    public static SliderSizeBuilder Default => new(SliderSizeEnum.Default);
    public static SliderSizeBuilder Sm => new(SliderSizeEnum.Sm);
    public static SliderSizeBuilder Lg => new(SliderSizeEnum.Lg);

    public static SliderSizeBuilder Token(string value) => new(value);
}
