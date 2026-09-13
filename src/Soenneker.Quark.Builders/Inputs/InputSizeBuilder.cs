using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style text input sizing tokens.
/// </summary>
public sealed class InputSizeBuilder : CssBuilderBase
{
    private RuleList<string> _tokens;

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
    public InputSizeBuilder Sm => Chain(InputSizeEnum.SmValue);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public InputSizeBuilder Lg => Chain(InputSizeEnum.LgValue);

    /// <summary>
    /// Adds an arbitrary input size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
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

    public override string ToClass() => TokenRenderer.Render(_tokens, skipEmpty: true);

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
