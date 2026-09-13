using System;

namespace Soenneker.Quark;

internal static class TokenRenderer
{
    public static string Render(RuleList<string> tokens, bool skipEmpty)
    {
        int count = tokens.Count;
        if (count == 0)
            return string.Empty;
        if (count == 1)
        {
            string token = tokens[0];
            if (skipEmpty && token.Length == 0)
                return string.Empty;
            return token ?? string.Empty;
        }

        int length = 0;
        int written = 0;
        for (var i = 0; i < count; i++)
        {
            string token = tokens[i];
            if (skipEmpty && token.Length == 0)
                continue;
            length = checked(length + (token?.Length ?? 0) + (written++ == 0 ? 0 : 1));
        }

        return string.Create(length, (tokens, skipEmpty), static (destination, state) =>
        {
            int position = 0;
            bool first = true;
            for (var i = 0; i < state.tokens.Count; i++)
            {
                string token = state.tokens[i];
                if (state.skipEmpty && token.Length == 0)
                    continue;
                if (!first)
                    destination[position++] = ' ';
                first = false;
                token.AsSpan().CopyTo(destination[position..]);
                position += token?.Length ?? 0;
            }
        });
    }
}
