using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Responsive builder for shadcn-style button size utility groups.
/// </summary>
[TailwindPrefix("", Responsive = true)]
public sealed class ButtonSizeBuilder : CssBuilderBase<ButtonSizeBuilder>
{
    private readonly List<ButtonSizeRule> _rules = new(4);

    internal ButtonSizeBuilder()
    {
    }

    internal ButtonSizeBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ButtonSizeRule(size, breakpoint));
    }

    internal ButtonSizeBuilder(List<ButtonSizeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public ButtonSizeBuilder Default => Chain("h-8 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    public ButtonSizeBuilder Xs => Chain("h-6 gap-1 rounded-[min(var(--radius-md),10px)] px-2 text-xs in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3");
    public ButtonSizeBuilder Sm => Chain("h-7 gap-1 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5");
    public ButtonSizeBuilder Lg => Chain("h-9 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    public ButtonSizeBuilder Icon => Chain("size-8");
    public ButtonSizeBuilder IconXs => Chain("size-6 rounded-[min(var(--radius-md),10px)] in-data-[slot=button-group]:rounded-lg [&_svg:not([class*='size-'])]:size-3");
    public ButtonSizeBuilder IconSm => Chain("size-7 rounded-[min(var(--radius-md),12px)] in-data-[slot=button-group]:rounded-lg");
    public ButtonSizeBuilder IconLg => Chain("size-9");

    /// <summary>
    /// Adds an arbitrary button size token understood by the shared button style helper.
    /// </summary>
    public ButtonSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ButtonSizeBuilder Chain(string size)
    {
        _rules.Add(new ButtonSizeRule(size, null, ConsumePendingModifierChain()));
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
            ButtonSizeRule rule = _rules[i];
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
