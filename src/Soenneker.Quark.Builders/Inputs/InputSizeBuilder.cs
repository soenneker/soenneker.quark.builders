using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style text input sizing tokens.
/// </summary>
public sealed class InputSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal InputSizeBuilder(InputSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal InputSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    public InputSizeBuilder Default => Chain(InputSizeEnum.Default);
    public InputSizeBuilder Sm => Chain(InputSizeEnum.Sm);
    public InputSizeBuilder Lg => Chain(InputSizeEnum.Lg);

    public InputSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private InputSizeBuilder Chain(InputSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private InputSizeBuilder Chain(string value)
    {
        _tokens.Add(value);
        return this;
    }

    public override string ToClass()
    {
        if (_tokens.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _tokens.Count; i++)
        {
            string token = _tokens[i];
            if (token.Length == 0)
                continue;

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(token);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;
}
