using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Responsive builder for shadcn-style toggle size utility groups.
/// </summary>
[TailwindPrefix("", Responsive = true)]
public sealed class ToggleSizeBuilder : CssBuilderBase<ToggleSizeBuilder>
{
    private readonly List<ToggleSizeRule> _rules = new(4);

    internal ToggleSizeBuilder()
    {
    }

    internal ToggleSizeBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ToggleSizeRule(size, breakpoint));
    }

    internal ToggleSizeBuilder(List<ToggleSizeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public ToggleSizeBuilder Default => Chain("h-9 min-w-9 px-2");
    public ToggleSizeBuilder Sm => Chain("h-8 min-w-8 px-1.5");
    public ToggleSizeBuilder Lg => Chain("h-10 min-w-10 px-2.5");

    public ToggleSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ToggleSizeBuilder Chain(string size)
    {
        _rules.Add(new ToggleSizeRule(size, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            ToggleSizeRule rule = _rules[i];
            string cls = rule.Size;

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

            if (bp.Length != 0)
                cls = ApplyBreakpointToClassGroup(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ApplyBreakpointToClassGroup(string classGroup, string breakpoint)
    {
        string[] tokens = classGroup.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (tokens.Length == 0)
            return string.Empty;

        if (tokens.Length == 1)
            return BreakpointUtil.ApplyTailwindBreakpoint(tokens[0], breakpoint);

        using var sb = new PooledStringBuilder();

        for (var i = 0; i < tokens.Length; i++)
        {
            if (i > 0)
                sb.Append(' ');

            sb.Append(BreakpointUtil.ApplyTailwindBreakpoint(tokens[i], breakpoint));
        }

        return sb.ToString();
    }

}
