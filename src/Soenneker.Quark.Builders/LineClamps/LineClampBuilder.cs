
using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn line clamp builder for multiline truncation utilities.
/// </summary>
[TailwindPrefix("line-clamp-", Responsive = true)]
public sealed class LineClampBuilder : CssBuilderBase
{
    private readonly List<LineClampRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal LineClampBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LineClampRule(value, breakpoint));
    }

    internal LineClampBuilder(LineClampEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LineClampRule(value.Value, breakpoint));
    }

    internal LineClampBuilder(List<LineClampRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public LineClampBuilder None => Chain(LineClampEnum.None);
    public LineClampBuilder Is1 => Chain(LineClampEnum.Is1);
    public LineClampBuilder Is2 => Chain(LineClampEnum.Is2);
    public LineClampBuilder Is3 => Chain(LineClampEnum.Is3);
    public LineClampBuilder Is4 => Chain(LineClampEnum.Is4);
    public LineClampBuilder Is5 => Chain(LineClampEnum.Is5);
    public LineClampBuilder Is6 => Chain(LineClampEnum.Is6);
    public LineClampBuilder Token(string value) => Chain(NormalizeLineClampClass(value));

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
    private LineClampBuilder Chain(LineClampEnum value)
    {
        _rules.Add(new LineClampRule(value.Value, ConsumePendingBreakpoint()));
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
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            string cls = _rules[i].Value;
            if (cls.Length == 0)
                continue;

            string breakpoint = BreakpointUtil.GetBreakpointToken(_rules[i].Breakpoint);
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

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();

    private static string NormalizeLineClampClass(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return string.Empty;

        return value.StartsWith("line-clamp-") ? value : "line-clamp-" + value;
    }
}
