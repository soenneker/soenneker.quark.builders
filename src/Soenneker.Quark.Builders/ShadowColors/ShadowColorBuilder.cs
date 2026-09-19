namespace Soenneker.Quark;

/// <summary>Builds Tailwind shadow color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("shadow-", Responsive = true)]
public sealed class ShadowColorBuilder : ColorBuilderBase<ShadowColorBuilder>
{
    private RuleList<ShadowColorRule> _rules;

    internal ShadowColorBuilder()
    {
    }

    internal ShadowColorBuilder(ShadowColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal ShadowColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new ShadowColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>shadow-primary</c>.</summary>
    public ShadowColorBuilder Primary => ChainClass(ShadowColorEnum.Primary.Value);

    /// <summary>Adds <c>shadow-primary-foreground</c>.</summary>
    public ShadowColorBuilder PrimaryForeground => ChainClass(ShadowColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>shadow-secondary</c>.</summary>
    public ShadowColorBuilder Secondary => ChainClass(ShadowColorEnum.Secondary.Value);

    /// <summary>Adds <c>shadow-secondary-foreground</c>.</summary>
    public ShadowColorBuilder SecondaryForeground => ChainClass(ShadowColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>shadow-destructive</c>.</summary>
    public ShadowColorBuilder Destructive => ChainClass(ShadowColorEnum.Destructive.Value);

    /// <summary>Adds <c>shadow-destructive-foreground</c>.</summary>
    public ShadowColorBuilder DestructiveForeground => ChainClass(ShadowColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>shadow-muted</c>.</summary>
    public ShadowColorBuilder Muted => ChainClass(ShadowColorEnum.Muted.Value);

    /// <summary>Adds <c>shadow-muted-foreground</c>.</summary>
    public ShadowColorBuilder MutedForeground => ChainClass(ShadowColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>shadow-accent</c>.</summary>
    public ShadowColorBuilder Accent => ChainClass(ShadowColorEnum.Accent.Value);

    /// <summary>Adds <c>shadow-accent-foreground</c>.</summary>
    public ShadowColorBuilder AccentForeground => ChainClass(ShadowColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>shadow-popover</c>.</summary>
    public ShadowColorBuilder Popover => ChainClass(ShadowColorEnum.Popover.Value);

    /// <summary>Adds <c>shadow-popover-foreground</c>.</summary>
    public ShadowColorBuilder PopoverForeground => ChainClass(ShadowColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>shadow-card</c>.</summary>
    public ShadowColorBuilder Card => ChainClass(ShadowColorEnum.Card.Value);

    /// <summary>Adds <c>shadow-card-foreground</c>.</summary>
    public ShadowColorBuilder CardForeground => ChainClass(ShadowColorEnum.CardForeground.Value);

    /// <summary>Adds <c>shadow-background</c>.</summary>
    public ShadowColorBuilder Background => ChainClass(ShadowColorEnum.Background.Value);

    /// <summary>Adds <c>shadow-foreground</c>.</summary>
    public ShadowColorBuilder Foreground => ChainClass(ShadowColorEnum.Foreground.Value);

    /// <summary>Adds <c>shadow-border</c>.</summary>
    public ShadowColorBuilder Border => ChainClass(ShadowColorEnum.Border.Value);

    /// <summary>Adds <c>shadow-input</c>.</summary>
    public ShadowColorBuilder Input => ChainClass(ShadowColorEnum.Input.Value);

    /// <summary>Adds <c>shadow-ring</c>.</summary>
    public ShadowColorBuilder Ring => ChainClass(ShadowColorEnum.Ring.Value);

    /// <summary>Adds <c>shadow-ring/50</c>.</summary>
    public ShadowColorBuilder Ring50 => ChainClass(ShadowColorEnum.Ring50.Value);

    /// <summary>Adds <c>shadow-success</c>.</summary>
    public ShadowColorBuilder Success => ChainClass(ShadowColorEnum.Success.Value);

    /// <summary>Adds <c>shadow-warning</c>.</summary>
    public ShadowColorBuilder Warning => ChainClass(ShadowColorEnum.Warning.Value);

    /// <summary>Adds <c>shadow-info</c>.</summary>
    public ShadowColorBuilder Info => ChainClass(ShadowColorEnum.Info.Value);

    /// <summary>Adds <c>shadow-white</c>.</summary>
    public ShadowColorBuilder White => ChainClass(ShadowColorEnum.White.Value);

    /// <summary>Adds <c>shadow-black</c>.</summary>
    public ShadowColorBuilder Black => ChainClass(ShadowColorEnum.Black.Value);

    /// <summary>Adds <c>shadow-transparent</c>.</summary>
    public ShadowColorBuilder Transparent => ChainClass(ShadowColorEnum.Transparent.Value);

    /// <summary>Adds <c>shadow-current</c>.</summary>
    public ShadowColorBuilder Current => ChainClass(ShadowColorEnum.Current.Value);

    /// <summary>Adds <c>shadow-inherit</c>.</summary>
    public ShadowColorBuilder Inherit => ChainClass(ShadowColorEnum.Inherit.Value);

    public override ShadowColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("shadow-", token));

    /// <summary>Adds a complete color class with the <c>shadow-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public ShadowColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("shadow-", utility));

    private ShadowColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new ShadowColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ShadowColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ShadowColorRule rule = _rules[i];
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
