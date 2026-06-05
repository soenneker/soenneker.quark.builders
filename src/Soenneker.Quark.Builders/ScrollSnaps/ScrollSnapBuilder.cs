using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll snap type builder. Tailwind: snap-none, snap-x, snap-y, snap-both, snap-mandatory, snap-proximity.
/// </summary>
[TailwindPrefix("snap-", Responsive = true)]
public sealed class ScrollSnapBuilder : CssBuilderBase<ScrollSnapBuilder>
{
    private readonly List<ScrollSnapRule> _rules = new(4);

    internal ScrollSnapBuilder()
    {
    }

    internal ScrollSnapBuilder(ScrollSnapEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollSnapRule(value, breakpoint));
    }

    internal ScrollSnapBuilder(List<ScrollSnapRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public ScrollSnapBuilder None => Chain(ScrollSnapEnum.None);
    /// <summary>
    /// Gets or sets x.
    /// </summary>
    public ScrollSnapBuilder X => Chain(ScrollSnapEnum.X);
    /// <summary>
    /// Gets or sets y.
    /// </summary>
    public ScrollSnapBuilder Y => Chain(ScrollSnapEnum.Y);
    /// <summary>
    /// Gets or sets both.
    /// </summary>
    public ScrollSnapBuilder Both => Chain(ScrollSnapEnum.Both);
    /// <summary>
    /// Gets or sets mandatory.
    /// </summary>
    public ScrollSnapBuilder Mandatory => Chain(ScrollSnapEnum.Mandatory);
    /// <summary>
    /// Gets or sets proximity.
    /// </summary>
    public ScrollSnapBuilder Proximity => Chain(ScrollSnapEnum.Proximity);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollSnapBuilder Chain(ScrollSnapEnum value)
    {
        _rules.Add(new ScrollSnapRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        foreach (ScrollSnapRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0)
                continue;

            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);

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
