namespace Soenneker.Quark;

/// <summary>
/// Represents the rotate builder.
/// </summary>
[TailwindPrefix("rotate-", Responsive = true)]
public sealed class RotateBuilder : ResponsiveUtilityBuilder<RotateBuilder>
{
    internal RotateBuilder()
    {
    }

    internal RotateBuilder(RotateEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal RotateBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public RotateBuilder Is0 => ChainValue(RotateEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public RotateBuilder Is1 => ChainValue(RotateEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public RotateBuilder Is2 => ChainValue(RotateEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public RotateBuilder Is3 => ChainValue(RotateEnum.Is3Value);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public RotateBuilder Is6 => ChainValue(RotateEnum.Is6Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public RotateBuilder Is12 => ChainValue(RotateEnum.Is12Value);
    /// <summary>
    /// Gets or sets is45.
    /// </summary>
    public RotateBuilder Is45 => ChainValue(RotateEnum.Is45Value);
    /// <summary>
    /// Gets or sets is90.
    /// </summary>
    public RotateBuilder Is90 => ChainValue(RotateEnum.Is90Value);
    /// <summary>
    /// Gets or sets is180.
    /// </summary>
    public RotateBuilder Is180 => ChainValue(RotateEnum.Is180Value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public RotateBuilder Token(string value) => ChainValue("rotate-" + value);

}
