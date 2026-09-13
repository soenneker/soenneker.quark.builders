using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// Simplified float builder with fluent API for chaining float rules.
/// </summary>
[TailwindPrefix("float-", Responsive = true)]
public sealed class FloatBuilder : CssBuilderBase<FloatBuilder>
{
    private RuleList<FloatRule> _rules;

    internal FloatBuilder()
    {
    }

    internal FloatBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FloatRule(value, breakpoint));
    }

    internal FloatBuilder(FloatEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FloatRule(value.Value, breakpoint));
    }

    internal FloatBuilder(List<FloatRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the float to none.
    /// </summary>
    public FloatBuilder None => ChainWithValue(FloatEnum.NoneValue);

    /// <summary>
    /// Sets the float to left.
    /// </summary>
    public FloatBuilder Left => ChainWithValue(FloatEnum.LeftValue);

    /// <summary>
    /// Sets the float to right.
    /// </summary>
    public FloatBuilder Right => ChainWithValue(FloatEnum.RightValue);

    /// <summary>
    /// Sets the float to start (inline-start).
    /// </summary>
    public FloatBuilder Start => ChainWithValue(FloatEnum.StartValue);

    /// <summary>
    /// Sets the float to end (inline-end).
    /// </summary>
    public FloatBuilder End => ChainWithValue(FloatEnum.EndValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FloatBuilder ChainWithValue(string value)
    {
        _rules.Add(new FloatRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FloatBuilder ChainWithValue(FloatEnum value)
    {
        _rules.Add(new FloatRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            FloatRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                FloatRule rule = _rules[i];
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
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}