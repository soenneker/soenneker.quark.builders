using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Shared utilities for converting breakpoint values into Tailwind-responsive class prefixes.
/// </summary>
public static class BreakpointUtil
{
    /// <summary>
    /// Converts a BreakpointType to its corresponding CSS class token.
    /// Returns empty string for phone/extra-small (default) BreakpointTypes.
    /// </summary>
    /// <param name="breakpoint">The BreakpointType to convert</param>
    /// <returns>The CSS class token (e.g., "sm", "md", "lg", "xl", "2xl") or empty string.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetBreakpointToken(BreakpointType? breakpoint)
    {
        return breakpoint?.Value ?? string.Empty;
    }

    /// <summary>
    /// Returns the Tailwind responsive class: breakpoint prefix + class (e.g. "md" + "col-span-2" => "md:col-span-2").
    /// Use for all Tailwind utilities that use the bp:utility format.
    /// </summary>
    /// <param name="className">The base CSS class name</param>
    /// <param name="bp">The breakpoint token (e.g., "sm", "md", "lg", "xl", "2xl") or empty</param>
    /// <returns>The class with Tailwind responsive prefix, or the class unchanged if bp is empty</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ApplyTailwindBreakpoint(string className, string bp)
    {
        if (string.IsNullOrEmpty(bp))
            return className;
        return string.Create(bp.Length + 1 + className.Length, (className, bp), static (dst, s) =>
        {
            s.bp.AsSpan().CopyTo(dst);
            int idx = s.bp.Length;
            dst[idx++] = ':';
            s.className.AsSpan().CopyTo(dst[idx..]);
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ApplyTailwindModifier(string className, string modifier)
    {
        if (string.IsNullOrEmpty(modifier))
            return className;

        return string.Create(modifier.Length + 1 + className.Length, (className, modifier), static (dst, s) =>
        {
            s.modifier.AsSpan().CopyTo(dst);
            int idx = s.modifier.Length;
            dst[idx++] = ':';
            s.className.AsSpan().CopyTo(dst[idx..]);
        });
    }

    public static string ApplyTailwindModifiers(string classGroup, IReadOnlyList<string> modifiers)
    {
        if (string.IsNullOrEmpty(classGroup) || modifiers.Count == 0)
            return classGroup;

        var sb = new PooledStringBuilder(classGroup.Length + EstimateModifierLength(modifiers));

        try
        {
            AppendClassGroupWithModifiers(ref sb, classGroup, modifiers);
            return sb.ToString();
        }
        finally
        {
            sb.Dispose();
        }
    }

    public static string ApplyTailwindModifiers(string classGroup, string modifierChain)
    {
        if (string.IsNullOrEmpty(classGroup) || string.IsNullOrEmpty(modifierChain))
            return classGroup;

        var sb = new PooledStringBuilder(classGroup.Length + modifierChain.Length + 1);

        try
        {
            AppendClassGroupWithModifierChain(ref sb, classGroup, modifierChain);
            return sb.ToString();
        }
        finally
        {
            sb.Dispose();
        }
    }

    private static void AppendClassGroupWithModifiers(ref PooledStringBuilder sb, string classGroup, IReadOnlyList<string> modifiers)
    {
        var tokenStart = -1;
        var first = true;

        for (var i = 0; i <= classGroup.Length; i++)
        {
            bool isEnd = i == classGroup.Length;

            if (!isEnd && !char.IsWhiteSpace(classGroup[i]))
            {
                if (tokenStart < 0)
                    tokenStart = i;

                continue;
            }

            if (tokenStart < 0)
                continue;

            if (!first)
                sb.Append(' ');
            else
                first = false;

            AppendTokenWithModifiers(ref sb, classGroup.AsSpan(tokenStart, i - tokenStart), modifiers);
            tokenStart = -1;
        }
    }

    private static void AppendClassGroupWithModifierChain(ref PooledStringBuilder sb, string classGroup, string modifierChain)
    {
        var tokenStart = -1;
        var first = true;

        for (var i = 0; i <= classGroup.Length; i++)
        {
            bool isEnd = i == classGroup.Length;

            if (!isEnd && !char.IsWhiteSpace(classGroup[i]))
            {
                if (tokenStart < 0)
                    tokenStart = i;

                continue;
            }

            if (tokenStart < 0)
                continue;

            if (!first)
                sb.Append(' ');
            else
                first = false;

            AppendTokenWithModifierChain(ref sb, classGroup.AsSpan(tokenStart, i - tokenStart), modifierChain);
            tokenStart = -1;
        }
    }

    private static void AppendTokenWithModifiers(ref PooledStringBuilder sb, ReadOnlySpan<char> token, IReadOnlyList<string> modifiers)
    {
        var wroteModifier = false;

        for (var i = 0; i < modifiers.Count; i++)
        {
            string modifier = modifiers[i];

            if (string.IsNullOrEmpty(modifier))
                continue;

            if (wroteModifier)
                sb.Append(':');

            sb.Append(modifier);
            wroteModifier = true;
        }

        if (wroteModifier)
            sb.Append(':');

        AppendSpan(ref sb, token);
    }

    private static void AppendTokenWithModifierChain(ref PooledStringBuilder sb, ReadOnlySpan<char> token, string modifierChain)
    {
        sb.Append(modifierChain);
        sb.Append(':');
        AppendSpan(ref sb, token);
    }

    private static void AppendSpan(ref PooledStringBuilder sb, ReadOnlySpan<char> value)
    {
        for (var i = 0; i < value.Length; i++)
            sb.Append(value[i]);
    }

    private static int EstimateModifierLength(IReadOnlyList<string> modifiers)
    {
        var length = 0;

        for (var i = 0; i < modifiers.Count; i++)
        {
            string modifier = modifiers[i];

            if (!string.IsNullOrEmpty(modifier))
                length += modifier.Length + 1;
        }

        return length;
    }
}

