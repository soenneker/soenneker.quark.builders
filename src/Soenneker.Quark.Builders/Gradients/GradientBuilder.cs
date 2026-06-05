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
    /// Executes the to operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public GradientBuilder To(string value) => ChainClass($"bg-gradient-to-{value}");
    /// <summary>
    /// Executes the from operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public GradientBuilder From(string value) => ChainClass($"from-{value}");
    /// <summary>
    /// Executes the via operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public GradientBuilder Via(string value) => ChainClass($"via-{value}");
    /// <summary>
    /// Executes the end operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public GradientBuilder End(string value) => ChainClass($"to-{value}");
}
