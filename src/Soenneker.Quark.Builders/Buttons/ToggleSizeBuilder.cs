using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Responsive builder for shadcn-style toggle size utility groups.
/// </summary>
[TailwindPrefix("", Responsive = true)]
public sealed class ToggleSizeBuilder : CssBuilderBase<ToggleSizeBuilder>
{
    private readonly List<ToggleSizeRule> _rules = new(4);

    internal ToggleSizeBuilder()
    {
    }

    internal ToggleSizeBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ToggleSizeRule(size, breakpoint));
    }

    internal ToggleSizeBuilder(List<ToggleSizeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public ToggleSizeBuilder Default => Chain("h-9 min-w-9 px-2");
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public ToggleSizeBuilder Sm => Chain("h-8 min-w-8 px-1.5");
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public ToggleSizeBuilder Lg => Chain("h-10 min-w-10 px-2.5");

    /// <summary>
    /// Adds an arbitrary toggle size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ToggleSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ToggleSizeBuilder Chain(string size)
    {
        _rules.Add(new ToggleSizeRule(size, null, ConsumePendingModifierChain()));
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
            ToggleSizeRule rule = _rules[i];
            string cls = rule.Size;

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

}
