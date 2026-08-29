namespace Soenneker.Quark;

/// <summary>
/// Represents the color builder base.
/// </summary>
/// <typeparam name="TBuilder">The TBuilder type.</typeparam>
public abstract class ColorBuilderBase<TBuilder> : CssBuilderBase<TBuilder>
    where TBuilder : ColorBuilderBase<TBuilder>
{
    /// <summary>
    /// Gets or sets slate.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Slate => new(ColorPaletteEnum.Slate, Token);
    /// <summary>
    /// Gets or sets gray.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Gray => new(ColorPaletteEnum.Gray, Token);
    /// <summary>
    /// Gets or sets zinc.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Zinc => new(ColorPaletteEnum.Zinc, Token);
    /// <summary>
    /// Gets or sets neutral.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Neutral => new(ColorPaletteEnum.Neutral, Token);
    /// <summary>
    /// Gets or sets stone.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Stone => new(ColorPaletteEnum.Stone, Token);
    /// <summary>
    /// Gets or sets red.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Red => new(ColorPaletteEnum.Red, Token);
    /// <summary>
    /// Gets or sets orange.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Orange => new(ColorPaletteEnum.Orange, Token);
    /// <summary>
    /// Gets or sets amber.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Amber => new(ColorPaletteEnum.Amber, Token);
    /// <summary>
    /// Gets or sets yellow.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Yellow => new(ColorPaletteEnum.Yellow, Token);
    /// <summary>
    /// Gets or sets lime.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Lime => new(ColorPaletteEnum.Lime, Token);
    /// <summary>
    /// Gets or sets green.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Green => new(ColorPaletteEnum.Green, Token);
    /// <summary>
    /// Gets or sets emerald.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Emerald => new(ColorPaletteEnum.Emerald, Token);
    /// <summary>
    /// Gets or sets teal.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Teal => new(ColorPaletteEnum.Teal, Token);
    /// <summary>
    /// Gets or sets cyan.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Cyan => new(ColorPaletteEnum.Cyan, Token);
    /// <summary>
    /// Gets or sets sky.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Sky => new(ColorPaletteEnum.Sky, Token);
    /// <summary>
    /// Gets or sets blue.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Blue => new(ColorPaletteEnum.Blue, Token);
    /// <summary>
    /// Gets or sets indigo.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Indigo => new(ColorPaletteEnum.Indigo, Token);
    /// <summary>
    /// Gets or sets violet.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Violet => new(ColorPaletteEnum.Violet, Token);
    /// <summary>
    /// Gets or sets purple.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Purple => new(ColorPaletteEnum.Purple, Token);
    /// <summary>
    /// Gets or sets fuchsia.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Fuchsia => new(ColorPaletteEnum.Fuchsia, Token);
    /// <summary>
    /// Gets or sets pink.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Pink => new(ColorPaletteEnum.Pink, Token);
    /// <summary>
    /// Gets or sets rose.
    /// </summary>
    public ColorPaletteBuilder<TBuilder> Rose => new(ColorPaletteEnum.Rose, Token);

    /// <summary>
    /// Adds an arbitrary color utility token to the class list.
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public abstract TBuilder Token(string token);
}
