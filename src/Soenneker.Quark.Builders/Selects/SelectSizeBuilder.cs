using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style select sizing tokens.
/// </summary>
public sealed class SelectSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal SelectSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    public SelectSizeBuilder Default => Chain("default");
    public SelectSizeBuilder Sm => Chain("sm");

    public SelectSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SelectSizeBuilder Chain(string value)
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
