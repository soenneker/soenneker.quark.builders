namespace Soenneker.Quark;

internal static class UtilityToken
{
    internal static string ArbitraryProperty(string property, string value) => "[" + property + ":" + value + "]";

    internal static string WithPrefix(string value, string prefix) =>
        prefix + value;

    internal static string WithSignedPrefix(string value, string prefix) =>
        value.StartsWith('-')
            ? "-" + WithPrefix(value[1..], prefix)
            : WithPrefix(value, prefix);
}
