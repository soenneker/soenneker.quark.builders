
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance shadow builder with fluent API for chaining shadow rules.
/// </summary>
[TailwindPrefix("shadow-", Responsive = true)]
public sealed class ShadowBuilder : CssBuilderBase<ShadowBuilder>
{
    private RuleList<ShadowRule> _rules;

    internal ShadowBuilder()
    {
    }

    internal ShadowBuilder(ShadowKeyword value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ShadowRule(value.Value, breakpoint));
    }

    internal ShadowBuilder(List<ShadowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the shadow to none.
    /// </summary>
    public ShadowBuilder None => Chain(ShadowKeyword.None);

    /// <summary>
    /// Sets the shadow to extra small.
    /// </summary>
    public ShadowBuilder Xs => Chain(ShadowKeyword.Xs);

    /// <summary>
    /// Sets the shadow to small.
    /// </summary>
    public ShadowBuilder Sm => Chain(ShadowKeyword.Sm);

    /// <summary>
    /// Sets the shadow to the default value.
    /// </summary>
    public ShadowBuilder Default => Chain(ShadowKeyword.Default);

    /// <summary>
    /// Sets the shadow to medium.
    /// </summary>
    public ShadowBuilder Md => Chain(ShadowKeyword.Md);

    /// <summary>
    /// Sets the shadow to large.
    /// </summary>
    public ShadowBuilder Lg => Chain(ShadowKeyword.Lg);

    /// <summary>
    /// Sets the shadow to extra large.
    /// </summary>
    public ShadowBuilder Xl => Chain(ShadowKeyword.Xl);

    /// <summary>
    /// Sets the shadow to 2x extra large.
    /// </summary>
    public ShadowBuilder TwoXl => Chain(ShadowKeyword.TwoXl);

    /// <summary>
    /// Sets the shadow to inner.
    /// </summary>
    public ShadowBuilder Inner => Chain(ShadowKeyword.Inner);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ShadowBuilder Chain(ShadowKeyword value)
    {
        _rules.Add(new ShadowRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ShadowRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ShadowRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// Shadow utilities are class-first; no inline style mapping.
    /// </summary>
    /// <returns>An empty string as shadow utilities are class-first.</returns>
    public override string ToStyle() => string.Empty;
}
