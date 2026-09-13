
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified resize builder with fluent API for chaining resize rules.
/// </summary>
[TailwindPrefix("resize-", Responsive = true)]
public sealed class ResizeBuilder : CssBuilderBase<ResizeBuilder>
{
    private RuleList<ResizeRule> _rules;

    internal ResizeBuilder()
    {
    }

    internal ResizeBuilder(string resize, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ResizeRule(resize, breakpoint));
    }

    internal ResizeBuilder(ResizeEnum resize, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ResizeRule(resize.Value, breakpoint));
    }

    internal ResizeBuilder(List<ResizeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the resize to none.
    /// </summary>
    public ResizeBuilder None => ChainWithResize(ResizeEnum.NoneValue);
    /// <summary>
    /// Sets the resize to both.
    /// </summary>
    public ResizeBuilder Both => ChainWithResize(ResizeEnum.BothValue);
    /// <summary>
    /// Sets the resize to horizontal.
    /// </summary>
    public ResizeBuilder Horizontal => ChainWithResize(ResizeEnum.HorizontalValue);
    /// <summary>
    /// Sets the resize to vertical.
    /// </summary>
    public ResizeBuilder Vertical => ChainWithResize(ResizeEnum.VerticalValue);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ResizeBuilder ChainWithResize(string resize)
    {
        _rules.Add(new ResizeRule(resize, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ResizeBuilder ChainWithResize(ResizeEnum resize)
    {
        _rules.Add(new ResizeRule(resize.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ResizeBuilder ChainWithBreakpoint(BreakpointType breakpoint)
    {
        if (_rules.Count == 0)
        {
            _rules.Add(new ResizeRule("none", breakpoint));
            return this;
        }

        int lastIdx = _rules.Count - 1;
        ResizeRule last = _rules[lastIdx];
        _rules[lastIdx] = new ResizeRule(last.Resize, breakpoint, last.ModifierChain);
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ResizeRule rule = _rules[0];
            return ClassWriter.Render(rule.Resize, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ResizeRule rule = _rules[i];
                writer.Add(rule.Resize, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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

    /// <summary>
    /// Returns the CSS class string representation of this resize builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
