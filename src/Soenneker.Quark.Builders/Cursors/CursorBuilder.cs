
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

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public CursorBuilder Auto => Chain(CursorEnum.Auto);
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public CursorBuilder Default => Chain(CursorEnum.Default);
    /// <summary>
    /// Gets or sets pointer.
    /// </summary>
    public CursorBuilder Pointer => Chain(CursorEnum.Pointer);
    /// <summary>
    /// Gets or sets wait.
    /// </summary>
    public CursorBuilder Wait => Chain(CursorEnum.Wait);
    /// <summary>
    /// Gets or sets text.
    /// </summary>
    public CursorBuilder Text => Chain(CursorEnum.Text);
    /// <summary>
    /// Gets or sets move.
    /// </summary>
    public CursorBuilder Move => Chain(CursorEnum.Move);
    /// <summary>
    /// Gets or sets help.
    /// </summary>
    public CursorBuilder Help => Chain(CursorEnum.Help);
    /// <summary>
    /// Gets or sets not allowed.
    /// </summary>
    public CursorBuilder NotAllowed => Chain(CursorEnum.NotAllowed);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public CursorBuilder None => Chain(CursorEnum.None);
    /// <summary>
    /// Gets or sets context menu.
    /// </summary>
    public CursorBuilder ContextMenu => Chain(CursorEnum.ContextMenu);
    /// <summary>
    /// Gets or sets progress.
    /// </summary>
    public CursorBuilder Progress => Chain(CursorEnum.Progress);
    /// <summary>
    /// Gets or sets cell.
    /// </summary>
    public CursorBuilder Cell => Chain(CursorEnum.Cell);
    /// <summary>
    /// Gets or sets crosshair.
    /// </summary>
    public CursorBuilder Crosshair => Chain(CursorEnum.Crosshair);
    /// <summary>
    /// Gets or sets vertical text.
    /// </summary>
    public CursorBuilder VerticalText => Chain(CursorEnum.VerticalText);
    /// <summary>
    /// Gets or sets alias.
    /// </summary>
    public CursorBuilder Alias => Chain(CursorEnum.Alias);
    /// <summary>
    /// Gets or sets copy.
    /// </summary>
    public CursorBuilder Copy => Chain(CursorEnum.Copy);
    /// <summary>
    /// Gets or sets no drop.
    /// </summary>
    public CursorBuilder NoDrop => Chain(CursorEnum.NoDrop);
    /// <summary>
    /// Gets or sets grab.
    /// </summary>
    public CursorBuilder Grab => Chain(CursorEnum.Grab);
    /// <summary>
    /// Gets or sets grabbing.
    /// </summary>
    public CursorBuilder Grabbing => Chain(CursorEnum.Grabbing);
    /// <summary>
    /// Gets or sets all scroll.
    /// </summary>
    public CursorBuilder AllScroll => Chain(CursorEnum.AllScroll);
    /// <summary>
    /// Gets or sets col resize.
    /// </summary>
    public CursorBuilder ColResize => Chain(CursorEnum.ColResize);
    /// <summary>
    /// Gets or sets row resize.
    /// </summary>
    public CursorBuilder RowResize => Chain(CursorEnum.RowResize);
    /// <summary>
    /// Gets or sets n resize.
    /// </summary>
    public CursorBuilder NResize => Chain(CursorEnum.NResize);
    /// <summary>
    /// Gets or sets e resize.
    /// </summary>
    public CursorBuilder EResize => Chain(CursorEnum.EResize);
    /// <summary>
    /// Gets or sets s resize.
    /// </summary>
    public CursorBuilder SResize => Chain(CursorEnum.SResize);
    /// <summary>
    /// Gets or sets w resize.
    /// </summary>
    public CursorBuilder WResize => Chain(CursorEnum.WResize);
    /// <summary>
    /// Gets or sets ne resize.
    /// </summary>
    public CursorBuilder NeResize => Chain(CursorEnum.NeResize);
    /// <summary>
    /// Gets or sets nw resize.
    /// </summary>
    public CursorBuilder NwResize => Chain(CursorEnum.NwResize);
    /// <summary>
    /// Gets or sets se resize.
    /// </summary>
    public CursorBuilder SeResize => Chain(CursorEnum.SeResize);
    /// <summary>
    /// Gets or sets sw resize.
    /// </summary>
    public CursorBuilder SwResize => Chain(CursorEnum.SwResize);
    /// <summary>
    /// Gets or sets ew resize.
    /// </summary>
    public CursorBuilder EwResize => Chain(CursorEnum.EwResize);
    /// <summary>
    /// Gets or sets ns resize.
    /// </summary>
    public CursorBuilder NsResize => Chain(CursorEnum.NsResize);
    /// <summary>
    /// Gets or sets nesw resize.
    /// </summary>
    public CursorBuilder NeswResize => Chain(CursorEnum.NeswResize);
    /// <summary>
    /// Gets or sets nwse resize.
    /// </summary>
    public CursorBuilder NwseResize => Chain(CursorEnum.NwseResize);
    /// <summary>
    /// Gets or sets zoom in.
    /// </summary>
    public CursorBuilder ZoomIn => Chain(CursorEnum.ZoomIn);
    /// <summary>
    /// Gets or sets zoom out.
    /// </summary>
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

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
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
