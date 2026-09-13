using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Builder for pagination sizing tokens.
/// </summary>
public sealed class PaginationSizeBuilder : CssBuilderBase
{
    private RuleList<string> _tokens;

    internal PaginationSizeBuilder(PaginationSizeEnum value)
    {
        _tokens.Add(value.Value);
    }

    internal PaginationSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public PaginationSizeBuilder Default => Chain(PaginationSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public PaginationSizeBuilder Sm => Chain(PaginationSizeEnum.SmValue);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public PaginationSizeBuilder Lg => Chain(PaginationSizeEnum.LgValue);

    /// <summary>
    /// Adds an arbitrary pagination size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public PaginationSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaginationSizeBuilder Chain(PaginationSizeEnum value)
    {
        _tokens.Add(value.Value);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private PaginationSizeBuilder Chain(string value)
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
