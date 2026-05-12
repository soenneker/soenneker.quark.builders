using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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

        string[] tokens = classGroup.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (tokens.Length == 0)
            return string.Empty;

        using var sb = new Soenneker.Utils.PooledStringBuilders.PooledStringBuilder();

        for (var i = 0; i < tokens.Length; i++)
        {
            string token = tokens[i];
            token = AppendTailwindModifiers(token, modifiers);

            if (i > 0)
                sb.Append(' ');

            sb.Append(token);
        }

        return sb.ToString();
    }

    public static string ApplyTailwindModifiers(string classGroup, string modifierChain)
    {
        if (string.IsNullOrEmpty(classGroup) || string.IsNullOrEmpty(modifierChain))
            return classGroup;

        string[] tokens = classGroup.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (tokens.Length == 0)
            return string.Empty;

        using var sb = new Soenneker.Utils.PooledStringBuilders.PooledStringBuilder();

        for (var i = 0; i < tokens.Length; i++)
        {
            string token = AppendTailwindModifierChain(tokens[i], modifierChain);

            if (i > 0)
                sb.Append(' ');

            sb.Append(token);
        }

        return sb.ToString();
    }

    private static string AppendTailwindModifiers(string token, IReadOnlyList<string> modifiers)
    {
        if (string.IsNullOrEmpty(token))
            return token;

        List<string> segments = SplitTailwindSegments(token);

        if (segments.Count == 0)
            return token;

        string utility = segments[^1];
        segments.RemoveAt(segments.Count - 1);

        var prefixedSegments = new List<string>(segments.Count + modifiers.Count + 1);

        for (var i = 0; i < modifiers.Count; i++)
        {
            string modifier = modifiers[i];

            if (!string.IsNullOrEmpty(modifier))
                prefixedSegments.Add(modifier);
        }

        prefixedSegments.AddRange(segments);
        prefixedSegments.Add(utility);

        return string.Join(":", prefixedSegments);
    }

    private static string AppendTailwindModifierChain(string token, string modifierChain)
    {
        if (string.IsNullOrEmpty(token))
            return token;

        List<string> segments = SplitTailwindSegments(token);

        if (segments.Count == 0)
            return token;

        string utility = segments[^1];
        segments.RemoveAt(segments.Count - 1);

        return segments.Count == 0
            ? $"{modifierChain}:{utility}"
            : $"{modifierChain}:{string.Join(":", segments)}:{utility}";
    }

    private static List<string> SplitTailwindSegments(string token)
    {
        var segments = new List<string>(4);
        var start = 0;
        var squareDepth = 0;
        var parenDepth = 0;
        var braceDepth = 0;

        for (var i = 0; i < token.Length; i++)
        {
            char ch = token[i];

            switch (ch)
            {
                case '[':
                    squareDepth++;
                    break;
                case ']':
                    if (squareDepth > 0)
                        squareDepth--;
                    break;
                case '(':
                    parenDepth++;
                    break;
                case ')':
                    if (parenDepth > 0)
                        parenDepth--;
                    break;
                case '{':
                    braceDepth++;
                    break;
                case '}':
                    if (braceDepth > 0)
                        braceDepth--;
                    break;
                case ':':
                    if (squareDepth == 0 && parenDepth == 0 && braceDepth == 0)
                    {
                        segments.Add(token[start..i]);
                        start = i + 1;
                    }

                    break;
            }
        }

        segments.Add(token[start..]);

        return segments;
    }
}

