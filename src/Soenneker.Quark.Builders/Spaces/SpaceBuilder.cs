using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the space builder.
/// </summary>
[TailwindPrefix("space-", Responsive = true)]
public sealed class SpaceBuilder : CssBuilderBase<SpaceBuilder>
{
    private RuleList<SpaceRule> _rules;

    internal SpaceBuilder()
    {
    }

    internal SpaceBuilder(SpaceEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new SpaceRule(value.Value, breakpoint));
    }

    internal SpaceBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new SpaceRule(value, breakpoint));
    }

    /// <summary>
    /// Fluent step for `XReverse` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public SpaceBuilder XReverse => Chain(SpaceEnum.XReverse);

    /// <summary>
    /// Fluent step for `YReverse` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public SpaceBuilder YReverse => Chain(SpaceEnum.YReverse);

    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public SpaceBuilder Token(string value)
    {
        bool preferY = _rules.Count > 0 && _rules[^1].Value.StartsWith("space-y", System.StringComparison.Ordinal);
        return ChainClass(Space.NormalizeToken(value, preferY));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SpaceBuilder Chain(SpaceEnum value)
    {
        _rules.Add(new SpaceRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SpaceBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new SpaceRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            SpaceRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                SpaceRule rule = _rules[i];
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
