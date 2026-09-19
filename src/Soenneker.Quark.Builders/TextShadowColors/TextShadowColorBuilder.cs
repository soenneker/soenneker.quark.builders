namespace Soenneker.Quark;

/// <summary>Builds Tailwind text shadow color utilities with responsive and state modifiers.</summary>
[TailwindPrefix("text-shadow-", Responsive = true)]
public sealed class TextShadowColorBuilder : ColorBuilderBase<TextShadowColorBuilder>
{
    private RuleList<TextShadowColorRule> _rules;

    internal TextShadowColorBuilder()
    {
    }

    internal TextShadowColorBuilder(TextShadowColorEnum value, BreakpointType? breakpoint = null) : this(value.Value, breakpoint)
    {
    }

    internal TextShadowColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new TextShadowColorRule(value, breakpoint));
    }

    /// <summary>Adds <c>text-shadow-primary</c>.</summary>
    public TextShadowColorBuilder Primary => ChainClass(TextShadowColorEnum.Primary.Value);

    /// <summary>Adds <c>text-shadow-primary-foreground</c>.</summary>
    public TextShadowColorBuilder PrimaryForeground => ChainClass(TextShadowColorEnum.PrimaryForeground.Value);

    /// <summary>Adds <c>text-shadow-secondary</c>.</summary>
    public TextShadowColorBuilder Secondary => ChainClass(TextShadowColorEnum.Secondary.Value);

    /// <summary>Adds <c>text-shadow-secondary-foreground</c>.</summary>
    public TextShadowColorBuilder SecondaryForeground => ChainClass(TextShadowColorEnum.SecondaryForeground.Value);

    /// <summary>Adds <c>text-shadow-destructive</c>.</summary>
    public TextShadowColorBuilder Destructive => ChainClass(TextShadowColorEnum.Destructive.Value);

    /// <summary>Adds <c>text-shadow-destructive-foreground</c>.</summary>
    public TextShadowColorBuilder DestructiveForeground => ChainClass(TextShadowColorEnum.DestructiveForeground.Value);

    /// <summary>Adds <c>text-shadow-muted</c>.</summary>
    public TextShadowColorBuilder Muted => ChainClass(TextShadowColorEnum.Muted.Value);

    /// <summary>Adds <c>text-shadow-muted-foreground</c>.</summary>
    public TextShadowColorBuilder MutedForeground => ChainClass(TextShadowColorEnum.MutedForeground.Value);

    /// <summary>Adds <c>text-shadow-accent</c>.</summary>
    public TextShadowColorBuilder Accent => ChainClass(TextShadowColorEnum.Accent.Value);

    /// <summary>Adds <c>text-shadow-accent-foreground</c>.</summary>
    public TextShadowColorBuilder AccentForeground => ChainClass(TextShadowColorEnum.AccentForeground.Value);

    /// <summary>Adds <c>text-shadow-popover</c>.</summary>
    public TextShadowColorBuilder Popover => ChainClass(TextShadowColorEnum.Popover.Value);

    /// <summary>Adds <c>text-shadow-popover-foreground</c>.</summary>
    public TextShadowColorBuilder PopoverForeground => ChainClass(TextShadowColorEnum.PopoverForeground.Value);

    /// <summary>Adds <c>text-shadow-card</c>.</summary>
    public TextShadowColorBuilder Card => ChainClass(TextShadowColorEnum.Card.Value);

    /// <summary>Adds <c>text-shadow-card-foreground</c>.</summary>
    public TextShadowColorBuilder CardForeground => ChainClass(TextShadowColorEnum.CardForeground.Value);

    /// <summary>Adds <c>text-shadow-background</c>.</summary>
    public TextShadowColorBuilder Background => ChainClass(TextShadowColorEnum.Background.Value);

    /// <summary>Adds <c>text-shadow-foreground</c>.</summary>
    public TextShadowColorBuilder Foreground => ChainClass(TextShadowColorEnum.Foreground.Value);

    /// <summary>Adds <c>text-shadow-border</c>.</summary>
    public TextShadowColorBuilder Border => ChainClass(TextShadowColorEnum.Border.Value);

    /// <summary>Adds <c>text-shadow-input</c>.</summary>
    public TextShadowColorBuilder Input => ChainClass(TextShadowColorEnum.Input.Value);

    /// <summary>Adds <c>text-shadow-ring</c>.</summary>
    public TextShadowColorBuilder Ring => ChainClass(TextShadowColorEnum.Ring.Value);

    /// <summary>Adds <c>text-shadow-ring/50</c>.</summary>
    public TextShadowColorBuilder Ring50 => ChainClass(TextShadowColorEnum.Ring50.Value);

    /// <summary>Adds <c>text-shadow-success</c>.</summary>
    public TextShadowColorBuilder Success => ChainClass(TextShadowColorEnum.Success.Value);

    /// <summary>Adds <c>text-shadow-warning</c>.</summary>
    public TextShadowColorBuilder Warning => ChainClass(TextShadowColorEnum.Warning.Value);

    /// <summary>Adds <c>text-shadow-info</c>.</summary>
    public TextShadowColorBuilder Info => ChainClass(TextShadowColorEnum.Info.Value);

    /// <summary>Adds <c>text-shadow-white</c>.</summary>
    public TextShadowColorBuilder White => ChainClass(TextShadowColorEnum.White.Value);

    /// <summary>Adds <c>text-shadow-black</c>.</summary>
    public TextShadowColorBuilder Black => ChainClass(TextShadowColorEnum.Black.Value);

    /// <summary>Adds <c>text-shadow-transparent</c>.</summary>
    public TextShadowColorBuilder Transparent => ChainClass(TextShadowColorEnum.Transparent.Value);

    /// <summary>Adds <c>text-shadow-current</c>.</summary>
    public TextShadowColorBuilder Current => ChainClass(TextShadowColorEnum.Current.Value);

    /// <summary>Adds <c>text-shadow-inherit</c>.</summary>
    public TextShadowColorBuilder Inherit => ChainClass(TextShadowColorEnum.Inherit.Value);

    public override TextShadowColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass("text-shadow-", token));

    /// <summary>Adds a complete color class with the <c>text-shadow-</c> prefix.</summary>
    /// <param name="utility">The complete color utility.</param>
    /// <returns>The current builder.</returns>
    public TextShadowColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass("text-shadow-", utility));

    private TextShadowColorBuilder ChainClass(string value)
    {
        if (value.Length != 0)
            _rules.Add(new TextShadowColorRule(value, null, ConsumePendingModifierChain()));

        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            TextShadowColorRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                TextShadowColorRule rule = _rules[i];
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
