namespace Soenneker.Quark;

/// <summary>Builds Tailwind drop shadow color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("drop-shadow-", Responsive = true)]
public sealed class DropShadowColorBuilder : ColorBuilderBase<DropShadowColorBuilder>
{
    private RuleList<DropShadowColorRule> _rules;

    internal DropShadowColorBuilder()
    {
    }

    internal DropShadowColorBuilder(DropShadowColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal DropShadowColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new DropShadowColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>drop-shadow-primary</c>.</summary>
    public DropShadowColorBuilder Primary => ChainClass(DropShadowColorEnum.Primary.Value);

    /// <summary>Adds <c>drop-shadow-primary-foreground</c>.</summary>
    public DropShadowColorBuilder PrimaryForeground => ChainClass(DropShadowColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>drop-shadow-secondary</c>.</summary>
    public DropShadowColorBuilder Secondary => ChainClass(DropShadowColorEnum.Secondary.Value);

    /// <summary>Adds <c>drop-shadow-secondary-foreground</c>.</summary>
    public DropShadowColorBuilder SecondaryForeground => ChainClass(DropShadowColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>drop-shadow-destructive</c>.</summary>
    public DropShadowColorBuilder Destructive => ChainClass(DropShadowColorEnum.Destructive.Value);

    /// <summary>Adds <c>drop-shadow-destructive-foreground</c>.</summary>
    public DropShadowColorBuilder DestructiveForeground => ChainClass(DropShadowColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>drop-shadow-muted</c>.</summary>
    public DropShadowColorBuilder Muted => ChainClass(DropShadowColorEnum.Muted.Value);

    /// <summary>Adds <c>drop-shadow-muted-foreground</c>.</summary>
    public DropShadowColorBuilder MutedForeground => ChainClass(DropShadowColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>drop-shadow-accent</c>.</summary>
    public DropShadowColorBuilder Accent => ChainClass(DropShadowColorEnum.Accent.Value);

    /// <summary>Adds <c>drop-shadow-accent-foreground</c>.</summary>
    public DropShadowColorBuilder AccentForeground => ChainClass(DropShadowColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>drop-shadow-popover</c>.</summary>
    public DropShadowColorBuilder Popover => ChainClass(DropShadowColorEnum.Popover.Value);

    /// <summary>Adds <c>drop-shadow-popover-foreground</c>.</summary>
    public DropShadowColorBuilder PopoverForeground => ChainClass(DropShadowColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>drop-shadow-card</c>.</summary>
    public DropShadowColorBuilder Card => ChainClass(DropShadowColorEnum.Card.Value);

    /// <summary>Adds <c>drop-shadow-card-foreground</c>.</summary>
    public DropShadowColorBuilder CardForeground => ChainClass(DropShadowColorEnum.CardForeground.Value);

    /// <summary>Adds <c>drop-shadow-background</c>.</summary>
    public DropShadowColorBuilder Background => ChainClass(DropShadowColorEnum.Background.Value);

    /// <summary>Adds <c>drop-shadow-foreground</c>.</summary>
    public DropShadowColorBuilder Foreground => ChainClass(DropShadowColorEnum.Foreground.Value);

    /// <summary>Adds <c>drop-shadow-border</c>.</summary>
    public DropShadowColorBuilder Border => ChainClass(DropShadowColorEnum.Border.Value);

    /// <summary>Adds <c>drop-shadow-input</c>.</summary>
    public DropShadowColorBuilder Input => ChainClass(DropShadowColorEnum.Input.Value);

    /// <summary>Adds <c>drop-shadow-ring</c>.</summary>
    public DropShadowColorBuilder Ring => ChainClass(DropShadowColorEnum.Ring.Value);

    /// <summary>Adds <c>drop-shadow-ring/50</c>.</summary>
    public DropShadowColorBuilder Ring50 => ChainClass(DropShadowColorEnum.Ring50.Value);

    /// <summary>Adds <c>drop-shadow-success</c>.</summary>
    public DropShadowColorBuilder Success => ChainClass(DropShadowColorEnum.Success.Value);

    /// <summary>Adds <c>drop-shadow-warning</c>.</summary>
    public DropShadowColorBuilder Warning => ChainClass(DropShadowColorEnum.Warning.Value);

    /// <summary>Adds <c>drop-shadow-info</c>.</summary>
    public DropShadowColorBuilder Info => ChainClass(DropShadowColorEnum.Info.Value);

    /// <summary>Adds <c>drop-shadow-white</c>.</summary>
    public DropShadowColorBuilder White => ChainClass(DropShadowColorEnum.White.Value);

    /// <summary>Adds <c>drop-shadow-black</c>.</summary>
    public DropShadowColorBuilder Black => ChainClass(DropShadowColorEnum.Black.Value);

    /// <summary>Adds <c>drop-shadow-transparent</c>.</summary>
    public DropShadowColorBuilder Transparent => ChainClass(DropShadowColorEnum.Transparent.Value);

    /// <summary>Adds <c>drop-shadow-current</c>.</summary>
    public DropShadowColorBuilder Current => ChainClass(DropShadowColorEnum.Current.Value);

    /// <summary>Adds <c>drop-shadow-inherit</c>.</summary>
    public DropShadowColorBuilder Inherit => ChainClass(DropShadowColorEnum.Inherit.Value);

    public override DropShadowColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("drop-shadow-", token));

    /// <summary>Adds a complete color class with the <c>drop-shadow-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public DropShadowColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("drop-shadow-", utility));

    private DropShadowColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new DropShadowColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            DropShadowColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                DropShadowColorRule rule = _rules[i];
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
