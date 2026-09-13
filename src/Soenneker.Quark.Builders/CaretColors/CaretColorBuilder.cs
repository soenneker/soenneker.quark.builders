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

    private RuleList<CaretColorRule> _rules;

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



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            CaretColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                CaretColorRule rule = _rules[i];
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
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
