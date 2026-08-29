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

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public PaginationSizeBuilder Default => Chain(PaginationSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public PaginationSizeBuilder Sm => Chain(PaginationSizeEnum.Sm);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public PaginationSizeBuilder Lg => Chain(PaginationSizeEnum.Lg);

    /// <summary>
    /// Adds an arbitrary pagination size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
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

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
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

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
