namespace Soenneker.Quark;

/// <summary>
/// Represents the gradient builder.
/// </summary>
[TailwindPrefix("bg-gradient-to-", Responsive = true)]
public sealed class GradientBuilder : FinalClassUtilityBuilder<GradientBuilder>
{
    internal GradientBuilder()
    {
    }

    internal GradientBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    /// <summary>
    /// Adds the to Gradient utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GradientBuilder To(string value) => ChainClass($"bg-gradient-to-{value}");
    /// <summary>
    /// Adds the from Gradient utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GradientBuilder From(string value) => ChainClass($"from-{value}");
    /// <summary>
    /// Adds the via Gradient utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GradientBuilder Via(string value) => ChainClass($"via-{value}");
    /// <summary>
    /// Adds the end Gradient utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GradientBuilder End(string value) => ChainClass($"to-{value}");
}
