namespace Soenneker.Quark;

/// <summary>
/// Represents the fill builder.
/// </summary>
[TailwindPrefix("fill-", Responsive = true)]
public sealed class FillBuilder : FinalClassUtilityBuilder<FillBuilder>
{
    internal FillBuilder()
    {
    }

    internal FillBuilder(FillEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal FillBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FillBuilder Token(string value) => ChainClass($"fill-{value}");

    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public FillBuilder None => ChainClass(FillEnum.NoneValue);

    /// <summary>
    /// `currentColor` — uses the element’s computed `color` (common for icons and rings).
    /// </summary>
    public FillBuilder Current => ChainClass(FillEnum.CurrentValue);
}
