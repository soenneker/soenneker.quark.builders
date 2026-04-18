
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind text break utility builder.
/// </summary>
[TailwindPrefix("break-", Responsive = true)]
public sealed class TextBreakBuilder : ICssBuilder
{
    private readonly List<TextBreakRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal TextBreakBuilder(TextBreakEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextBreakRule(value.Value, breakpoint));
    }

    internal TextBreakBuilder(List<TextBreakRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets normal line breaking.
    /// </summary>
    public TextBreakBuilder Normal => Chain(TextBreakEnum.Normal);
    /// <summary>
    /// Breaks words when needed.
    /// </summary>
    public TextBreakBuilder Words => Chain(TextBreakEnum.Words);
    /// <summary>
    /// Breaks at any character.
    /// </summary>
    public TextBreakBuilder All => Chain(TextBreakEnum.All);
    /// <summary>
    /// Prevents breaks in CJK text.
    /// </summary>
    public TextBreakBuilder Keep => Chain(TextBreakEnum.Keep);

    /// <summary>
    /// Applies the text break on phone breakpoint.
    /// </summary>
    public TextBreakBuilder OnBase => ChainBp(BreakpointType.Base);
    /// <summary>
    /// Applies the text break on small breakpoint (≥640px).
    /// </summary>
    public TextBreakBuilder OnSm => ChainBp(BreakpointType.Sm);
    /// <summary>
    /// Applies the text break on tablet breakpoint.
    /// </summary>
    public TextBreakBuilder OnMd => ChainBp(BreakpointType.Md);
    /// <summary>
    /// Applies the text break on laptop breakpoint.
    /// </summary>
    public TextBreakBuilder OnLg => ChainBp(BreakpointType.Lg);
    /// <summary>
    /// Applies the text break on desktop breakpoint.
    /// </summary>
    public TextBreakBuilder OnXl => ChainBp(BreakpointType.Xl);
    /// <summary>
    /// Applies the text break on the 2xl breakpoint.
    /// </summary>
    public TextBreakBuilder On2xl => ChainBp(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextBreakBuilder Chain(TextBreakEnum value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new TextBreakRule(value.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextBreakBuilder ChainBp(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            TextBreakRule rule = _rules[i];
            string baseClass = rule.Value;
            if (baseClass.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                baseClass = BreakpointUtil.ApplyTailwindBreakpoint(baseClass, bp);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(baseClass);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public string ToStyle()
    {
        return string.Empty;
    }

    public override string ToString() => ToClass();
}
