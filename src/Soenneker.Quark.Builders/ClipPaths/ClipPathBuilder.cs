
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
    private readonly List<ClipPathRule> _rules = new(4);

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
    public ClipPathBuilder None => ChainWithPath(ClipPathEnum.None);
    /// <summary>
    /// Sets the clip path to circle.
    /// </summary>
    public ClipPathBuilder Circle => ChainWithPath(ClipPathEnum.Circle);
    /// <summary>
    /// Sets the clip path to ellipse.
    /// </summary>
    public ClipPathBuilder Ellipse => ChainWithPath(ClipPathEnum.Ellipse);
    /// <summary>
    /// Sets the clip path to inset.
    /// </summary>
    public ClipPathBuilder Inset => ChainWithPath(ClipPathEnum.Inset);
    /// <summary>
    /// Sets the clip path to polygon.
    /// </summary>
    public ClipPathBuilder Polygon => ChainWithPath(ClipPathEnum.Polygon);

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

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            ClipPathRule rule = _rules[i];
            string cls = rule.Path;
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
