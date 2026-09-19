namespace Soenneker.Quark;

/// <summary>Builds Tailwind decoration color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationColorBuilder : ColorBuilderBase<DecorationColorBuilder>
{
    private RuleList<DecorationColorRule> _rules;

    internal DecorationColorBuilder()
    {
    }

    internal DecorationColorBuilder(DecorationColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal DecorationColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new DecorationColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>decoration-primary</c>.</summary>
    public DecorationColorBuilder Primary => ChainClass(DecorationColorEnum.Primary.Value);

    /// <summary>Adds <c>decoration-primary-foreground</c>.</summary>
    public DecorationColorBuilder PrimaryForeground => ChainClass(DecorationColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>decoration-secondary</c>.</summary>
    public DecorationColorBuilder Secondary => ChainClass(DecorationColorEnum.Secondary.Value);

    /// <summary>Adds <c>decoration-secondary-foreground</c>.</summary>
    public DecorationColorBuilder SecondaryForeground => ChainClass(DecorationColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>decoration-destructive</c>.</summary>
    public DecorationColorBuilder Destructive => ChainClass(DecorationColorEnum.Destructive.Value);

    /// <summary>Adds <c>decoration-destructive-foreground</c>.</summary>
    public DecorationColorBuilder DestructiveForeground => ChainClass(DecorationColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>decoration-muted</c>.</summary>
    public DecorationColorBuilder Muted => ChainClass(DecorationColorEnum.Muted.Value);

    /// <summary>Adds <c>decoration-muted-foreground</c>.</summary>
    public DecorationColorBuilder MutedForeground => ChainClass(DecorationColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>decoration-accent</c>.</summary>
    public DecorationColorBuilder Accent => ChainClass(DecorationColorEnum.Accent.Value);

    /// <summary>Adds <c>decoration-accent-foreground</c>.</summary>
    public DecorationColorBuilder AccentForeground => ChainClass(DecorationColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>decoration-popover</c>.</summary>
    public DecorationColorBuilder Popover => ChainClass(DecorationColorEnum.Popover.Value);

    /// <summary>Adds <c>decoration-popover-foreground</c>.</summary>
    public DecorationColorBuilder PopoverForeground => ChainClass(DecorationColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>decoration-card</c>.</summary>
    public DecorationColorBuilder Card => ChainClass(DecorationColorEnum.Card.Value);

    /// <summary>Adds <c>decoration-card-foreground</c>.</summary>
    public DecorationColorBuilder CardForeground => ChainClass(DecorationColorEnum.CardForeground.Value);

    /// <summary>Adds <c>decoration-background</c>.</summary>
    public DecorationColorBuilder Background => ChainClass(DecorationColorEnum.Background.Value);

    /// <summary>Adds <c>decoration-foreground</c>.</summary>
    public DecorationColorBuilder Foreground => ChainClass(DecorationColorEnum.Foreground.Value);

    /// <summary>Adds <c>decoration-border</c>.</summary>
    public DecorationColorBuilder Border => ChainClass(DecorationColorEnum.Border.Value);

    /// <summary>Adds <c>decoration-input</c>.</summary>
    public DecorationColorBuilder Input => ChainClass(DecorationColorEnum.Input.Value);

    /// <summary>Adds <c>decoration-ring</c>.</summary>
    public DecorationColorBuilder Ring => ChainClass(DecorationColorEnum.Ring.Value);

    /// <summary>Adds <c>decoration-ring/50</c>.</summary>
    public DecorationColorBuilder Ring50 => ChainClass(DecorationColorEnum.Ring50.Value);

    /// <summary>Adds <c>decoration-success</c>.</summary>
    public DecorationColorBuilder Success => ChainClass(DecorationColorEnum.Success.Value);

    /// <summary>Adds <c>decoration-warning</c>.</summary>
    public DecorationColorBuilder Warning => ChainClass(DecorationColorEnum.Warning.Value);

    /// <summary>Adds <c>decoration-info</c>.</summary>
    public DecorationColorBuilder Info => ChainClass(DecorationColorEnum.Info.Value);

    /// <summary>Adds <c>decoration-white</c>.</summary>
    public DecorationColorBuilder White => ChainClass(DecorationColorEnum.White.Value);

    /// <summary>Adds <c>decoration-black</c>.</summary>
    public DecorationColorBuilder Black => ChainClass(DecorationColorEnum.Black.Value);

    /// <summary>Adds <c>decoration-transparent</c>.</summary>
    public DecorationColorBuilder Transparent => ChainClass(DecorationColorEnum.Transparent.Value);

    /// <summary>Adds <c>decoration-current</c>.</summary>
    public DecorationColorBuilder Current => ChainClass(DecorationColorEnum.Current.Value);

    /// <summary>Adds <c>decoration-inherit</c>.</summary>
    public DecorationColorBuilder Inherit => ChainClass(DecorationColorEnum.Inherit.Value);

    public override DecorationColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("decoration-", token));

    /// <summary>Adds a complete color class with the <c>decoration-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public DecorationColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("decoration-", utility));

    private DecorationColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new DecorationColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            DecorationColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                DecorationColorRule rule = _rules[i];
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
