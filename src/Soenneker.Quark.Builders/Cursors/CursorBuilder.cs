
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned cursor builder.
/// </summary>
[TailwindPrefix("cursor-", Responsive = true)]
public sealed class CursorBuilder : CssBuilderBase<CursorBuilder>
{
    private const string Prefix = "cursor-";
    private readonly List<CursorRule> _rules = new(4);

    internal CursorBuilder()
    {
    }

    internal CursorBuilder(CursorEnum cursor, BreakpointType? breakpoint = null)
    {
        _rules.Add(new CursorRule(cursor.Value, breakpoint));
    }

    internal CursorBuilder(string cursor, BreakpointType? breakpoint = null)
    {
        _rules.Add(new CursorRule(cursor, breakpoint));
    }

    internal CursorBuilder(List<CursorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public CursorBuilder Auto => Chain(CursorEnum.Auto);
    public CursorBuilder Default => Chain(CursorEnum.Default);
    public CursorBuilder Pointer => Chain(CursorEnum.Pointer);
    public CursorBuilder Wait => Chain(CursorEnum.Wait);
    public CursorBuilder Text => Chain(CursorEnum.Text);
    public CursorBuilder Move => Chain(CursorEnum.Move);
    public CursorBuilder Help => Chain(CursorEnum.Help);
    public CursorBuilder NotAllowed => Chain(CursorEnum.NotAllowed);
    public CursorBuilder None => Chain(CursorEnum.None);
    public CursorBuilder ContextMenu => Chain(CursorEnum.ContextMenu);
    public CursorBuilder Progress => Chain(CursorEnum.Progress);
    public CursorBuilder Cell => Chain(CursorEnum.Cell);
    public CursorBuilder Crosshair => Chain(CursorEnum.Crosshair);
    public CursorBuilder VerticalText => Chain(CursorEnum.VerticalText);
    public CursorBuilder Alias => Chain(CursorEnum.Alias);
    public CursorBuilder Copy => Chain(CursorEnum.Copy);
    public CursorBuilder NoDrop => Chain(CursorEnum.NoDrop);
    public CursorBuilder Grab => Chain(CursorEnum.Grab);
    public CursorBuilder Grabbing => Chain(CursorEnum.Grabbing);
    public CursorBuilder AllScroll => Chain(CursorEnum.AllScroll);
    public CursorBuilder ColResize => Chain(CursorEnum.ColResize);
    public CursorBuilder RowResize => Chain(CursorEnum.RowResize);
    public CursorBuilder NResize => Chain(CursorEnum.NResize);
    public CursorBuilder EResize => Chain(CursorEnum.EResize);
    public CursorBuilder SResize => Chain(CursorEnum.SResize);
    public CursorBuilder WResize => Chain(CursorEnum.WResize);
    public CursorBuilder NeResize => Chain(CursorEnum.NeResize);
    public CursorBuilder NwResize => Chain(CursorEnum.NwResize);
    public CursorBuilder SeResize => Chain(CursorEnum.SeResize);
    public CursorBuilder SwResize => Chain(CursorEnum.SwResize);
    public CursorBuilder EwResize => Chain(CursorEnum.EwResize);
    public CursorBuilder NsResize => Chain(CursorEnum.NsResize);
    public CursorBuilder NeswResize => Chain(CursorEnum.NeswResize);
    public CursorBuilder NwseResize => Chain(CursorEnum.NwseResize);
    public CursorBuilder ZoomIn => Chain(CursorEnum.ZoomIn);
    public CursorBuilder ZoomOut => Chain(CursorEnum.ZoomOut);

    /// <summary>
    /// Applies an exact Tailwind cursor utility token suffix, including arbitrary values.
    /// </summary>
    public CursorBuilder Token(string token) => Chain(Prefix + token);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private CursorBuilder Chain(CursorEnum cursor)
    {
        return Chain(cursor.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private CursorBuilder Chain(string cursor)
    {
        _rules.Add(new CursorRule(cursor, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            CursorRule rule = _rules[i];
            string cls = rule.Cursor;
            string? modifierChain = rule.ModifierChain ?? (i == _rules.Count - 1 ? PendingModifierChain : null);
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (modifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, modifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS style string representation of this cursor builder.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
