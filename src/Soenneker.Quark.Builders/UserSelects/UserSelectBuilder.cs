
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
    private RuleList<UserSelectRule> _rules;

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



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            UserSelectRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                UserSelectRule rule = _rules[i];
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
