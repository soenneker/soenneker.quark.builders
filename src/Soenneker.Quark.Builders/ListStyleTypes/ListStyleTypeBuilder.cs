namespace Soenneker.Quark;

/// <summary>Chains list marker utilities; modifiers apply to the next value.</summary>
[TailwindPrefix("list-", Responsive = true)]
public sealed class ListStyleTypeBuilder : CssBuilderBase<ListStyleTypeBuilder>
{
    private RuleList<ListStyleTypeRule> _rules;
    internal ListStyleTypeBuilder() { }
    internal ListStyleTypeBuilder(ListStyleTypeValue value) => Chain(value);

    /// <summary>
    /// Gets a list style type builder with none value (no marker).
    /// </summary>
    public ListStyleTypeBuilder None => Chain(ListStyleTypeValue.None);
    /// <summary>
    /// Gets a list style type builder with disc value (filled circle marker).
    /// </summary>
    public ListStyleTypeBuilder Disc => Chain(ListStyleTypeValue.Disc);
    /// <summary>
    /// Gets a list style type builder with circle value (hollow circle marker).
    /// </summary>
    public ListStyleTypeBuilder Circle => Chain(ListStyleTypeValue.Circle);
    /// <summary>
    /// Gets a list style type builder with square value (filled square marker).
    /// </summary>
    public ListStyleTypeBuilder Square => Chain(ListStyleTypeValue.Square);
    /// <summary>
    /// Gets a list style type builder with decimal value (decimal numbers).
    /// </summary>
    public ListStyleTypeBuilder Decimal => Chain(ListStyleTypeValue.Decimal);
    /// <summary>
    /// Gets a list style type builder with decimal-leading-zero value (zero-padded decimal numbers).
    /// </summary>
    public ListStyleTypeBuilder DecimalLeadingZero => Chain(ListStyleTypeValue.DecimalLeadingZero);
    /// <summary>
    /// Gets a list style type builder with lower-alpha value (lowercase letters).
    /// </summary>
    public ListStyleTypeBuilder LowerAlpha => Chain(ListStyleTypeValue.LowerAlpha);
    /// <summary>
    /// Gets a list style type builder with upper-alpha value (uppercase letters).
    /// </summary>
    public ListStyleTypeBuilder UpperAlpha => Chain(ListStyleTypeValue.UpperAlpha);
    /// <summary>
    /// Gets a list style type builder with lower-roman value (lowercase roman numerals).
    /// </summary>
    public ListStyleTypeBuilder LowerRoman => Chain(ListStyleTypeValue.LowerRoman);
    /// <summary>
    /// Gets a list style type builder with upper-roman value (uppercase roman numerals).
    /// </summary>
    public ListStyleTypeBuilder UpperRoman => Chain(ListStyleTypeValue.UpperRoman);
    /// <summary>
    /// Gets a list style type builder with lower-greek value (lowercase greek letters).
    /// </summary>
    public ListStyleTypeBuilder LowerGreek => Chain(ListStyleTypeValue.LowerGreek);
    /// <summary>
    /// Gets a list style type builder with armenian value (armenian numbering).
    /// </summary>
    public ListStyleTypeBuilder Armenian => Chain(ListStyleTypeValue.Armenian);
    /// <summary>
    /// Gets a list style type builder with georgian value (georgian numbering).
    /// </summary>
    public ListStyleTypeBuilder Georgian => Chain(ListStyleTypeValue.Georgian);
    /// <summary>
    /// Gets a list style type builder with inherit keyword.
    /// </summary>
    public ListStyleTypeBuilder Inherit => Chain(ListStyleTypeValue.Inherit);
    /// <summary>
    /// Gets a list style type builder with initial keyword.
    /// </summary>
    public ListStyleTypeBuilder Initial => Chain(ListStyleTypeValue.Initial);
    /// <summary>
    /// Gets a list style type builder with unset keyword.
    /// </summary>
    public ListStyleTypeBuilder Unset => Chain(ListStyleTypeValue.Unset);

    /// <summary>Adds an arbitrary Tailwind list-style token.</summary>
    public ListStyleTypeBuilder Token(string value) => Add("list-" + value);

    private ListStyleTypeBuilder Chain(ListStyleTypeValue value) => Add(value.Value switch
    {
        "none" => "list-none",
        "disc" => "list-disc",
        "decimal" => "list-decimal",
        var token when token.Length > 0 => $"list-[{token}]",
        _ => string.Empty
    });

    private ListStyleTypeBuilder Add(string value)
    {
        _rules.Add(new ListStyleTypeRule(value, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass() => _rules.CachedClass ??= BuildClass();

    private string BuildClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ListStyleTypeRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, modifiers: rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ListStyleTypeRule rule = _rules[i];
                writer.Add(rule.Value, modifiers: rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }
}
