using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Soenneker.Quark;

internal static partial class ColorUtility
{
    private static readonly HashSet<string> KeywordTokens = new(System.StringComparer.Ordinal)
    {
        "inherit",
        "current",
        "transparent",
        "black",
        "white"
    };

    private static readonly HashSet<string> ThemeTokens = new(System.StringComparer.Ordinal)
    {
        "primary",
        "primary-foreground",
        "secondary",
        "secondary-foreground",
        "success",
        "danger",
        "destructive",
        "destructive-foreground",
        "warning",
        "info",
        "light",
        "dark",
        "background",
        "foreground",
        "card",
        "card-foreground",
        "popover",
        "popover-foreground",
        "accent",
        "accent-foreground",
        "input",
        "ring",
        "border",
        "body",
        "body-secondary",
        "body-tertiary",
        "link",
        "muted",
        "muted-foreground"
    };

    public static string CreateClass(string prefix, string value)
    {
        return IsTokenAllowed(value) ? $"{prefix}{value}" : string.Empty;
    }

    public static string CreateUtilityClass(string prefix, string value)
    {
        return value.StartsWith(prefix, System.StringComparison.Ordinal) ? value : string.Empty;
    }

    private static bool IsTokenAllowed(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
            return false;

        int slashIndex = token.IndexOf('/');

        if (slashIndex > 0)
        {
            string baseToken = token[..slashIndex];
            string modifier = token[(slashIndex + 1)..];

            if ((IsPaletteToken(baseToken) || ThemeTokens.Contains(baseToken) || KeywordTokens.Contains(baseToken)) && IsOpacityModifier(modifier))
                return true;
        }

        return IsPaletteToken(token) || ThemeTokens.Contains(token) || KeywordTokens.Contains(token) || IsArbitraryToken(token);
    }

    private static bool IsPaletteToken(string token)
    {
        return PaletteTokenRegex().IsMatch(token);
    }

    private static bool IsArbitraryToken(string token)
    {
        return token.Length >= 2
               && ((token[0] == '[' && token[^1] == ']')
                   || (token[0] == '(' && token[^1] == ')'));
    }

    private static bool IsOpacityModifier(string modifier)
    {
        if (modifier.Length == 0)
            return false;

        if (modifier.Length >= 2 && modifier[0] == '[' && modifier[^1] == ']')
            return true;

        return OpacityModifierRegex().IsMatch(modifier);
    }

    [GeneratedRegex(@"^(?:slate|gray|zinc|neutral|stone|red|orange|amber|yellow|lime|green|emerald|teal|cyan|sky|blue|indigo|violet|purple|fuchsia|pink|rose)-(?:50|100|200|300|400|500|600|700|800|900|950)$", RegexOptions.CultureInvariant)]
    private static partial Regex PaletteTokenRegex();

    [GeneratedRegex(@"^(?:0|5|10|15|20|25|30|35|40|45|50|55|60|65|70|75|80|85|90|95|100)$", RegexOptions.CultureInvariant)]
    private static partial Regex OpacityModifierRegex();
}
