using System;

namespace Soenneker.Quark;

internal static class ColorUtility
{
    public static string CreateClass(string prefix, string value)
    {
        if (!IsTokenAllowed(value))
            return string.Empty;

        return string.Create(prefix.Length + value.Length, (prefix, value), static (span, state) =>
        {
            state.prefix.AsSpan().CopyTo(span);
            state.value.AsSpan().CopyTo(span[state.prefix.Length..]);
        });
    }

    public static string CreateUtilityClass(string prefix, string value)
    {
        return value.StartsWith(prefix, System.StringComparison.Ordinal) ? value : string.Empty;
    }

    private static bool IsTokenAllowed(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
            return false;

        ReadOnlySpan<char> span = token.AsSpan();
        int slashIndex = span.IndexOf('/');

        if (slashIndex > 0)
        {
            ReadOnlySpan<char> baseToken = span[..slashIndex];
            ReadOnlySpan<char> modifier = span[(slashIndex + 1)..];

            if ((IsPaletteToken(baseToken) || IsThemeToken(baseToken) || IsKeywordToken(baseToken)) && IsOpacityModifier(modifier))
                return true;
        }

        return IsPaletteToken(span) || IsThemeToken(span) || IsKeywordToken(span) || IsArbitraryToken(span);
    }

    private static bool IsKeywordToken(ReadOnlySpan<char> token)
    {
        return token is "inherit" or "current" or "transparent" or "black" or "white";
    }

    private static bool IsThemeToken(ReadOnlySpan<char> token)
    {
        return token is "primary" or "primary-foreground" or "secondary" or "secondary-foreground"
            or "success" or "danger" or "destructive" or "destructive-foreground"
            or "warning" or "info" or "light" or "dark" or "background" or "foreground"
            or "card" or "card-foreground" or "popover" or "popover-foreground"
            or "accent" or "accent-foreground" or "input" or "ring" or "border"
            or "body" or "body-secondary" or "body-tertiary" or "link" or "muted" or "muted-foreground";
    }

    private static bool IsPaletteToken(ReadOnlySpan<char> token)
    {
        int dashIndex = token.LastIndexOf('-');

        if (dashIndex <= 0 || dashIndex == token.Length - 1)
            return false;

        ReadOnlySpan<char> family = token[..dashIndex];
        ReadOnlySpan<char> shade = token[(dashIndex + 1)..];

        return IsPaletteFamily(family) && IsPaletteShade(shade);
    }

    private static bool IsPaletteFamily(ReadOnlySpan<char> family)
    {
        return family is "slate" or "gray" or "zinc" or "neutral" or "stone" or "red" or "orange" or "amber"
            or "yellow" or "lime" or "green" or "emerald" or "teal" or "cyan" or "sky" or "blue"
            or "indigo" or "violet" or "purple" or "fuchsia" or "pink" or "rose";
    }

    private static bool IsPaletteShade(ReadOnlySpan<char> shade)
    {
        return shade is "50" or "100" or "200" or "300" or "400" or "500" or "600" or "700" or "800" or "900" or "950";
    }

    private static bool IsArbitraryToken(ReadOnlySpan<char> token)
    {
        return token.Length >= 2
               && ((token[0] == '[' && token[^1] == ']')
                   || (token[0] == '(' && token[^1] == ')'));
    }

    private static bool IsOpacityModifier(ReadOnlySpan<char> modifier)
    {
        if (modifier.Length == 0)
            return false;

        if (modifier.Length >= 2 && modifier[0] == '[' && modifier[^1] == ']')
            return true;

        return modifier is "0" or "5" or "10" or "15" or "20" or "25" or "30" or "35" or "40" or "45"
            or "50" or "55" or "60" or "65" or "70" or "75" or "80" or "85" or "90" or "95" or "100";
    }
}
