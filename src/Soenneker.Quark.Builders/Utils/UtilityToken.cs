namespace Soenneker.Quark;

internal static class UtilityToken
{
    internal static string WithPrefix(string value, string prefix) =>
        value.StartsWith(prefix, System.StringComparison.Ordinal) ? value : prefix + value;

    internal static string WithSignedPrefix(string value, string prefix) =>
        value.StartsWith("-", System.StringComparison.Ordinal)
            ? "-" + WithPrefix(value[1..], prefix)
            : WithPrefix(value, prefix);
}
