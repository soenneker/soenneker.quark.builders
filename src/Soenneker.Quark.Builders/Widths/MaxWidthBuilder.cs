

namespace Soenneker.Quark;

/// <summary>
/// Max-width builder with fluent API. Tailwind-first (max-w-*).
/// </summary>
[TailwindPrefix("max-w-", Responsive = true)]
public sealed class MaxWidthBuilder : CssBuilderBase
{
    private readonly string _token;

    internal MaxWidthBuilder(string token)
    {
        _token = token;
    }

    public override string ToClass()
    {
        return _token.Length == 0 ? string.Empty : _token;
    }

    public override string ToStyle() => string.Empty;
}
