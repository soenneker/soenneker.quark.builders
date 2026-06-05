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

    private readonly List<AccentColorRule> _rules = new(4);

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
    public AccentColorBuilder Auto => Chain(AccentColorEnum.Auto);
    /// <summary>
    /// `accent-primary` — uses your theme primary (shadcn maps this to CSS variables).
    /// </summary>
    public AccentColorBuilder Primary => Chain(AccentColorEnum.Primary);
    /// <summary>
    /// Fully transparent color (`transparent`).
    /// </summary>
    public AccentColorBuilder Transparent => Chain(AccentColorEnum.Transparent);
    /// <summary>
    /// `currentColor` — uses the element’s computed `color` (common for icons and rings).
    /// </summary>
    public AccentColorBuilder Current => Chain(AccentColorEnum.Current);


    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <returns>The result of the operation.</returns>
    public override AccentColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    /// <summary>
    /// Executes the utility operation.
    /// </summary>
    /// <param name="utility">The utility.</param>
    /// <returns>The result of the operation.</returns>
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

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (AccentColorRule rule in _rules)
        {
            string cls = rule.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
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
