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
    private readonly List<FloatRule> _rules = new(4);

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
    public FloatBuilder None => ChainWithValue(FloatEnum.None);

    /// <summary>
    /// Sets the float to left.
    /// </summary>
    public FloatBuilder Left => ChainWithValue(FloatEnum.Left);

    /// <summary>
    /// Sets the float to right.
    /// </summary>
    public FloatBuilder Right => ChainWithValue(FloatEnum.Right);

    /// <summary>
    /// Sets the float to start (inline-start).
    /// </summary>
    public FloatBuilder Start => ChainWithValue(FloatEnum.Start);

    /// <summary>
    /// Sets the float to end (inline-end).
    /// </summary>
    public FloatBuilder End => ChainWithValue(FloatEnum.End);

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

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            FloatRule rule = _rules[i];

            string cls = rule.Value;

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

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