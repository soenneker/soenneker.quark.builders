using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style checkbox sizing tokens.
/// </summary>
public sealed class CheckSizeBuilder : CssBuilderBase
{
    private RuleList<string> _tokens;

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
    public CheckSizeBuilder Default => Chain(CheckSizeEnum.DefaultValue);
    /// <summary>
    /// Gets or sets xs.
    /// </summary>
    public CheckSizeBuilder Xs => Chain(CheckSizeEnum.XsValue);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public CheckSizeBuilder Sm => Chain(CheckSizeEnum.SmValue);
    /// <summary>
    /// Gets or sets md.
    /// </summary>
    public CheckSizeBuilder Md => Chain(CheckSizeEnum.MdValue);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public CheckSizeBuilder Lg => Chain(CheckSizeEnum.LgValue);
    /// <summary>
    /// Gets or sets xl.
    /// </summary>
    public CheckSizeBuilder Xl => Chain(CheckSizeEnum.XlValue);
    /// <summary>
    /// Gets or sets xxl.
    /// </summary>
    public CheckSizeBuilder Xxl => Chain(CheckSizeEnum.XxlValue);

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

    public override string ToClass() => TokenRenderer.Render(_tokens, skipEmpty: false);

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}
