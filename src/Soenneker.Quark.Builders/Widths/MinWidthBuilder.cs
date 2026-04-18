

namespace Soenneker.Quark;

/// <summary>
/// Min-width builder with fluent API. Tailwind-first (min-w-*).
/// </summary>
[TailwindPrefix("min-w-", Responsive = true)]
public sealed class MinWidthBuilder : ICssBuilder
{
    private readonly string _token;

    internal MinWidthBuilder(string token)
    {
        _token = token;
    }

    public string ToClass()
    {
        string cls = GetMinWidthClass(_token);
        return cls.Length == 0 ? string.Empty : cls;
    }

    public string ToStyle() => string.Empty;

    private static string GetMinWidthClass(string token)
    {
        if (string.IsNullOrEmpty(token))
            return string.Empty;

        return token.StartsWith("min-w-") ? token : "min-w-" + token;
    }
}
