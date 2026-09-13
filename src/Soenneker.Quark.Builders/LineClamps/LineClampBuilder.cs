
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
    private RuleList<LineClampRule> _rules;

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
    public LineClampBuilder None => Chain(LineClampEnum.NoneValue);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public LineClampBuilder Is1 => Chain(LineClampEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public LineClampBuilder Is2 => Chain(LineClampEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public LineClampBuilder Is3 => Chain(LineClampEnum.Is3Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public LineClampBuilder Is4 => Chain(LineClampEnum.Is4Value);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public LineClampBuilder Is5 => Chain(LineClampEnum.Is5Value);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public LineClampBuilder Is6 => Chain(LineClampEnum.Is6Value);
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

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            LineClampRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                LineClampRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
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
