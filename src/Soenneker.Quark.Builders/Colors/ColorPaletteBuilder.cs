using System;

namespace Soenneker.Quark;

/// <summary>
/// Fluent Tailwind color palette shade selector.
/// </summary>
public sealed class ColorPaletteBuilder<TBuilder>
{
    private readonly ColorPaletteEnum _palette;
    private readonly Func<string, TBuilder> _create;

    internal ColorPaletteBuilder(ColorPaletteEnum palette, Func<string, TBuilder> create)
    {
        _palette = palette;
        _create = create;
    }

    /// <summary>
    /// Gets or sets is50.
    /// </summary>
    public TBuilder Is50 => Shade("50");
    /// <summary>
    /// Gets or sets is100.
    /// </summary>
    public TBuilder Is100 => Shade("100");
    /// <summary>
    /// Gets or sets is200.
    /// </summary>
    public TBuilder Is200 => Shade("200");
    /// <summary>
    /// Gets or sets is300.
    /// </summary>
    public TBuilder Is300 => Shade("300");
    /// <summary>
    /// Gets or sets is400.
    /// </summary>
    public TBuilder Is400 => Shade("400");
    /// <summary>
    /// Gets or sets is500.
    /// </summary>
    public TBuilder Is500 => Shade("500");
    /// <summary>
    /// Gets or sets is600.
    /// </summary>
    public TBuilder Is600 => Shade("600");
    /// <summary>
    /// Gets or sets is700.
    /// </summary>
    public TBuilder Is700 => Shade("700");
    /// <summary>
    /// Gets or sets is800.
    /// </summary>
    public TBuilder Is800 => Shade("800");
    /// <summary>
    /// Gets or sets is900.
    /// </summary>
    public TBuilder Is900 => Shade("900");
    /// <summary>
    /// Gets or sets is950.
    /// </summary>
    public TBuilder Is950 => Shade("950");

    private TBuilder Shade(string shade)
    {
        return _create($"{_palette.Value}-{shade}");
    }
}