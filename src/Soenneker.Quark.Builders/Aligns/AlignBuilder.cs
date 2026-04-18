using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

public sealed class AlignBuilder : ICssBuilder
{
    private readonly List<(string Value, BreakpointType? Breakpoint)> _rules = [];
    private BreakpointType? _pendingBreakpoint;

    public AlignBuilder ItemsStart => Chain("items-start");
    public AlignBuilder ItemsEnd => Chain("items-end");
    public AlignBuilder ItemsCenter => Chain("items-center");
    public AlignBuilder ItemsBaseline => Chain("items-baseline");
    public AlignBuilder ItemsStretch => Chain("items-stretch");
    public AlignBuilder JustifyStart => Chain("justify-start");
    public AlignBuilder JustifyEnd => Chain("justify-end");
    public AlignBuilder JustifyCenter => Chain("justify-center");
    public AlignBuilder JustifyBetween => Chain("justify-between");
    public AlignBuilder JustifyAround => Chain("justify-around");
    public AlignBuilder JustifyEvenly => Chain("justify-evenly");
    public AlignBuilder SelfStart => Chain("self-start");
    public AlignBuilder SelfEnd => Chain("self-end");
    public AlignBuilder SelfCenter => Chain("self-center");
    public AlignBuilder SelfStretch => Chain("self-stretch");
    public AlignBuilder Token(string value) => Chain(value);

    public AlignBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public AlignBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public AlignBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public AlignBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public AlignBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public AlignBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AlignBuilder Chain(string value)
    {
        if (value.Length > 0)
            _rules.Add((value, ConsumePendingBreakpoint()));

        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AlignBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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

    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();

        for (var i = 0; i < _rules.Count; i++)
        {
            (string value, BreakpointType? breakpoint) = _rules[i];
            string css = value;
            string bp = BreakpointUtil.GetBreakpointToken(breakpoint);

            if (bp.Length != 0)
                css = BreakpointUtil.ApplyTailwindBreakpoint(css, bp);

            if (sb.Length > 0)
                sb.Append(' ');

            sb.Append(css);
        }

        return sb.ToString();
    }

    public string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
