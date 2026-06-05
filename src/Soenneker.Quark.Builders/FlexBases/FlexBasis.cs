namespace Soenneker.Quark;

/// <summary>
/// Represents the flex basis.
/// </summary>
[TailwindModifiers(typeof(FlexBasisBuilder))]
public static partial class FlexBasis
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static FlexBasisBuilder Auto => new(FlexBasisEnum.Auto);
    /// <summary>
    /// Gets or sets full.
    /// </summary>
    public static FlexBasisBuilder Full => new(FlexBasisEnum.Full);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static FlexBasisBuilder Is0 => new(FlexBasisEnum.Is0);
    /// <summary>
    /// Gets or sets is1of2.
    /// </summary>
    public static FlexBasisBuilder Is1of2 => new(FlexBasisEnum.Is1of2);
    /// <summary>
    /// Gets or sets is1of3.
    /// </summary>
    public static FlexBasisBuilder Is1of3 => new(FlexBasisEnum.Is1of3);
    /// <summary>
    /// Gets or sets is2of3.
    /// </summary>
    public static FlexBasisBuilder Is2of3 => new(FlexBasisEnum.Is2of3);
    /// <summary>
    /// Gets or sets is1of4.
    /// </summary>
    public static FlexBasisBuilder Is1of4 => new(FlexBasisEnum.Is1of4);
    /// <summary>
    /// Gets or sets is3of4.
    /// </summary>
    public static FlexBasisBuilder Is3of4 => new(FlexBasisEnum.Is3of4);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static FlexBasisBuilder Token(string value) => new(value.StartsWith("basis-") ? value : $"basis-{value}");
}
