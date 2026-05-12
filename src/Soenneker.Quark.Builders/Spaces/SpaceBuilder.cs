using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("space-", Responsive = true)]
public sealed class SpaceBuilder : CssBuilderBase<SpaceBuilder>
{
    private readonly List<SpaceRule> _rules = new(6);

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
    public SpaceBuilder Token(string value)
    {
        string prefix = _rules.Count > 0 && _rules[^1].Value.StartsWith("space-y", System.StringComparison.Ordinal) ? "space-y-" : "space-x-";
        return ChainClass(prefix + value);
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

        using var sb = new PooledStringBuilder();

        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            SpaceRule rule = _rules[i];
            string cls = rule.Value;
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

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
