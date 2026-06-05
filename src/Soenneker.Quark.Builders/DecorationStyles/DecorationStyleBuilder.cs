namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration style builder.
/// </summary>
[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationStyleBuilder : ResponsiveUtilityBuilder<DecorationStyleBuilder>
{
    internal DecorationStyleBuilder()
    {
    }

    internal DecorationStyleBuilder(DecorationStyleEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DecorationStyleBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets solid.
    /// </summary>
    public DecorationStyleBuilder Solid => ChainValue(DecorationStyleEnum.SolidValue);
    /// <summary>
    /// Gets or sets double.
    /// </summary>
    public DecorationStyleBuilder Double => ChainValue(DecorationStyleEnum.DoubleValue);
    /// <summary>
    /// Gets or sets dotted.
    /// </summary>
    public DecorationStyleBuilder Dotted => ChainValue(DecorationStyleEnum.DottedValue);
    /// <summary>
    /// Gets or sets dashed.
    /// </summary>
    public DecorationStyleBuilder Dashed => ChainValue(DecorationStyleEnum.DashedValue);
    /// <summary>
    /// Gets or sets wavy.
    /// </summary>
    public DecorationStyleBuilder Wavy => ChainValue(DecorationStyleEnum.WavyValue);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public DecorationStyleBuilder Token(string value) => ChainValue("decoration-" + value);

}
