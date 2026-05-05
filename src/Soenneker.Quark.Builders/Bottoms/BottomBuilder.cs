using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Bottom offset builder. Tailwind: bottom-*.
/// </summary>
[TailwindPrefix("bottom-", Responsive = true)]
public sealed class BottomBuilder : CssBuilderBase
{
    private readonly List<BottomRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal BottomBuilder(BottomEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BottomRule(value.Value, breakpoint));
    }

    internal BottomBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BottomRule(value, breakpoint));
    }

    internal BottomBuilder(List<BottomRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public BottomBuilder Is0 => Chain(BottomEnum.Is0);
    public BottomBuilder Is1 => Chain(BottomEnum.Is1);
    public BottomBuilder Is2 => Chain(BottomEnum.Is2);
    public BottomBuilder Is3 => Chain(BottomEnum.Is3);
    public BottomBuilder Is4 => Chain(BottomEnum.Is4);
    public BottomBuilder Is5 => Chain(BottomEnum.Is5);
    public BottomBuilder Is8 => Chain(BottomEnum.Is8);
    public BottomBuilder Is12 => Chain(BottomEnum.Is12);
    public BottomBuilder Is16 => Chain(BottomEnum.Is16);
    public BottomBuilder Is24 => Chain(BottomEnum.Is24);
    public BottomBuilder Auto => Chain(BottomEnum.Auto);
    public BottomBuilder Px => Chain(BottomEnum.Px);
    public BottomBuilder Token(string value) => Chain(value.StartsWith("bottom-") ? value : "bottom-" + value);

    public BottomBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public BottomBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public BottomBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public BottomBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public BottomBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public BottomBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BottomBuilder Chain(BottomEnum value)
    {
        _rules.Add(new BottomRule(value.Value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BottomBuilder Chain(string value)
    {
        _rules.Add(new BottomRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BottomBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (BottomRule rule in _rules)
        {
            string cls = rule.Value;
            if (cls.Length == 0) continue;
            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
