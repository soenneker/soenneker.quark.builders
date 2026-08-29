using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style slider sizing tokens.
/// </summary>
public sealed class SliderSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal SliderSizeBuilder(SliderSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal SliderSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public SliderSizeBuilder Default => Chain(SliderSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public SliderSizeBuilder Sm => Chain(SliderSizeEnum.Sm);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public SliderSizeBuilder Lg => Chain(SliderSizeEnum.Lg);

    /// <summary>
    /// Adds an arbitrary slider size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public SliderSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SliderSizeBuilder Chain(SliderSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SliderSizeBuilder Chain(string value)
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
