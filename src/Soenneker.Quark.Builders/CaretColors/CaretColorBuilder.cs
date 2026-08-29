using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Caret color builder for text inputs. Tailwind: caret-primary, caret-transparent, caret-*.
/// </summary>
[TailwindPrefix("caret-", Responsive = true)]
public sealed class CaretColorBuilder : ColorBuilderBase<CaretColorBuilder>
{
    private const string Prefix = "caret-";

    private readonly List<CaretColorRule> _rules = new(4);

    internal CaretColorBuilder()
    {
    }

    internal CaretColorBuilder(CaretColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new CaretColorRule(value.Value, breakpoint));
    }

    internal CaretColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new CaretColorRule(value, breakpoint));
    }

    internal CaretColorBuilder(List<CaretColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `Primary` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public CaretColorBuilder Primary => Chain(CaretColorEnum.Primary);
    /// <summary>
    /// Fully transparent color (`transparent`).
    /// </summary>
    public CaretColorBuilder Transparent => Chain(CaretColorEnum.Transparent);
    /// <summary>
    /// `currentColor` — uses the element’s computed `color` (common for icons and rings).
    /// </summary>
    public CaretColorBuilder Current => Chain(CaretColorEnum.Current);


    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <returns>The result of the operation.</returns>
    public override CaretColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    /// <summary>
    /// Adds the utility Caret Color utility to the class list.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public CaretColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private CaretColorBuilder Chain(CaretColorEnum value)
    {
        _rules.Add(new CaretColorRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private CaretColorBuilder ChainClass(string value)
    {
        BreakpointType? breakpoint = null;
        if (value.Length != 0)
            _rules.Add(new CaretColorRule(value, breakpoint, ConsumePendingModifierChain()));
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
        foreach (CaretColorRule rule in _rules)
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
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
