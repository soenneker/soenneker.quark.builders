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

    public TBuilder Is50 => Shade("50");
    public TBuilder Is100 => Shade("100");
    public TBuilder Is200 => Shade("200");
    public TBuilder Is300 => Shade("300");
    public TBuilder Is400 => Shade("400");
    public TBuilder Is500 => Shade("500");
    public TBuilder Is600 => Shade("600");
    public TBuilder Is700 => Shade("700");
    public TBuilder Is800 => Shade("800");
    public TBuilder Is900 => Shade("900");
    public TBuilder Is950 => Shade("950");

    private TBuilder Shade(string shade)
    {
        return _create($"{_palette.Value}-{shade}");
    }
}
