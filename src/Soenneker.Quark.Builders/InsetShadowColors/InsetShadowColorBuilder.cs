namespace Soenneker.Quark;

/// <summary>Builds Tailwind inset shadow color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("inset-shadow-", Responsive = true)]
public sealed class InsetShadowColorBuilder : ColorBuilderBase<InsetShadowColorBuilder>
{
    private RuleList<InsetShadowColorRule> _rules;

    internal InsetShadowColorBuilder()
    {
    }

    internal InsetShadowColorBuilder(InsetShadowColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal InsetShadowColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new InsetShadowColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>inset-shadow-primary</c>.</summary>
    public InsetShadowColorBuilder Primary => ChainClass(InsetShadowColorEnum.Primary.Value);

    /// <summary>Adds <c>inset-shadow-primary-foreground</c>.</summary>
    public InsetShadowColorBuilder PrimaryForeground => ChainClass(InsetShadowColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>inset-shadow-secondary</c>.</summary>
    public InsetShadowColorBuilder Secondary => ChainClass(InsetShadowColorEnum.Secondary.Value);

    /// <summary>Adds <c>inset-shadow-secondary-foreground</c>.</summary>
    public InsetShadowColorBuilder SecondaryForeground => ChainClass(InsetShadowColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>inset-shadow-destructive</c>.</summary>
    public InsetShadowColorBuilder Destructive => ChainClass(InsetShadowColorEnum.Destructive.Value);

    /// <summary>Adds <c>inset-shadow-destructive-foreground</c>.</summary>
    public InsetShadowColorBuilder DestructiveForeground => ChainClass(InsetShadowColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>inset-shadow-muted</c>.</summary>
    public InsetShadowColorBuilder Muted => ChainClass(InsetShadowColorEnum.Muted.Value);

    /// <summary>Adds <c>inset-shadow-muted-foreground</c>.</summary>
    public InsetShadowColorBuilder MutedForeground => ChainClass(InsetShadowColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>inset-shadow-accent</c>.</summary>
    public InsetShadowColorBuilder Accent => ChainClass(InsetShadowColorEnum.Accent.Value);

    /// <summary>Adds <c>inset-shadow-accent-foreground</c>.</summary>
    public InsetShadowColorBuilder AccentForeground => ChainClass(InsetShadowColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>inset-shadow-popover</c>.</summary>
    public InsetShadowColorBuilder Popover => ChainClass(InsetShadowColorEnum.Popover.Value);

    /// <summary>Adds <c>inset-shadow-popover-foreground</c>.</summary>
    public InsetShadowColorBuilder PopoverForeground => ChainClass(InsetShadowColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>inset-shadow-card</c>.</summary>
    public InsetShadowColorBuilder Card => ChainClass(InsetShadowColorEnum.Card.Value);

    /// <summary>Adds <c>inset-shadow-card-foreground</c>.</summary>
    public InsetShadowColorBuilder CardForeground => ChainClass(InsetShadowColorEnum.CardForeground.Value);

    /// <summary>Adds <c>inset-shadow-background</c>.</summary>
    public InsetShadowColorBuilder Background => ChainClass(InsetShadowColorEnum.Background.Value);

    /// <summary>Adds <c>inset-shadow-foreground</c>.</summary>
    public InsetShadowColorBuilder Foreground => ChainClass(InsetShadowColorEnum.Foreground.Value);

    /// <summary>Adds <c>inset-shadow-border</c>.</summary>
    public InsetShadowColorBuilder Border => ChainClass(InsetShadowColorEnum.Border.Value);

    /// <summary>Adds <c>inset-shadow-input</c>.</summary>
    public InsetShadowColorBuilder Input => ChainClass(InsetShadowColorEnum.Input.Value);

    /// <summary>Adds <c>inset-shadow-ring</c>.</summary>
    public InsetShadowColorBuilder Ring => ChainClass(InsetShadowColorEnum.Ring.Value);

    /// <summary>Adds <c>inset-shadow-ring/50</c>.</summary>
    public InsetShadowColorBuilder Ring50 => ChainClass(InsetShadowColorEnum.Ring50.Value);

    /// <summary>Adds <c>inset-shadow-success</c>.</summary>
    public InsetShadowColorBuilder Success => ChainClass(InsetShadowColorEnum.Success.Value);

    /// <summary>Adds <c>inset-shadow-warning</c>.</summary>
    public InsetShadowColorBuilder Warning => ChainClass(InsetShadowColorEnum.Warning.Value);

    /// <summary>Adds <c>inset-shadow-info</c>.</summary>
    public InsetShadowColorBuilder Info => ChainClass(InsetShadowColorEnum.Info.Value);

    /// <summary>Adds <c>inset-shadow-white</c>.</summary>
    public InsetShadowColorBuilder White => ChainClass(InsetShadowColorEnum.White.Value);

    /// <summary>Adds <c>inset-shadow-black</c>.</summary>
    public InsetShadowColorBuilder Black => ChainClass(InsetShadowColorEnum.Black.Value);

    /// <summary>Adds <c>inset-shadow-transparent</c>.</summary>
    public InsetShadowColorBuilder Transparent => ChainClass(InsetShadowColorEnum.Transparent.Value);

    /// <summary>Adds <c>inset-shadow-current</c>.</summary>
    public InsetShadowColorBuilder Current => ChainClass(InsetShadowColorEnum.Current.Value);

    /// <summary>Adds <c>inset-shadow-inherit</c>.</summary>
    public InsetShadowColorBuilder Inherit => ChainClass(InsetShadowColorEnum.Inherit.Value);

    public override InsetShadowColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("inset-shadow-", token));

    /// <summary>Adds a complete color class with the <c>inset-shadow-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public InsetShadowColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("inset-shadow-", utility));

    private InsetShadowColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new InsetShadowColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            InsetShadowColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                InsetShadowColorRule rule = _rules[i];
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
