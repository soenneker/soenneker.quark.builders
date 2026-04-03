using Soenneker.Quark.Attributes;
using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn line clamp builder for multiline truncation utilities.
/// </summary>
[TailwindPrefix("line-clamp-", Responsive = true)]
public sealed class LineClampBuilder : ICssBuilder
{
    private readonly List<LineClampRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal LineClampBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LineClampRule(value, breakpoint));
    }

    internal LineClampBuilder(List<LineClampRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public LineClampBuilder None => Chain("none");
    public LineClampBuilder One => Chain("1");
    public LineClampBuilder Two => Chain("2");
    public LineClampBuilder Three => Chain("3");
    public LineClampBuilder Four => Chain("4");
    public LineClampBuilder Five => Chain("5");
    public LineClampBuilder Six => Chain("6");

    public LineClampBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public LineClampBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public LineClampBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public LineClampBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public LineClampBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public LineClampBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LineClampBuilder Chain(string value)
    {
        _rules.Add(new LineClampRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LineClampBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        var breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            var cls = GetClass(_rules[i].Value);
            if (cls.Length == 0)
                continue;

            var breakpoint = BreakpointUtil.GetBreakpointToken(_rules[i].Breakpoint);
            if (breakpoint.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public string ToStyle()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            var value = GetStyle(_rules[i].Value);
            if (value.Length == 0)
                continue;

            if (!first)
                sb.Append("; ");
            else
                first = false;

            sb.Append(value);
        }

        return sb.ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string GetClass(string value)
    {
        return value switch
        {
            "none" => "line-clamp-none",
            "1" or "2" or "3" or "4" or "5" or "6" => $"line-clamp-{value}",
            _ => string.Empty
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string GetStyle(string value)
    {
        return value switch
        {
            "none" => "overflow: visible; display: block; -webkit-box-orient: horizontal; -webkit-line-clamp: unset",
            "1" or "2" or "3" or "4" or "5" or "6" =>
                $"overflow: hidden; display: -webkit-box; -webkit-box-orient: vertical; -webkit-line-clamp: {value}",
            _ => string.Empty
        };
    }

    public override string ToString() => ToClass();
}
