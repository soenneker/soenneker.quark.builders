using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style select sizing tokens.
/// </summary>
public sealed class SelectSizeBuilder : CssBuilderBase
{
    private RuleList<string> _tokens;

    internal SelectSizeBuilder(SelectSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal SelectSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public SelectSizeBuilder Default => Chain(SelectSizeEnum.DefaultValue);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public SelectSizeBuilder Sm => Chain(SelectSizeEnum.SmValue);

    /// <summary>
    /// Adds an arbitrary select size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public SelectSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SelectSizeBuilder Chain(SelectSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SelectSizeBuilder Chain(string value)
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
