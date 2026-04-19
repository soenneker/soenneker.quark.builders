

namespace Soenneker.Quark;

/// <summary>
/// Min-width builder with fluent API. Tailwind-first (min-w-*).
/// </summary>
[TailwindPrefix("min-w-", Responsive = true)]
public sealed class MinWidthBuilder : CssBuilderBase
{
    private readonly string _token;

    internal MinWidthBuilder(string token)
    {
        _token = token;
    }

    public override string ToClass()
    {
        return _token.Length == 0 ? string.Empty : _token;
    }

    public override string ToStyle() => string.Empty;
}
