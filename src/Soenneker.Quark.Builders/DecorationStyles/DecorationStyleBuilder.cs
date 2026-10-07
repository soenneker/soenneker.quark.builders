namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration style builder.
/// </summary>
[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationStyleBuilder : FinalClassUtilityBuilder<DecorationStyleBuilder>
{
    internal DecorationStyleBuilder()
    {
    }

    internal DecorationStyleBuilder(DecorationStyleEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal DecorationStyleBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets solid.
    /// </summary>
    public DecorationStyleBuilder Solid => ChainClass(DecorationStyleEnum.SolidValue);
    /// <summary>
    /// Gets or sets double.
    /// </summary>
    public DecorationStyleBuilder Double => ChainClass(DecorationStyleEnum.DoubleValue);
    /// <summary>
    /// Gets or sets dotted.
    /// </summary>
    public DecorationStyleBuilder Dotted => ChainClass(DecorationStyleEnum.DottedValue);
    /// <summary>
    /// Gets or sets dashed.
    /// </summary>
    public DecorationStyleBuilder Dashed => ChainClass(DecorationStyleEnum.DashedValue);
    /// <summary>
    /// Gets or sets wavy.
    /// </summary>
    public DecorationStyleBuilder Wavy => ChainClass(DecorationStyleEnum.WavyValue);
    /// <summary>
    /// Adds an arbitrary decoration style utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DecorationStyleBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "decoration-"));

}
