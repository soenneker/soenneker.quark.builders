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

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public RadioSizeBuilder Default => Chain(RadioSizeEnum.Default);
    /// <summary>
    /// Gets or sets xs.
    /// </summary>
    public RadioSizeBuilder Xs => Chain(RadioSizeEnum.Xs);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public RadioSizeBuilder Sm => Chain(RadioSizeEnum.Sm);
    /// <summary>
    /// Gets or sets md.
    /// </summary>
    public RadioSizeBuilder Md => Chain(RadioSizeEnum.Md);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public RadioSizeBuilder Lg => Chain(RadioSizeEnum.Lg);
    /// <summary>
    /// Gets or sets xl.
    /// </summary>
    public RadioSizeBuilder Xl => Chain(RadioSizeEnum.Xl);
    /// <summary>
    /// Gets or sets xxl.
    /// </summary>
    public RadioSizeBuilder Xxl => Chain(RadioSizeEnum.Xxl);

    /// <summary>
    /// Adds an arbitrary radio size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
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
