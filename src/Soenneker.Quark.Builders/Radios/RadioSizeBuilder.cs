using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style radio sizing tokens.
/// </summary>
public sealed class RadioSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal RadioSizeBuilder(RadioSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal RadioSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    public RadioSizeBuilder Default => Chain(RadioSizeEnum.Default);
    public RadioSizeBuilder Xs => Chain(RadioSizeEnum.Xs);
    public RadioSizeBuilder Sm => Chain(RadioSizeEnum.Sm);
    public RadioSizeBuilder Md => Chain(RadioSizeEnum.Md);
    public RadioSizeBuilder Lg => Chain(RadioSizeEnum.Lg);
    public RadioSizeBuilder Xl => Chain(RadioSizeEnum.Xl);
    public RadioSizeBuilder Xxl => Chain(RadioSizeEnum.Xxl);

    public RadioSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RadioSizeBuilder Chain(RadioSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RadioSizeBuilder Chain(string value)
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
