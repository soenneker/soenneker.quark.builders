
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified clip path builder with fluent API for chaining clip path rules.
/// </summary>
[TailwindPrefix("clip-", Responsive = true)]
public sealed class ClipPathBuilder : CssBuilderBase<ClipPathBuilder>
{
    private RuleList<ClipPathRule> _rules;

    internal ClipPathBuilder()
    {
    }

    internal ClipPathBuilder(string path, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ClipPathRule(path, breakpoint));
    }

    internal ClipPathBuilder(ClipPathEnum path, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ClipPathRule(path.Value, breakpoint));
    }

    internal ClipPathBuilder(List<ClipPathRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the clip path to none.
    /// </summary>
    public ClipPathBuilder None => ChainWithPath(ClipPathEnum.NoneValue);
    /// <summary>
    /// Sets the clip path to circle.
    /// </summary>
    public ClipPathBuilder Circle => ChainWithPath(ClipPathEnum.CircleValue);
    /// <summary>
    /// Sets the clip path to ellipse.
    /// </summary>
    public ClipPathBuilder Ellipse => ChainWithPath(ClipPathEnum.EllipseValue);
    /// <summary>
    /// Sets the clip path to inset.
    /// </summary>
    public ClipPathBuilder Inset => ChainWithPath(ClipPathEnum.InsetValue);
    /// <summary>
    /// Sets the clip path to polygon.
    /// </summary>
    public ClipPathBuilder Polygon => ChainWithPath(ClipPathEnum.PolygonValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ClipPathBuilder ChainWithPath(string path)
    {
        _rules.Add(new ClipPathRule(path, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ClipPathBuilder ChainWithPath(ClipPathEnum path)
    {
        _rules.Add(new ClipPathRule(path.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ClipPathRule rule = _rules[0];
            return ClassWriter.Render(rule.Path, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ClipPathRule rule = _rules[i];
                writer.Add(rule.Path, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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
    /// Returns the CSS class string representation of this clip path builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
