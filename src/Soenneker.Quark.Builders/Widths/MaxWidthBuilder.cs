

namespace Soenneker.Quark;

/// <summary>
/// Max-width builder with fluent API. Tailwind-first (max-w-*).
/// </summary>
[TailwindPrefix("max-w-", Responsive = true)]
public sealed class MaxWidthBuilder : ICssBuilder
{
    private readonly string _token;

    internal MaxWidthBuilder(string token)
    {
        _token = token;
    }

    public string ToClass()
    {
        string cls = GetMaxWidthClass(_token);
        return cls.Length == 0 ? string.Empty : cls;
    }

    public string ToStyle() => string.Empty;

    private static string GetMaxWidthClass(string token)
    {
        if (string.IsNullOrEmpty(token))
            return string.Empty;

        return token.StartsWith("max-w-") ? token : "max-w-" + token;
    }
}
