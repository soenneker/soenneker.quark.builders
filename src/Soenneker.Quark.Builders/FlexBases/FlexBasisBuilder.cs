namespace Soenneker.Quark;

/// <summary>
/// Represents the flex basis builder.
/// </summary>
[TailwindPrefix("basis-", Responsive = true)]
public sealed class FlexBasisBuilder : FinalClassUtilityBuilder<FlexBasisBuilder>
{
    internal FlexBasisBuilder() {}
    internal FlexBasisBuilder(FlexBasisEnum value) : base(value.Value) {}
    internal FlexBasisBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public FlexBasisBuilder Auto => ChainClass(FlexBasisEnum.Auto.Value);
    /// <summary>
    /// Gets or sets full.
    /// </summary>
    public FlexBasisBuilder Full => ChainClass(FlexBasisEnum.Full.Value);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public FlexBasisBuilder Is0 => ChainClass(FlexBasisEnum.Is0.Value);
    /// <summary>
    /// Gets or sets is1of2.
    /// </summary>
    public FlexBasisBuilder Is1of2 => ChainClass(FlexBasisEnum.Is1of2.Value);
    /// <summary>
    /// Gets or sets is1of3.
    /// </summary>
    public FlexBasisBuilder Is1of3 => ChainClass(FlexBasisEnum.Is1of3.Value);
    /// <summary>
    /// Gets or sets is2of3.
    /// </summary>
    public FlexBasisBuilder Is2of3 => ChainClass(FlexBasisEnum.Is2of3.Value);
    /// <summary>
    /// Gets or sets is1of4.
    /// </summary>
    public FlexBasisBuilder Is1of4 => ChainClass(FlexBasisEnum.Is1of4.Value);
    /// <summary>
    /// Gets or sets is3of4.
    /// </summary>
    public FlexBasisBuilder Is3of4 => ChainClass(FlexBasisEnum.Is3of4.Value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public FlexBasisBuilder Token(string value) => ChainClass(value.StartsWith("basis-") ? value : $"basis-{value}");
}
