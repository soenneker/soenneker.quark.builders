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
        _rules.Add(new ButtonSizeRule(size.Class, breakpoint));
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

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public ButtonSizeBuilder Default => Chain(ButtonSizeEnum.Default);
    /// <summary>
    /// Gets or sets xs.
    /// </summary>
    public ButtonSizeBuilder Xs => Chain(ButtonSizeEnum.Xs);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public ButtonSizeBuilder Sm => Chain(ButtonSizeEnum.Sm);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public ButtonSizeBuilder Lg => Chain(ButtonSizeEnum.Lg);
    /// <summary>
    /// Gets or sets icon.
    /// </summary>
    public ButtonSizeBuilder Icon => Chain(ButtonSizeEnum.Icon);
    /// <summary>
    /// Gets or sets icon xs.
    /// </summary>
    public ButtonSizeBuilder IconXs => Chain(ButtonSizeEnum.IconXs);
    /// <summary>
    /// Gets or sets icon sm.
    /// </summary>
    public ButtonSizeBuilder IconSm => Chain(ButtonSizeEnum.IconSm);
    /// <summary>
    /// Gets or sets icon lg.
    /// </summary>
    public ButtonSizeBuilder IconLg => Chain(ButtonSizeEnum.IconLg);

    /// <summary>
    /// Adds an arbitrary button size token understood by the shared button style helper.
    /// </summary>
    public ButtonSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ButtonSizeBuilder Chain(ButtonSizeEnum size)
    {
        _rules.Add(new ButtonSizeRule(size.Class, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ButtonSizeBuilder Chain(string size)
    {
        _rules.Add(new ButtonSizeRule(size, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
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

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

}
