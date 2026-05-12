using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("border-", Responsive = true)]
public sealed class BorderColorBuilder : CssBuilderBase<BorderColorBuilder>
{
    private const string Prefix = "border-";

    private readonly List<BorderColorRule> _rules = new(4);

    internal BorderColorBuilder()
    {
    }

    internal BorderColorBuilder(BorderColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BorderColorRule(value.Value, breakpoint));
    }

    internal BorderColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new BorderColorRule(value, breakpoint));
    }

    internal BorderColorBuilder(List<BorderColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public BorderColorBuilder Primary => ChainValue(BorderColorEnum.Primary);
    public BorderColorBuilder Secondary => ChainValue(BorderColorEnum.Secondary);
    public BorderColorBuilder Destructive => ChainValue(BorderColorEnum.Destructive);
    public BorderColorBuilder Muted => ChainValue(BorderColorEnum.Muted);
    public BorderColorBuilder Accent => ChainValue(BorderColorEnum.Accent);
    public BorderColorBuilder Popover => ChainValue(BorderColorEnum.Popover);
    public BorderColorBuilder Card => ChainValue(BorderColorEnum.Card);
    public BorderColorBuilder Background => ChainValue(BorderColorEnum.Background);
    public BorderColorBuilder Border => ChainValue(BorderColorEnum.Border);
    public BorderColorBuilder Input => ChainValue(BorderColorEnum.Input);
    public BorderColorBuilder Ring => ChainValue(BorderColorEnum.Ring);

    public BorderColorBuilder White => ChainValue(BorderColorEnum.White);
    public BorderColorBuilder Black => ChainValue(BorderColorEnum.Black);
    public BorderColorBuilder Transparent => ChainValue(BorderColorEnum.Transparent);


    public BorderColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    public BorderColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderColorBuilder ChainValue(BorderColorEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new BorderColorRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderColorBuilder ChainClass(string value)
    {
        BreakpointType? bp = null;
        if (value.Length != 0)
            _rules.Add(new BorderColorRule(value, bp, ConsumePendingModifierChain()));
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
            BorderColorRule rule = _rules[i];
            string cls = rule.Value;
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

    public override string ToString() => ToClass();
}
