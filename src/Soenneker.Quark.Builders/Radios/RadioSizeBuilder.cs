using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style radio sizing tokens.
/// </summary>
public sealed class RadioSizeBuilder : CssBuilderBase
{
    private RuleList<string> _tokens;

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
    public RadioSizeBuilder Default => Chain(RadioSizeEnum.DefaultValue);
    /// <summary>
    /// Gets or sets xs.
    /// </summary>
    public RadioSizeBuilder Xs => Chain(RadioSizeEnum.XsValue);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public RadioSizeBuilder Sm => Chain(RadioSizeEnum.SmValue);
    /// <summary>
    /// Gets or sets md.
    /// </summary>
    public RadioSizeBuilder Md => Chain(RadioSizeEnum.MdValue);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public RadioSizeBuilder Lg => Chain(RadioSizeEnum.LgValue);
    /// <summary>
    /// Gets or sets xl.
    /// </summary>
    public RadioSizeBuilder Xl => Chain(RadioSizeEnum.XlValue);
    /// <summary>
    /// Gets or sets xxl.
    /// </summary>
    public RadioSizeBuilder Xxl => Chain(RadioSizeEnum.XxlValue);

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

    public override string ToClass() => TokenRenderer.Render(_tokens, skipEmpty: false);

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
