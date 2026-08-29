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

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public CheckSizeBuilder Default => Chain(CheckSizeEnum.Default);
    /// <summary>
    /// Gets or sets xs.
    /// </summary>
    public CheckSizeBuilder Xs => Chain(CheckSizeEnum.Xs);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public CheckSizeBuilder Sm => Chain(CheckSizeEnum.Sm);
    /// <summary>
    /// Gets or sets md.
    /// </summary>
    public CheckSizeBuilder Md => Chain(CheckSizeEnum.Md);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public CheckSizeBuilder Lg => Chain(CheckSizeEnum.Lg);
    /// <summary>
    /// Gets or sets xl.
    /// </summary>
    public CheckSizeBuilder Xl => Chain(CheckSizeEnum.Xl);
    /// <summary>
    /// Gets or sets xxl.
    /// </summary>
    public CheckSizeBuilder Xxl => Chain(CheckSizeEnum.Xxl);

    /// <summary>
    /// Adds an arbitrary check size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
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
