using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Accent color builder for form controls. Tailwind: accent-auto, accent-primary, accent-*.
/// </summary>
[TailwindPrefix("accent-", Responsive = true)]
public sealed class AccentColorBuilder : ColorBuilderBase<AccentColorBuilder>
{
    private const string Prefix = "accent-";

    private RuleList<AccentColorRule> _rules;

    internal AccentColorBuilder()
    {
    }

    internal AccentColorBuilder(AccentColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AccentColorRule(value.Value, breakpoint));
    }

    internal AccentColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new AccentColorRule(value, breakpoint));
    }

    internal AccentColorBuilder(List<AccentColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public AccentColorBuilder Auto => ChainClass(AccentColorEnum.AutoValue);
    /// <summary>
    /// `accent-primary` — uses your theme primary (shadcn maps this to CSS variables).
    /// </summary>
    public AccentColorBuilder Primary => ChainClass(AccentColorEnum.PrimaryValue);
    /// <summary>
    /// Fully transparent color (`transparent`).
    /// </summary>
    public AccentColorBuilder Transparent => ChainClass(AccentColorEnum.TransparentValue);
    /// <summary>
    /// `currentColor` — uses the element’s computed `color` (common for icons and rings).
    /// </summary>
    public AccentColorBuilder Current => ChainClass(AccentColorEnum.CurrentValue);


    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <returns>The result of the operation.</returns>
    public override AccentColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    /// <summary>
    /// Adds the utility Accent Color utility to the class list.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public AccentColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AccentColorBuilder Chain(AccentColorEnum value)
    {
        BreakpointType? breakpoint = null;
        _rules.Add(new AccentColorRule(value.Value, breakpoint, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AccentColorBuilder ChainClass(string value)
    {
        if (value.Length == 0)
            return this;

        BreakpointType? breakpoint = null;
        _rules.Add(new AccentColorRule(value, breakpoint, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            AccentColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                AccentColorRule rule = _rules[i];
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
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle()
        => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
