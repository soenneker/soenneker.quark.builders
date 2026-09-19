namespace Soenneker.Quark;

/// <summary>Builds Tailwind scrollbar track color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("scrollbar-track-", Responsive = true)]
public sealed class ScrollbarTrackColorBuilder : ColorBuilderBase<ScrollbarTrackColorBuilder>
{
    private RuleList<ScrollbarTrackColorRule> _rules;

    internal ScrollbarTrackColorBuilder()
    {
    }

    internal ScrollbarTrackColorBuilder(ScrollbarTrackColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal ScrollbarTrackColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new ScrollbarTrackColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>scrollbar-track-primary</c>.</summary>
    public ScrollbarTrackColorBuilder Primary => ChainClass(ScrollbarTrackColorEnum.Primary.Value);

    /// <summary>Adds <c>scrollbar-track-primary-foreground</c>.</summary>
    public ScrollbarTrackColorBuilder PrimaryForeground => ChainClass(ScrollbarTrackColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>scrollbar-track-secondary</c>.</summary>
    public ScrollbarTrackColorBuilder Secondary => ChainClass(ScrollbarTrackColorEnum.Secondary.Value);

    /// <summary>Adds <c>scrollbar-track-secondary-foreground</c>.</summary>
    public ScrollbarTrackColorBuilder SecondaryForeground => ChainClass(ScrollbarTrackColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>scrollbar-track-destructive</c>.</summary>
    public ScrollbarTrackColorBuilder Destructive => ChainClass(ScrollbarTrackColorEnum.Destructive.Value);

    /// <summary>Adds <c>scrollbar-track-destructive-foreground</c>.</summary>
    public ScrollbarTrackColorBuilder DestructiveForeground => ChainClass(ScrollbarTrackColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>scrollbar-track-muted</c>.</summary>
    public ScrollbarTrackColorBuilder Muted => ChainClass(ScrollbarTrackColorEnum.Muted.Value);

    /// <summary>Adds <c>scrollbar-track-muted-foreground</c>.</summary>
    public ScrollbarTrackColorBuilder MutedForeground => ChainClass(ScrollbarTrackColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>scrollbar-track-accent</c>.</summary>
    public ScrollbarTrackColorBuilder Accent => ChainClass(ScrollbarTrackColorEnum.Accent.Value);

    /// <summary>Adds <c>scrollbar-track-accent-foreground</c>.</summary>
    public ScrollbarTrackColorBuilder AccentForeground => ChainClass(ScrollbarTrackColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>scrollbar-track-popover</c>.</summary>
    public ScrollbarTrackColorBuilder Popover => ChainClass(ScrollbarTrackColorEnum.Popover.Value);

    /// <summary>Adds <c>scrollbar-track-popover-foreground</c>.</summary>
    public ScrollbarTrackColorBuilder PopoverForeground => ChainClass(ScrollbarTrackColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>scrollbar-track-card</c>.</summary>
    public ScrollbarTrackColorBuilder Card => ChainClass(ScrollbarTrackColorEnum.Card.Value);

    /// <summary>Adds <c>scrollbar-track-card-foreground</c>.</summary>
    public ScrollbarTrackColorBuilder CardForeground => ChainClass(ScrollbarTrackColorEnum.CardForeground.Value);

    /// <summary>Adds <c>scrollbar-track-background</c>.</summary>
    public ScrollbarTrackColorBuilder Background => ChainClass(ScrollbarTrackColorEnum.Background.Value);

    /// <summary>Adds <c>scrollbar-track-foreground</c>.</summary>
    public ScrollbarTrackColorBuilder Foreground => ChainClass(ScrollbarTrackColorEnum.Foreground.Value);

    /// <summary>Adds <c>scrollbar-track-border</c>.</summary>
    public ScrollbarTrackColorBuilder Border => ChainClass(ScrollbarTrackColorEnum.Border.Value);

    /// <summary>Adds <c>scrollbar-track-input</c>.</summary>
    public ScrollbarTrackColorBuilder Input => ChainClass(ScrollbarTrackColorEnum.Input.Value);

    /// <summary>Adds <c>scrollbar-track-ring</c>.</summary>
    public ScrollbarTrackColorBuilder Ring => ChainClass(ScrollbarTrackColorEnum.Ring.Value);

    /// <summary>Adds <c>scrollbar-track-ring/50</c>.</summary>
    public ScrollbarTrackColorBuilder Ring50 => ChainClass(ScrollbarTrackColorEnum.Ring50.Value);

    /// <summary>Adds <c>scrollbar-track-success</c>.</summary>
    public ScrollbarTrackColorBuilder Success => ChainClass(ScrollbarTrackColorEnum.Success.Value);

    /// <summary>Adds <c>scrollbar-track-warning</c>.</summary>
    public ScrollbarTrackColorBuilder Warning => ChainClass(ScrollbarTrackColorEnum.Warning.Value);

    /// <summary>Adds <c>scrollbar-track-info</c>.</summary>
    public ScrollbarTrackColorBuilder Info => ChainClass(ScrollbarTrackColorEnum.Info.Value);

    /// <summary>Adds <c>scrollbar-track-white</c>.</summary>
    public ScrollbarTrackColorBuilder White => ChainClass(ScrollbarTrackColorEnum.White.Value);

    /// <summary>Adds <c>scrollbar-track-black</c>.</summary>
    public ScrollbarTrackColorBuilder Black => ChainClass(ScrollbarTrackColorEnum.Black.Value);

    /// <summary>Adds <c>scrollbar-track-transparent</c>.</summary>
    public ScrollbarTrackColorBuilder Transparent => ChainClass(ScrollbarTrackColorEnum.Transparent.Value);

    /// <summary>Adds <c>scrollbar-track-current</c>.</summary>
    public ScrollbarTrackColorBuilder Current => ChainClass(ScrollbarTrackColorEnum.Current.Value);

    /// <summary>Adds <c>scrollbar-track-inherit</c>.</summary>
    public ScrollbarTrackColorBuilder Inherit => ChainClass(ScrollbarTrackColorEnum.Inherit.Value);

    public override ScrollbarTrackColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("scrollbar-track-", token));

    /// <summary>Adds a complete color class with the <c>scrollbar-track-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public ScrollbarTrackColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("scrollbar-track-", utility));

    private ScrollbarTrackColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new ScrollbarTrackColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ScrollbarTrackColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ScrollbarTrackColorRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }
}
