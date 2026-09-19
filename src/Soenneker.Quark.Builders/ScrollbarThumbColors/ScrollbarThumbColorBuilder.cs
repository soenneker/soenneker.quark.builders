namespace Soenneker.Quark;

/// <summary>Builds Tailwind scrollbar thumb color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("scrollbar-thumb-", Responsive = true)]
public sealed class ScrollbarThumbColorBuilder : ColorBuilderBase<ScrollbarThumbColorBuilder>
{
    private RuleList<ScrollbarThumbColorRule> _rules;

    internal ScrollbarThumbColorBuilder()
    {
    }

    internal ScrollbarThumbColorBuilder(ScrollbarThumbColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal ScrollbarThumbColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new ScrollbarThumbColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>scrollbar-thumb-primary</c>.</summary>
    public ScrollbarThumbColorBuilder Primary => ChainClass(ScrollbarThumbColorEnum.Primary.Value);

    /// <summary>Adds <c>scrollbar-thumb-primary-foreground</c>.</summary>
    public ScrollbarThumbColorBuilder PrimaryForeground => ChainClass(ScrollbarThumbColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>scrollbar-thumb-secondary</c>.</summary>
    public ScrollbarThumbColorBuilder Secondary => ChainClass(ScrollbarThumbColorEnum.Secondary.Value);

    /// <summary>Adds <c>scrollbar-thumb-secondary-foreground</c>.</summary>
    public ScrollbarThumbColorBuilder SecondaryForeground => ChainClass(ScrollbarThumbColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>scrollbar-thumb-destructive</c>.</summary>
    public ScrollbarThumbColorBuilder Destructive => ChainClass(ScrollbarThumbColorEnum.Destructive.Value);

    /// <summary>Adds <c>scrollbar-thumb-destructive-foreground</c>.</summary>
    public ScrollbarThumbColorBuilder DestructiveForeground => ChainClass(ScrollbarThumbColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>scrollbar-thumb-muted</c>.</summary>
    public ScrollbarThumbColorBuilder Muted => ChainClass(ScrollbarThumbColorEnum.Muted.Value);

    /// <summary>Adds <c>scrollbar-thumb-muted-foreground</c>.</summary>
    public ScrollbarThumbColorBuilder MutedForeground => ChainClass(ScrollbarThumbColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>scrollbar-thumb-accent</c>.</summary>
    public ScrollbarThumbColorBuilder Accent => ChainClass(ScrollbarThumbColorEnum.Accent.Value);

    /// <summary>Adds <c>scrollbar-thumb-accent-foreground</c>.</summary>
    public ScrollbarThumbColorBuilder AccentForeground => ChainClass(ScrollbarThumbColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>scrollbar-thumb-popover</c>.</summary>
    public ScrollbarThumbColorBuilder Popover => ChainClass(ScrollbarThumbColorEnum.Popover.Value);

    /// <summary>Adds <c>scrollbar-thumb-popover-foreground</c>.</summary>
    public ScrollbarThumbColorBuilder PopoverForeground => ChainClass(ScrollbarThumbColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>scrollbar-thumb-card</c>.</summary>
    public ScrollbarThumbColorBuilder Card => ChainClass(ScrollbarThumbColorEnum.Card.Value);

    /// <summary>Adds <c>scrollbar-thumb-card-foreground</c>.</summary>
    public ScrollbarThumbColorBuilder CardForeground => ChainClass(ScrollbarThumbColorEnum.CardForeground.Value);

    /// <summary>Adds <c>scrollbar-thumb-background</c>.</summary>
    public ScrollbarThumbColorBuilder Background => ChainClass(ScrollbarThumbColorEnum.Background.Value);

    /// <summary>Adds <c>scrollbar-thumb-foreground</c>.</summary>
    public ScrollbarThumbColorBuilder Foreground => ChainClass(ScrollbarThumbColorEnum.Foreground.Value);

    /// <summary>Adds <c>scrollbar-thumb-border</c>.</summary>
    public ScrollbarThumbColorBuilder Border => ChainClass(ScrollbarThumbColorEnum.Border.Value);

    /// <summary>Adds <c>scrollbar-thumb-input</c>.</summary>
    public ScrollbarThumbColorBuilder Input => ChainClass(ScrollbarThumbColorEnum.Input.Value);

    /// <summary>Adds <c>scrollbar-thumb-ring</c>.</summary>
    public ScrollbarThumbColorBuilder Ring => ChainClass(ScrollbarThumbColorEnum.Ring.Value);

    /// <summary>Adds <c>scrollbar-thumb-ring/50</c>.</summary>
    public ScrollbarThumbColorBuilder Ring50 => ChainClass(ScrollbarThumbColorEnum.Ring50.Value);

    /// <summary>Adds <c>scrollbar-thumb-success</c>.</summary>
    public ScrollbarThumbColorBuilder Success => ChainClass(ScrollbarThumbColorEnum.Success.Value);

    /// <summary>Adds <c>scrollbar-thumb-warning</c>.</summary>
    public ScrollbarThumbColorBuilder Warning => ChainClass(ScrollbarThumbColorEnum.Warning.Value);

    /// <summary>Adds <c>scrollbar-thumb-info</c>.</summary>
    public ScrollbarThumbColorBuilder Info => ChainClass(ScrollbarThumbColorEnum.Info.Value);

    /// <summary>Adds <c>scrollbar-thumb-white</c>.</summary>
    public ScrollbarThumbColorBuilder White => ChainClass(ScrollbarThumbColorEnum.White.Value);

    /// <summary>Adds <c>scrollbar-thumb-black</c>.</summary>
    public ScrollbarThumbColorBuilder Black => ChainClass(ScrollbarThumbColorEnum.Black.Value);

    /// <summary>Adds <c>scrollbar-thumb-transparent</c>.</summary>
    public ScrollbarThumbColorBuilder Transparent => ChainClass(ScrollbarThumbColorEnum.Transparent.Value);

    /// <summary>Adds <c>scrollbar-thumb-current</c>.</summary>
    public ScrollbarThumbColorBuilder Current => ChainClass(ScrollbarThumbColorEnum.Current.Value);

    /// <summary>Adds <c>scrollbar-thumb-inherit</c>.</summary>
    public ScrollbarThumbColorBuilder Inherit => ChainClass(ScrollbarThumbColorEnum.Inherit.Value);

    public override ScrollbarThumbColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("scrollbar-thumb-", token));

    /// <summary>Adds a complete color class with the <c>scrollbar-thumb-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public ScrollbarThumbColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("scrollbar-thumb-", utility));

    private ScrollbarThumbColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new ScrollbarThumbColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ScrollbarThumbColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ScrollbarThumbColorRule rule = _rules[i];
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
