
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundColorBuilder : CssBuilderBase
{
    private static readonly HashSet<string> SemanticTokens = new(System.StringComparer.Ordinal)
    {
        "primary",
        "secondary",
        "destructive",
        "muted",
        "accent",
        "popover",
        "card",
        "background",
        "white",
        "black",
        "transparent"
    };

    private const string Prefix = "bg-";

    private readonly List<BackgroundColorRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal BackgroundColorBuilder(BackgroundColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BackgroundColorRule(value.Value, breakpoint));
    }

    internal BackgroundColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new BackgroundColorRule(value, breakpoint));
    }

    internal BackgroundColorBuilder(List<BackgroundColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public BackgroundColorBuilder Primary => ChainValue(BackgroundColorEnum.Primary);
    public BackgroundColorBuilder Secondary => ChainValue(BackgroundColorEnum.Secondary);
    public BackgroundColorBuilder Destructive => ChainValue(BackgroundColorEnum.Destructive);
    public BackgroundColorBuilder Muted => ChainValue(BackgroundColorEnum.Muted);
    public BackgroundColorBuilder Accent => ChainValue(BackgroundColorEnum.Accent);
    public BackgroundColorBuilder Popover => ChainValue(BackgroundColorEnum.Popover);
    public BackgroundColorBuilder Card => ChainValue(BackgroundColorEnum.Card);
    public BackgroundColorBuilder Background => ChainValue(BackgroundColorEnum.Background);

    public BackgroundColorBuilder White => ChainValue(BackgroundColorEnum.White);
    public BackgroundColorBuilder Black => ChainValue(BackgroundColorEnum.Black);
    public BackgroundColorBuilder Transparent => ChainValue(BackgroundColorEnum.Transparent);

    public BackgroundColorBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public BackgroundColorBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public BackgroundColorBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public BackgroundColorBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public BackgroundColorBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public BackgroundColorBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    public BackgroundColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token, SemanticTokens));

    public BackgroundColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackgroundColorBuilder ChainValue(BackgroundColorEnum value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new BackgroundColorRule(value.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackgroundColorBuilder ChainClass(string value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        if (value.Length != 0)
            _rules.Add(new BackgroundColorRule(value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackgroundColorBuilder SetPendingBreakpoint(BreakpointType bp)
    {
        _pendingBreakpoint = bp;
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            BackgroundColorRule rule = _rules[i];
            string cls = rule.Value;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
