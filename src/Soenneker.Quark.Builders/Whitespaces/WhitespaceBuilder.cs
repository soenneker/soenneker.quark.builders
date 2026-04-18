
using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind whitespace utility builder.
/// </summary>
[TailwindPrefix("whitespace-", Responsive = true)]
public sealed class WhitespaceBuilder : ICssBuilder
{
    private readonly List<WhitespaceRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal WhitespaceBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new WhitespaceRule(value, breakpoint));
    }

    internal WhitespaceBuilder(WhitespaceEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new WhitespaceRule(value.Value, breakpoint));
    }

    internal WhitespaceBuilder(List<WhitespaceRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the whitespace to normal.
    /// </summary>
    public WhitespaceBuilder Normal => Chain(WhitespaceEnum.Normal);

    /// <summary>
    /// Sets the whitespace to nowrap.
    /// </summary>
    public WhitespaceBuilder Nowrap => Chain(WhitespaceEnum.Nowrap);

    /// <summary>
    /// Sets the whitespace to pre.
    /// </summary>
    public WhitespaceBuilder Pre => Chain(WhitespaceEnum.Pre);

    /// <summary>
    /// Sets the whitespace to pre-line.
    /// </summary>
    public WhitespaceBuilder PreLine => Chain(WhitespaceEnum.PreLine);

    /// <summary>
    /// Sets the whitespace to pre-wrap.
    /// </summary>
    public WhitespaceBuilder PreWrap => Chain(WhitespaceEnum.PreWrap);

    /// <summary>
    /// Sets the whitespace to break-spaces.
    /// </summary>
    public WhitespaceBuilder BreakSpaces => Chain(WhitespaceEnum.BreakSpaces);

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint. In Tailwind’s mobile‑first model, unprefixed utilities apply from 0px unless a larger breakpoint overrides them.
    /// </summary>
    public WhitespaceBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public WhitespaceBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public WhitespaceBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public WhitespaceBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public WhitespaceBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public WhitespaceBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private WhitespaceBuilder Chain(string value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new WhitespaceRule(value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private WhitespaceBuilder Chain(WhitespaceEnum value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new WhitespaceRule(value.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private WhitespaceBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            WhitespaceRule rule = _rules[i];
            string cls = rule.Value;

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public string ToStyle() => string.Empty;
}
