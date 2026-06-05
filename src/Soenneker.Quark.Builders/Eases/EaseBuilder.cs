namespace Soenneker.Quark;

/// <summary>
/// Represents the ease builder.
/// </summary>
[TailwindPrefix("ease-", Responsive = true)]
public sealed class EaseBuilder : ResponsiveUtilityBuilder<EaseBuilder>
{
    internal EaseBuilder()
    {
    }

    internal EaseBuilder(EaseEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal EaseBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets linear.
    /// </summary>
    public EaseBuilder Linear => ChainValue(EaseEnum.LinearValue);
    /// <summary>
    /// Gets or sets in.
    /// </summary>
    public EaseBuilder In => ChainValue(EaseEnum.InValue);
    /// <summary>
    /// Gets or sets out.
    /// </summary>
    public EaseBuilder Out => ChainValue(EaseEnum.OutValue);
    /// <summary>
    /// Gets or sets in out.
    /// </summary>
    public EaseBuilder InOut => ChainValue(EaseEnum.InOutValue);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public EaseBuilder Token(string value) => ChainValue("ease-" + value);

}
