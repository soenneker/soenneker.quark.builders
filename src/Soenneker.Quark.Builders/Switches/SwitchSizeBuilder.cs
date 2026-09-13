using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style switch sizing tokens.
/// </summary>
public sealed class SwitchSizeBuilder : CssBuilderBase
{
    private RuleList<string> _tokens;

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
    public SwitchSizeBuilder Default => Chain(SwitchSizeEnum.DefaultValue);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public SwitchSizeBuilder Sm => Chain(SwitchSizeEnum.SmValue);

    /// <summary>
    /// Adds an arbitrary switch size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
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

    public override string ToClass() => TokenRenderer.Render(_tokens, skipEmpty: false);

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
