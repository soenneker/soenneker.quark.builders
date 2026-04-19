using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style checkbox sizing tokens.
/// </summary>
public sealed class CheckSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal CheckSizeBuilder(CheckSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal CheckSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    public CheckSizeBuilder Default => Chain(CheckSizeEnum.Default);
    public CheckSizeBuilder Xs => Chain(CheckSizeEnum.Xs);
    public CheckSizeBuilder Sm => Chain(CheckSizeEnum.Sm);
    public CheckSizeBuilder Md => Chain(CheckSizeEnum.Md);
    public CheckSizeBuilder Lg => Chain(CheckSizeEnum.Lg);
    public CheckSizeBuilder Xl => Chain(CheckSizeEnum.Xl);
    public CheckSizeBuilder Xxl => Chain(CheckSizeEnum.Xxl);

    public CheckSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private CheckSizeBuilder Chain(CheckSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private CheckSizeBuilder Chain(string value)
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
