
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
    private RuleList<VisibilityRule> _rules;

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
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            VisibilityRule rule = _rules[0];
            return ClassWriter.Render(ReferenceEquals(rule.Value, VisibilityEnum.Visible) ? VisibilityEnum.VisibleValue : ReferenceEquals(rule.Value, VisibilityEnum.Invisible) ? VisibilityEnum.InvisibleValue : string.Empty, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                VisibilityRule rule = _rules[i];
                writer.Add(ReferenceEquals(rule.Value, VisibilityEnum.Visible) ? VisibilityEnum.VisibleValue : ReferenceEquals(rule.Value, VisibilityEnum.Invisible) ? VisibilityEnum.InvisibleValue : string.Empty, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
