using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style slider sizing tokens.
/// </summary>
public sealed class SliderSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal SliderSizeBuilder(SliderSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal SliderSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    public SliderSizeBuilder Default => Chain(SliderSizeEnum.Default);
    public SliderSizeBuilder Sm => Chain(SliderSizeEnum.Sm);
    public SliderSizeBuilder Lg => Chain(SliderSizeEnum.Lg);

    public SliderSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SliderSizeBuilder Chain(SliderSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SliderSizeBuilder Chain(string value)
    {
        _tokens.Add(value);
        return this;
    }

    public override string ToClass()
    {
        if (_tokens.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();

        for (var i = 0; i < _tokens.Count; i++)
        {
            if (i > 0)
                sb.Append(' ');

            sb.Append(_tokens[i]);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;
}
