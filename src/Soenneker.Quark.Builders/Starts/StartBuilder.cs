using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Start (inset-inline-start) builder. Tailwind: start-*.
/// </summary>
[TailwindPrefix("start-", Responsive = true)]
public sealed class StartBuilder : ICssBuilder
{
    private readonly List<StartRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal StartBuilder(StartEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new StartRule(value, breakpoint));
    }

    internal StartBuilder(List<StartRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public StartBuilder Is0 => Chain(StartEnum.Is0);
    public StartBuilder Is1 => Chain(StartEnum.Is1);
    public StartBuilder Is2 => Chain(StartEnum.Is2);
    public StartBuilder Is3 => Chain(StartEnum.Is3);
    public StartBuilder Is4 => Chain(StartEnum.Is4);
    public StartBuilder Is5 => Chain(StartEnum.Is5);
    public StartBuilder Auto => Chain(StartEnum.Auto);
    public StartBuilder Px => Chain(StartEnum.Px);

    public StartBuilder OnBase => ChainBp(BreakpointType.Base);
    public StartBuilder OnSm => ChainBp(BreakpointType.Sm);
    public StartBuilder OnMd => ChainBp(BreakpointType.Md);
    public StartBuilder OnLg => ChainBp(BreakpointType.Lg);
    public StartBuilder OnXl => ChainBp(BreakpointType.Xl);
    public StartBuilder On2xl => ChainBp(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StartBuilder Chain(StartEnum value)
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new StartRule(value, breakpoint));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StartBuilder ChainBp(BreakpointType bp)
    {
        _pendingBreakpoint = bp;
        return this;
    }

    public string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (StartRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
