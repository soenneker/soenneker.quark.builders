namespace Soenneker.Quark;

/// <summary>
/// Represents the text align builder.
/// </summary>
[TailwindPrefix("text-", Responsive = true)]
public sealed class TextAlignBuilder : ResponsiveUtilityBuilder<TextAlignBuilder>
{
    internal TextAlignBuilder()
    {
    }

    internal TextAlignBuilder(TextAlignmentEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal TextAlignBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public TextAlignBuilder Start => ChainValue(TextAlignmentEnum.StartValue);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public TextAlignBuilder Left => ChainValue("text-left");
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public TextAlignBuilder Center => ChainValue(TextAlignmentEnum.CenterValue);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public TextAlignBuilder Right => ChainValue("text-right");
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public TextAlignBuilder End => ChainValue(TextAlignmentEnum.EndValue);
    /// <summary>
    /// Adds an arbitrary text align utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public TextAlignBuilder Token(string value) => ChainValue(UtilityToken.WithPrefix(value, "text-"));

}
