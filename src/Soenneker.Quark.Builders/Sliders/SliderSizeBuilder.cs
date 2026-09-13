using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style slider sizing tokens.
/// </summary>
public sealed class SliderSizeBuilder : CssBuilderBase
{
    private RuleList<string> _tokens;

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
    public SliderSizeBuilder Default => Chain(SliderSizeEnum.DefaultValue);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public SliderSizeBuilder Sm => Chain(SliderSizeEnum.SmValue);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public SliderSizeBuilder Lg => Chain(SliderSizeEnum.LgValue);

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

    public override string ToClass() => TokenRenderer.Render(_tokens, skipEmpty: false);

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
