namespace Soenneker.Quark;

/// <summary>Builds Tailwind inset ring color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("inset-ring-", Responsive = true)]
public sealed class InsetRingColorBuilder : ColorBuilderBase<InsetRingColorBuilder>
{
    private RuleList<InsetRingColorRule> _rules;

    internal InsetRingColorBuilder()
    {
    }

    internal InsetRingColorBuilder(InsetRingColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal InsetRingColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new InsetRingColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>inset-ring-primary</c>.</summary>
    public InsetRingColorBuilder Primary => ChainClass(InsetRingColorEnum.Primary.Value);

    /// <summary>Adds <c>inset-ring-primary-foreground</c>.</summary>
    public InsetRingColorBuilder PrimaryForeground => ChainClass(InsetRingColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>inset-ring-secondary</c>.</summary>
    public InsetRingColorBuilder Secondary => ChainClass(InsetRingColorEnum.Secondary.Value);

    /// <summary>Adds <c>inset-ring-secondary-foreground</c>.</summary>
    public InsetRingColorBuilder SecondaryForeground => ChainClass(InsetRingColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>inset-ring-destructive</c>.</summary>
    public InsetRingColorBuilder Destructive => ChainClass(InsetRingColorEnum.Destructive.Value);

    /// <summary>Adds <c>inset-ring-destructive-foreground</c>.</summary>
    public InsetRingColorBuilder DestructiveForeground => ChainClass(InsetRingColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>inset-ring-muted</c>.</summary>
    public InsetRingColorBuilder Muted => ChainClass(InsetRingColorEnum.Muted.Value);

    /// <summary>Adds <c>inset-ring-muted-foreground</c>.</summary>
    public InsetRingColorBuilder MutedForeground => ChainClass(InsetRingColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>inset-ring-accent</c>.</summary>
    public InsetRingColorBuilder Accent => ChainClass(InsetRingColorEnum.Accent.Value);

    /// <summary>Adds <c>inset-ring-accent-foreground</c>.</summary>
    public InsetRingColorBuilder AccentForeground => ChainClass(InsetRingColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>inset-ring-popover</c>.</summary>
    public InsetRingColorBuilder Popover => ChainClass(InsetRingColorEnum.Popover.Value);

    /// <summary>Adds <c>inset-ring-popover-foreground</c>.</summary>
    public InsetRingColorBuilder PopoverForeground => ChainClass(InsetRingColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>inset-ring-card</c>.</summary>
    public InsetRingColorBuilder Card => ChainClass(InsetRingColorEnum.Card.Value);

    /// <summary>Adds <c>inset-ring-card-foreground</c>.</summary>
    public InsetRingColorBuilder CardForeground => ChainClass(InsetRingColorEnum.CardForeground.Value);

    /// <summary>Adds <c>inset-ring-background</c>.</summary>
    public InsetRingColorBuilder Background => ChainClass(InsetRingColorEnum.Background.Value);

    /// <summary>Adds <c>inset-ring-foreground</c>.</summary>
    public InsetRingColorBuilder Foreground => ChainClass(InsetRingColorEnum.Foreground.Value);

    /// <summary>Adds <c>inset-ring-border</c>.</summary>
    public InsetRingColorBuilder Border => ChainClass(InsetRingColorEnum.Border.Value);

    /// <summary>Adds <c>inset-ring-input</c>.</summary>
    public InsetRingColorBuilder Input => ChainClass(InsetRingColorEnum.Input.Value);

    /// <summary>Adds <c>inset-ring-ring</c>.</summary>
    public InsetRingColorBuilder Ring => ChainClass(InsetRingColorEnum.Ring.Value);

    /// <summary>Adds <c>inset-ring-ring/50</c>.</summary>
    public InsetRingColorBuilder Ring50 => ChainClass(InsetRingColorEnum.Ring50.Value);

    /// <summary>Adds <c>inset-ring-success</c>.</summary>
    public InsetRingColorBuilder Success => ChainClass(InsetRingColorEnum.Success.Value);

    /// <summary>Adds <c>inset-ring-warning</c>.</summary>
    public InsetRingColorBuilder Warning => ChainClass(InsetRingColorEnum.Warning.Value);

    /// <summary>Adds <c>inset-ring-info</c>.</summary>
    public InsetRingColorBuilder Info => ChainClass(InsetRingColorEnum.Info.Value);

    /// <summary>Adds <c>inset-ring-white</c>.</summary>
    public InsetRingColorBuilder White => ChainClass(InsetRingColorEnum.White.Value);

    /// <summary>Adds <c>inset-ring-black</c>.</summary>
    public InsetRingColorBuilder Black => ChainClass(InsetRingColorEnum.Black.Value);

    /// <summary>Adds <c>inset-ring-transparent</c>.</summary>
    public InsetRingColorBuilder Transparent => ChainClass(InsetRingColorEnum.Transparent.Value);

    /// <summary>Adds <c>inset-ring-current</c>.</summary>
    public InsetRingColorBuilder Current => ChainClass(InsetRingColorEnum.Current.Value);

    /// <summary>Adds <c>inset-ring-inherit</c>.</summary>
    public InsetRingColorBuilder Inherit => ChainClass(InsetRingColorEnum.Inherit.Value);

    public override InsetRingColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("inset-ring-", token));

    /// <summary>Adds a complete color class with the <c>inset-ring-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public InsetRingColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("inset-ring-", utility));

    private InsetRingColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new InsetRingColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            InsetRingColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                InsetRingColorRule rule = _rules[i];
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
