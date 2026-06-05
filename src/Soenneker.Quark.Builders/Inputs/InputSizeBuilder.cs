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

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public InputSizeBuilder Default => Chain(InputSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public InputSizeBuilder Sm => Chain(InputSizeEnum.Sm);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public InputSizeBuilder Lg => Chain(InputSizeEnum.Lg);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
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
