using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style switch sizing tokens.
/// </summary>
public sealed class SwitchSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal SwitchSizeBuilder(SwitchSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal SwitchSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public SwitchSizeBuilder Default => Chain(SwitchSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public SwitchSizeBuilder Sm => Chain(SwitchSizeEnum.Sm);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public SwitchSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SwitchSizeBuilder Chain(SwitchSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SwitchSizeBuilder Chain(string value)
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

        for (var i = 0; i < _tokens.Count; i++)
        {
            if (i > 0)
                sb.Append(' ');

            sb.Append(_tokens[i]);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
