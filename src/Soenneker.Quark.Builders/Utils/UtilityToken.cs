namespace Soenneker.Quark;

internal static class UtilityToken
{
    internal static string WithPrefix(string value, string prefix) =>
        value.StartsWith(prefix, System.StringComparison.Ordinal) ? value : prefix + value;
}
