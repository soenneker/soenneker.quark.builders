using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("text-", Responsive = true)]
public sealed class TextColorBuilder : CssBuilderBase<TextColorBuilder>
{
    private const string Prefix = "text-";

    private readonly List<TextColorRule> _rules = new(4);

    internal TextColorBuilder()
    {
    }

    internal TextColorBuilder(TextColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextColorRule(value.Value, breakpoint));
    }

    internal TextColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new TextColorRule(value, breakpoint));
    }

    internal TextColorBuilder(List<TextColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public TextColorBuilder Primary => ChainValue(TextColorEnum.Primary);
    public TextColorBuilder PrimaryForeground => ChainValue(TextColorEnum.PrimaryForeground);
    public TextColorBuilder Secondary => ChainValue(TextColorEnum.Secondary);
    public TextColorBuilder SecondaryForeground => ChainValue(TextColorEnum.SecondaryForeground);
    public TextColorBuilder Destructive => ChainValue(TextColorEnum.Destructive);
    public TextColorBuilder DestructiveForeground => ChainValue(TextColorEnum.DestructiveForeground);
    public TextColorBuilder MutedForeground => ChainValue(TextColorEnum.MutedForeground);
    public TextColorBuilder Accent => ChainValue(TextColorEnum.Accent);
    public TextColorBuilder AccentForeground => ChainValue(TextColorEnum.AccentForeground);
    public TextColorBuilder PopoverForeground => ChainValue(TextColorEnum.PopoverForeground);
    public TextColorBuilder CardForeground => ChainValue(TextColorEnum.CardForeground);
    public TextColorBuilder Foreground => ChainValue(TextColorEnum.Foreground);
    public TextColorBuilder White => ChainValue(TextColorEnum.White);
    public TextColorBuilder Black => ChainValue(TextColorEnum.Black);

    public TextColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    public TextColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextColorBuilder ChainValue(TextColorEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new TextColorRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextColorBuilder ChainClass(string value)
    {
        BreakpointType? bp = null;
        if (value.Length != 0)
            _rules.Add(new TextColorRule(value, bp, ConsumePendingModifierChain()));
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
            TextColorRule rule = _rules[i];
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
