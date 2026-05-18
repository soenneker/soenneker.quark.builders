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

    internal ButtonSizeBuilder(ButtonSizeEnum size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ButtonSizeRule(size.Value, breakpoint));
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

    public ButtonSizeBuilder Default => Chain(ButtonSizeEnum.Default);
    public ButtonSizeBuilder Xs => Chain(ButtonSizeEnum.Xs);
    public ButtonSizeBuilder Sm => Chain(ButtonSizeEnum.Sm);
    public ButtonSizeBuilder Lg => Chain(ButtonSizeEnum.Lg);
    public ButtonSizeBuilder Icon => Chain(ButtonSizeEnum.Icon);
    public ButtonSizeBuilder IconXs => Chain(ButtonSizeEnum.IconXs);
    public ButtonSizeBuilder IconSm => Chain(ButtonSizeEnum.IconSm);
    public ButtonSizeBuilder IconLg => Chain(ButtonSizeEnum.IconLg);

    /// <summary>
    /// Adds an arbitrary button size token understood by the shared button style helper.
    /// </summary>
    public ButtonSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ButtonSizeBuilder Chain(ButtonSizeEnum size)
    {
        _rules.Add(new ButtonSizeRule(size.Value, null, ConsumePendingModifierChain()));
        return this;
    }

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
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, bp);

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

}
