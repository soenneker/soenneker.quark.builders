
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// Simplified visibility builder with fluent API for chaining visibility rules.
/// </summary>
[TailwindPrefix("visible", Responsive = true)]
public sealed class VisibilityBuilder : CssBuilderBase<VisibilityBuilder>
{
    private readonly List<VisibilityRule> _rules = new(4);

    internal VisibilityBuilder()
    {
    }

    internal VisibilityBuilder(VisibilityEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new VisibilityRule(value, breakpoint));
    }

    internal VisibilityBuilder(List<VisibilityRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

	/// <summary>
	/// Sets the visibility to visible.
	/// </summary>
    public VisibilityBuilder Visible => Chain(VisibilityEnum.Visible);
	/// <summary>
	/// Sets the visibility to invisible.
	/// </summary>
    public VisibilityBuilder Invisible => Chain(VisibilityEnum.Invisible);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private VisibilityBuilder Chain(VisibilityEnum value)
    {
        _rules.Add(new VisibilityRule(value, null, ConsumePendingModifierChain()));
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
            VisibilityRule rule = _rules[i];
            string cls;
            if (ReferenceEquals(rule.Value, VisibilityEnum.Visible))
                cls = VisibilityEnum.VisibleValue;
            else if (ReferenceEquals(rule.Value, VisibilityEnum.Invisible))
                cls = VisibilityEnum.InvisibleValue;
            else
                cls = string.Empty;
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
