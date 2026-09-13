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
    private RuleList<ButtonSizeRule> _rules;

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
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
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

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ButtonSizeRule rule = _rules[0];
            return ClassWriter.Render(rule.Size, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain, breakpointPerToken: true);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ButtonSizeRule rule = _rules[i];
                writer.Add(rule.Size, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain, breakpointPerToken: true);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

}
