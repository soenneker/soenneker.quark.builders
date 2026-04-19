using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for pagination sizing tokens.
/// </summary>
public sealed class PaginationSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal PaginationSizeBuilder(PaginationSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal PaginationSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    public PaginationSizeBuilder Default => Chain(PaginationSizeEnum.Default);
    public PaginationSizeBuilder Sm => Chain(PaginationSizeEnum.Sm);
    public PaginationSizeBuilder Lg => Chain(PaginationSizeEnum.Lg);

    public PaginationSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaginationSizeBuilder Chain(PaginationSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaginationSizeBuilder Chain(string value)
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
