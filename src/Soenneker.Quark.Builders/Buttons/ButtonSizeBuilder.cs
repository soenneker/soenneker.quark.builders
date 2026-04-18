using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Responsive builder for shadcn-style button size utility groups.
/// </summary>
[TailwindPrefix("", Responsive = true)]
public sealed class ButtonSizeBuilder : CssBuilderBase
{
    private readonly List<ButtonSizeRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal ButtonSizeBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ButtonSizeRule(size, breakpoint));
    }

    internal ButtonSizeBuilder(List<ButtonSizeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public ButtonSizeBuilder Default => Chain("default");
    public ButtonSizeBuilder Xs => Chain("xs");
    public ButtonSizeBuilder Sm => Chain("sm");
    public ButtonSizeBuilder Lg => Chain("lg");
    public ButtonSizeBuilder Icon => Chain("icon");
    public ButtonSizeBuilder IconXs => Chain("icon-xs");
    public ButtonSizeBuilder IconSm => Chain("icon-sm");
    public ButtonSizeBuilder IconLg => Chain("icon-lg");

    /// <summary>
    /// Adds an arbitrary button size token understood by the shared button style helper.
    /// </summary>
    public ButtonSizeBuilder Token(string value) => Chain(value);

    public ButtonSizeBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ButtonSizeBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ButtonSizeBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ButtonSizeBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ButtonSizeBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ButtonSizeBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ButtonSizeBuilder Chain(string size)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new ButtonSizeRule(size, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ButtonSizeBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
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
            string cls = ButtonStyleUtil.GetSizeClass(rule.Size);

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

            if (bp.Length != 0)
                cls = ApplyBreakpointToClassGroup(cls, bp);

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
