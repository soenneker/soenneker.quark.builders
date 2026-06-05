using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the background color builder.
/// </summary>
[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundColorBuilder : ColorBuilderBase<BackgroundColorBuilder>
{
    private const string Prefix = "bg-";

    private readonly List<BackgroundColorRule> _rules = new(4);

    internal BackgroundColorBuilder()
    {
    }

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

    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public BackgroundColorBuilder Primary => ChainValue(BackgroundColorEnum.Primary);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public BackgroundColorBuilder Secondary => ChainValue(BackgroundColorEnum.Secondary);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public BackgroundColorBuilder Destructive => ChainValue(BackgroundColorEnum.Destructive);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public BackgroundColorBuilder Muted => ChainValue(BackgroundColorEnum.Muted);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public BackgroundColorBuilder Accent => ChainValue(BackgroundColorEnum.Accent);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public BackgroundColorBuilder Popover => ChainValue(BackgroundColorEnum.Popover);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public BackgroundColorBuilder Card => ChainValue(BackgroundColorEnum.Card);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public BackgroundColorBuilder Background => ChainValue(BackgroundColorEnum.Background);
    /// <summary>
    /// Gets or sets foreground.
    /// </summary>
    public BackgroundColorBuilder Foreground => ChainValue(BackgroundColorEnum.Foreground);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public BackgroundColorBuilder Border => ChainValue(BackgroundColorEnum.Border);

    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public BackgroundColorBuilder White => ChainValue(BackgroundColorEnum.White);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public BackgroundColorBuilder Black => ChainValue(BackgroundColorEnum.Black);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public BackgroundColorBuilder Transparent => ChainValue(BackgroundColorEnum.Transparent);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <returns>The result of the operation.</returns>
    public override BackgroundColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    /// <summary>
    /// Executes the utility operation.
    /// </summary>
    /// <param name="utility">The utility.</param>
    /// <returns>The result of the operation.</returns>
    public BackgroundColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackgroundColorBuilder ChainValue(BackgroundColorEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new BackgroundColorRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackgroundColorBuilder ChainClass(string value)
    {
        BreakpointType? bp = null;
        if (value.Length != 0)
            _rules.Add(new BackgroundColorRule(value, bp, ConsumePendingModifierChain()));
        return this;
    }


    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
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

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
