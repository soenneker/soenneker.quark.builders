namespace Soenneker.Quark;

/// <summary>
/// Represents the ease builder.
/// </summary>
[TailwindPrefix("ease-", Responsive = true)]
public sealed class EaseBuilder : FinalClassUtilityBuilder<EaseBuilder>
{
    internal EaseBuilder()
    {
    }

    internal EaseBuilder(EaseEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal EaseBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets linear.
    /// </summary>
    public EaseBuilder Linear => ChainClass(EaseEnum.LinearValue);
    /// <summary>
    /// Gets or sets in.
    /// </summary>
    public EaseBuilder In => ChainClass(EaseEnum.InValue);
    /// <summary>
    /// Gets or sets out.
    /// </summary>
    public EaseBuilder Out => ChainClass(EaseEnum.OutValue);
    /// <summary>
    /// Gets or sets in out.
    /// </summary>
    public EaseBuilder InOut => ChainClass(EaseEnum.InOutValue);
    /// <summary>
    /// Adds an arbitrary ease utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public EaseBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "ease-"));

}
