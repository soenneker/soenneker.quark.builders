namespace Soenneker.Quark;

/// <summary>Builds Tailwind outline color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("outline-", Responsive = true)]
public sealed class OutlineColorBuilder : ColorBuilderBase<OutlineColorBuilder>
{
    private RuleList<OutlineColorRule> _rules;

    internal OutlineColorBuilder()
    {
    }

    internal OutlineColorBuilder(OutlineColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal OutlineColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new OutlineColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>outline-primary</c>.</summary>
    public OutlineColorBuilder Primary => ChainClass(OutlineColorEnum.Primary.Value);

    /// <summary>Adds <c>outline-primary-foreground</c>.</summary>
    public OutlineColorBuilder PrimaryForeground => ChainClass(OutlineColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>outline-secondary</c>.</summary>
    public OutlineColorBuilder Secondary => ChainClass(OutlineColorEnum.Secondary.Value);

    /// <summary>Adds <c>outline-secondary-foreground</c>.</summary>
    public OutlineColorBuilder SecondaryForeground => ChainClass(OutlineColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>outline-destructive</c>.</summary>
    public OutlineColorBuilder Destructive => ChainClass(OutlineColorEnum.Destructive.Value);

    /// <summary>Adds <c>outline-destructive-foreground</c>.</summary>
    public OutlineColorBuilder DestructiveForeground => ChainClass(OutlineColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>outline-muted</c>.</summary>
    public OutlineColorBuilder Muted => ChainClass(OutlineColorEnum.Muted.Value);

    /// <summary>Adds <c>outline-muted-foreground</c>.</summary>
    public OutlineColorBuilder MutedForeground => ChainClass(OutlineColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>outline-accent</c>.</summary>
    public OutlineColorBuilder Accent => ChainClass(OutlineColorEnum.Accent.Value);

    /// <summary>Adds <c>outline-accent-foreground</c>.</summary>
    public OutlineColorBuilder AccentForeground => ChainClass(OutlineColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>outline-popover</c>.</summary>
    public OutlineColorBuilder Popover => ChainClass(OutlineColorEnum.Popover.Value);

    /// <summary>Adds <c>outline-popover-foreground</c>.</summary>
    public OutlineColorBuilder PopoverForeground => ChainClass(OutlineColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>outline-card</c>.</summary>
    public OutlineColorBuilder Card => ChainClass(OutlineColorEnum.Card.Value);

    /// <summary>Adds <c>outline-card-foreground</c>.</summary>
    public OutlineColorBuilder CardForeground => ChainClass(OutlineColorEnum.CardForeground.Value);

    /// <summary>Adds <c>outline-background</c>.</summary>
    public OutlineColorBuilder Background => ChainClass(OutlineColorEnum.Background.Value);

    /// <summary>Adds <c>outline-foreground</c>.</summary>
    public OutlineColorBuilder Foreground => ChainClass(OutlineColorEnum.Foreground.Value);

    /// <summary>Adds <c>outline-border</c>.</summary>
    public OutlineColorBuilder Border => ChainClass(OutlineColorEnum.Border.Value);

    /// <summary>Adds <c>outline-input</c>.</summary>
    public OutlineColorBuilder Input => ChainClass(OutlineColorEnum.Input.Value);

    /// <summary>Adds <c>outline-ring</c>.</summary>
    public OutlineColorBuilder Ring => ChainClass(OutlineColorEnum.Ring.Value);

    /// <summary>Adds <c>outline-ring/50</c>.</summary>
    public OutlineColorBuilder Ring50 => ChainClass(OutlineColorEnum.Ring50.Value);

    /// <summary>Adds <c>outline-success</c>.</summary>
    public OutlineColorBuilder Success => ChainClass(OutlineColorEnum.Success.Value);

    /// <summary>Adds <c>outline-warning</c>.</summary>
    public OutlineColorBuilder Warning => ChainClass(OutlineColorEnum.Warning.Value);

    /// <summary>Adds <c>outline-info</c>.</summary>
    public OutlineColorBuilder Info => ChainClass(OutlineColorEnum.Info.Value);

    /// <summary>Adds <c>outline-white</c>.</summary>
    public OutlineColorBuilder White => ChainClass(OutlineColorEnum.White.Value);

    /// <summary>Adds <c>outline-black</c>.</summary>
    public OutlineColorBuilder Black => ChainClass(OutlineColorEnum.Black.Value);

    /// <summary>Adds <c>outline-transparent</c>.</summary>
    public OutlineColorBuilder Transparent => ChainClass(OutlineColorEnum.Transparent.Value);

    /// <summary>Adds <c>outline-current</c>.</summary>
    public OutlineColorBuilder Current => ChainClass(OutlineColorEnum.Current.Value);

    /// <summary>Adds <c>outline-inherit</c>.</summary>
    public OutlineColorBuilder Inherit => ChainClass(OutlineColorEnum.Inherit.Value);

    public override OutlineColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("outline-", token));

    /// <summary>Adds a complete color class with the <c>outline-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public OutlineColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("outline-", utility));

    private OutlineColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new OutlineColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            OutlineColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                OutlineColorRule rule = _rules[i];
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
