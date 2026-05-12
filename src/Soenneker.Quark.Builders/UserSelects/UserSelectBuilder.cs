
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified user select builder with fluent API for chaining user select rules.
/// </summary>
[TailwindPrefix("select-", Responsive = true)]
public sealed class UserSelectBuilder : CssBuilderBase<UserSelectBuilder>
{
    private readonly List<UserSelectRule> _rules = new(4);

    internal UserSelectBuilder()
    {
    }

    internal UserSelectBuilder(UserSelectEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new UserSelectRule(value.Value, breakpoint));
    }

    internal UserSelectBuilder(List<UserSelectRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the user select to none.
    /// </summary>
    public UserSelectBuilder None => Chain(UserSelectEnum.None);

    /// <summary>
    /// Sets the user select to auto.
    /// </summary>
    public UserSelectBuilder Auto => Chain(UserSelectEnum.Auto);

    /// <summary>
    /// Sets the user select to all.
    /// </summary>
    public UserSelectBuilder All => Chain(UserSelectEnum.All);







    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private UserSelectBuilder Chain(UserSelectEnum value)
    {
        _rules.Add(new UserSelectRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }



    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            UserSelectRule rule = _rules[i];
            string cls = rule.Value;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;
    public override string ToString() => ToClass();
}
