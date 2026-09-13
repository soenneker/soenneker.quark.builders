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

    /// <summary>
    /// Applies the specified Tailwind modifier to the pending utility.
    /// </summary>
    /// <param name="className">Name of the class to target.</param>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <returns>The text produced by apply Tailwind Modifier.</returns>
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

    /// <summary>
    /// Applies the specified Tailwind modifiers to the pending utility, in order.
    /// </summary>
    /// <param name="classGroup">Class Group for the apply tailwind modifiers operation.</param>
    /// <param name="modifiers">Modifiers to append to the pending utility, in order.</param>
    /// <returns>The text produced by apply Tailwind Modifiers.</returns>
    public static string ApplyTailwindModifiers(string classGroup, IReadOnlyList<string> modifiers)
    {
        if (string.IsNullOrEmpty(classGroup) || modifiers.Count == 0)
            return classGroup;

        if (modifiers.Count == 1 && !string.IsNullOrEmpty(modifiers[0]))
            return ApplyTailwindModifiers(classGroup, modifiers[0]);

        int prefixLength = EstimateModifierLength(modifiers);
        int length = GetModifiedLength(classGroup, prefixLength, out Range singleToken);
        if (singleToken.Start.Value == 0 && singleToken.End.Value == classGroup.Length)
        {
            return string.Create(length, (classGroup, modifiers), static (destination, state) =>
            {
                int position = 0;
                for (var i = 0; i < state.modifiers.Count; i++)
                {
                    string modifier = state.modifiers[i];
                    if (string.IsNullOrEmpty(modifier))
                        continue;
                    modifier.AsSpan().CopyTo(destination[position..]);
                    position += modifier.Length;
                    destination[position++] = ':';
                }
                state.classGroup.AsSpan().CopyTo(destination[position..]);
            });
        }
        return string.Create(length, (classGroup, modifiers), static (destination, state) =>
        {
            int position = 0;
            for (var i = 0; i < state.modifiers.Count; i++)
            {
                string modifier = state.modifiers[i];
                if (string.IsNullOrEmpty(modifier))
                    continue;
                modifier.AsSpan().CopyTo(destination[position..]);
                position += modifier.Length;
                destination[position++] = ':';
            }
            int prefixLength = position;
            bool first = true;
            foreach (Range range in new ClassTokens(state.classGroup))
            {
                if (!first)
                {
                    destination[position++] = ' ';
                    // The complete prefix already exists at the start of the
                    // output. Copy it rather than traversing modifiers again.
                    destination[..prefixLength].CopyTo(destination[position..]);
                    position += prefixLength;
                }
                first = false;
                ReadOnlySpan<char> token = state.classGroup.AsSpan()[range];
                token.CopyTo(destination[position..]);
                position += token.Length;
            }
        });
    }

    /// <summary>
    /// Applies the specified Tailwind modifiers to the pending utility, in order.
    /// </summary>
    /// <param name="classGroup">Class Group for the apply tailwind modifiers operation.</param>
    /// <param name="modifierChain">Modifier Chain for the apply tailwind modifiers operation.</param>
    /// <returns>The text produced by apply Tailwind Modifiers.</returns>
    public static string ApplyTailwindModifiers(string classGroup, string modifierChain)
    {
        if (string.IsNullOrEmpty(classGroup) || string.IsNullOrEmpty(modifierChain))
            return classGroup;

        int length = GetModifiedLength(classGroup, modifierChain.Length + 1);
        return string.Create(length, (classGroup, modifierChain), static (destination, state) =>
        {
            int position = 0;
            foreach (Range range in new ClassTokens(state.classGroup))
            {
                if (position != 0)
                    destination[position++] = ' ';
                state.modifierChain.AsSpan().CopyTo(destination[position..]);
                position += state.modifierChain.Length;
                destination[position++] = ':';
                ReadOnlySpan<char> token = state.classGroup.AsSpan()[range];
                token.CopyTo(destination[position..]);
                position += token.Length;
            }
        });
    }

    private static int GetModifiedLength(string classGroup, int prefixLength)
    {
        int length = 0;
        foreach (Range range in new ClassTokens(classGroup))
            length = checked(length + (length == 0 ? 0 : 1) + prefixLength + range.End.Value - range.Start.Value);
        return length;
    }

    private static int GetModifiedLength(string classGroup, int prefixLength, out Range singleToken)
    {
        int length = 0;
        singleToken = default;
        foreach (Range range in new ClassTokens(classGroup))
        {
            // A nonempty range survives only when the group has one token.
            // Its characters then need no second scan during string creation.
            singleToken = length == 0 ? range : default;
            length = checked(length + (length == 0 ? 0 : 1) + prefixLength + range.End.Value - range.Start.Value);
        }
        return length;
    }

    internal static void AppendClassGroupWithModifierChain(ref PooledStringBuilder sb, string classGroup, string? modifierChain, string? breakpoint = null)
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

            if (!string.IsNullOrEmpty(modifierChain))
            {
                sb.Append(modifierChain);
                sb.Append(':');
            }
            if (!string.IsNullOrEmpty(breakpoint))
            {
                sb.Append(breakpoint);
                sb.Append(':');
            }
            sb.Append(classGroup.AsSpan(tokenStart, i - tokenStart));
            tokenStart = -1;
        }
    }

    private static int EstimateModifierLength(IReadOnlyList<string> modifiers)
    {
        var length = 0;

        for (var i = 0; i < modifiers.Count; i++)
        {
            string modifier = modifiers[i];

            if (!string.IsNullOrEmpty(modifier))
                length = checked(length + modifier.Length + 1);
        }

        return length;
    }
}
