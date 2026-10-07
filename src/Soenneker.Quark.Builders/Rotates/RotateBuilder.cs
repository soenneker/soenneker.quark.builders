namespace Soenneker.Quark;

/// <summary>
/// Represents the rotate builder.
/// </summary>
[TailwindPrefix("rotate-", Responsive = true)]
public sealed class RotateBuilder : FinalClassUtilityBuilder<RotateBuilder>
{
    internal RotateBuilder()
    {
    }

    internal RotateBuilder(RotateEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal RotateBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public RotateBuilder Is0 => ChainClass(RotateEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public RotateBuilder Is1 => ChainClass(RotateEnum.Is1Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public RotateBuilder Is2 => ChainClass(RotateEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public RotateBuilder Is3 => ChainClass(RotateEnum.Is3Value);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public RotateBuilder Is6 => ChainClass(RotateEnum.Is6Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public RotateBuilder Is12 => ChainClass(RotateEnum.Is12Value);
    /// <summary>
    /// Gets or sets is45.
    /// </summary>
    public RotateBuilder Is45 => ChainClass(RotateEnum.Is45Value);
    /// <summary>
    /// Gets or sets is90.
    /// </summary>
    public RotateBuilder Is90 => ChainClass(RotateEnum.Is90Value);
    /// <summary>
    /// Gets or sets is180.
    /// </summary>
    public RotateBuilder Is180 => ChainClass(RotateEnum.Is180Value);
    /// <summary>
    /// Adds an arbitrary rotate utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RotateBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "rotate-"));

}
