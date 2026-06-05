namespace Soenneker.Quark;

/// <summary>
/// Represents the stroke builder.
/// </summary>
[TailwindPrefix("stroke-", Responsive = true)]
public sealed class StrokeBuilder : FinalClassUtilityBuilder<StrokeBuilder>
{
    internal StrokeBuilder()
    {
    }

    internal StrokeBuilder(StrokeEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint) {}
    internal StrokeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    public StrokeBuilder Token(string value) => ChainClass($"stroke-{value}");
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public StrokeBuilder None => ChainClass(StrokeEnum.NoneValue);
    /// <summary>
    /// Gets or sets current.
    /// </summary>
    public StrokeBuilder Current => ChainClass(StrokeEnum.CurrentValue);

}
