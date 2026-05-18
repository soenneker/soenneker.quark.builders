namespace Soenneker.Quark;

public abstract class ColorBuilderBase<TBuilder> : CssBuilderBase<TBuilder>
    where TBuilder : ColorBuilderBase<TBuilder>
{
    public ColorPaletteBuilder<TBuilder> Slate => new(ColorPaletteEnum.Slate, Token);
    public ColorPaletteBuilder<TBuilder> Gray => new(ColorPaletteEnum.Gray, Token);
    public ColorPaletteBuilder<TBuilder> Zinc => new(ColorPaletteEnum.Zinc, Token);
    public ColorPaletteBuilder<TBuilder> Neutral => new(ColorPaletteEnum.Neutral, Token);
    public ColorPaletteBuilder<TBuilder> Stone => new(ColorPaletteEnum.Stone, Token);
    public ColorPaletteBuilder<TBuilder> Red => new(ColorPaletteEnum.Red, Token);
    public ColorPaletteBuilder<TBuilder> Orange => new(ColorPaletteEnum.Orange, Token);
    public ColorPaletteBuilder<TBuilder> Amber => new(ColorPaletteEnum.Amber, Token);
    public ColorPaletteBuilder<TBuilder> Yellow => new(ColorPaletteEnum.Yellow, Token);
    public ColorPaletteBuilder<TBuilder> Lime => new(ColorPaletteEnum.Lime, Token);
    public ColorPaletteBuilder<TBuilder> Green => new(ColorPaletteEnum.Green, Token);
    public ColorPaletteBuilder<TBuilder> Emerald => new(ColorPaletteEnum.Emerald, Token);
    public ColorPaletteBuilder<TBuilder> Teal => new(ColorPaletteEnum.Teal, Token);
    public ColorPaletteBuilder<TBuilder> Cyan => new(ColorPaletteEnum.Cyan, Token);
    public ColorPaletteBuilder<TBuilder> Sky => new(ColorPaletteEnum.Sky, Token);
    public ColorPaletteBuilder<TBuilder> Blue => new(ColorPaletteEnum.Blue, Token);
    public ColorPaletteBuilder<TBuilder> Indigo => new(ColorPaletteEnum.Indigo, Token);
    public ColorPaletteBuilder<TBuilder> Violet => new(ColorPaletteEnum.Violet, Token);
    public ColorPaletteBuilder<TBuilder> Purple => new(ColorPaletteEnum.Purple, Token);
    public ColorPaletteBuilder<TBuilder> Fuchsia => new(ColorPaletteEnum.Fuchsia, Token);
    public ColorPaletteBuilder<TBuilder> Pink => new(ColorPaletteEnum.Pink, Token);
    public ColorPaletteBuilder<TBuilder> Rose => new(ColorPaletteEnum.Rose, Token);

    public abstract TBuilder Token(string token);
}
