
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified object-fit builder with fluent API for chaining object-fit rules.
/// </summary>
[TailwindPrefix("object-", Responsive = true)]
public sealed class ObjectFitBuilder : CssBuilderBase<ObjectFitBuilder>
{
    private RuleList<ObjectFitRule> _rules;

    internal ObjectFitBuilder()
    {
    }

    internal ObjectFitBuilder(string fit, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ObjectFitRule(fit, breakpoint));
    }

    internal ObjectFitBuilder(ObjectFitEnum fit, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ObjectFitRule(fit.Value, breakpoint));
    }

    internal ObjectFitBuilder(List<ObjectFitRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Chain with contain for the next rule.
    /// </summary>
    public ObjectFitBuilder Contain => ChainWithFit(ObjectFitEnum.ContainValue);

    /// <summary>
    /// Chain with cover for the next rule.
    /// </summary>
    public ObjectFitBuilder Cover => ChainWithFit(ObjectFitEnum.CoverValue);

    /// <summary>
    /// Chain with fill for the next rule.
    /// </summary>
    public ObjectFitBuilder Fill => ChainWithFit(ObjectFitEnum.FillValue);

    /// <summary>
    /// Chain with scale-down for the next rule.
    /// </summary>
    public ObjectFitBuilder ScaleDown => ChainWithFit(ObjectFitEnum.ScaleDownValue);

    /// <summary>
    /// Chain with none for the next rule.
    /// </summary>
    public ObjectFitBuilder None => ChainWithFit(ObjectFitEnum.NoneValue);







    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ObjectFitBuilder ChainWithFit(string fit)
    {
        BreakpointType? bp = null;
        _rules.Add(new ObjectFitRule(fit, bp, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ObjectFitBuilder ChainWithFit(ObjectFitEnum fit)
    {
        BreakpointType? bp = null;
        _rules.Add(new ObjectFitRule(fit.Value, bp, ConsumePendingModifierChain()));
        return this;
    }


    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ObjectFitRule rule = _rules[0];
            return ClassWriter.Render(rule.Fit, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ObjectFitRule rule = _rules[i];
                writer.Add(rule.Fit, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// </summary>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
