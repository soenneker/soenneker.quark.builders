
using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn line clamp builder for multiline truncation utilities.
/// </summary>
[TailwindPrefix("line-clamp-", Responsive = true)]
public sealed class LineClampBuilder : CssBuilderBase<LineClampBuilder>
{
    private readonly List<LineClampRule> _rules = new(4);

    internal LineClampBuilder()
    {
    }

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

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public LineClampBuilder None => Chain(LineClampEnum.None);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public LineClampBuilder Is1 => Chain(LineClampEnum.Is1);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public LineClampBuilder Is2 => Chain(LineClampEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public LineClampBuilder Is3 => Chain(LineClampEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public LineClampBuilder Is4 => Chain(LineClampEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public LineClampBuilder Is5 => Chain(LineClampEnum.Is5);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public LineClampBuilder Is6 => Chain(LineClampEnum.Is6);
    /// <summary>
    /// Adds an arbitrary line clamp utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public LineClampBuilder Token(string value) => Chain(NormalizeLineClampClass(value));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LineClampBuilder Chain(string value)
    {
        _rules.Add(new LineClampRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LineClampBuilder Chain(LineClampEnum value)
    {
        _rules.Add(new LineClampRule(value.Value, null, ConsumePendingModifierChain()));
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
            string cls = _rules[i].Value;
            if (cls.Length == 0)
                continue;

            LineClampRule rule = _rules[i];

            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);

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

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();

    private static string NormalizeLineClampClass(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return string.Empty;

        return value.StartsWith("line-clamp-") ? value : "line-clamp-" + value;
    }
}
