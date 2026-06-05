using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the final class utility builder.
/// </summary>
/// <typeparam name="TBuilder">The TBuilder type.</typeparam>
public abstract class FinalClassUtilityBuilder<TBuilder> : CssBuilderBase<TBuilder> where TBuilder : FinalClassUtilityBuilder<TBuilder>
{
    private readonly List<UtilityRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    protected FinalClassUtilityBuilder()
    {
    }

    protected FinalClassUtilityBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new UtilityRule(value, breakpoint));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected TBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new UtilityRule(value, ConsumePendingBreakpoint(), ConsumePendingModifierChain()));
        return (TBuilder)this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected TBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return (TBuilder)this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
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
            UtilityRule rule = _rules[i];
            string cls = rule.Value;
            if (cls.Length == 0)
                continue;

            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);

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

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
