namespace Soenneker.Quark;

public static class JustifyItemsAlign
{
    public static JustifyItemsAlignBuilder Normal => new(JustifyItemsAlignEnum.Normal);
    public static JustifyItemsAlignBuilder Start => new(JustifyItemsAlignEnum.Start);
    public static JustifyItemsAlignBuilder End => new(JustifyItemsAlignEnum.End);
    public static JustifyItemsAlignBuilder Center => new(JustifyItemsAlignEnum.Center);
    public static JustifyItemsAlignBuilder Stretch => new(JustifyItemsAlignEnum.Stretch);
    public static JustifyItemsAlignBuilder Token(string value) => new("justify-items-" + value);
}
