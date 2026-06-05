namespace Soenneker.Quark;

/// <summary>
/// Represents the gradient.
/// </summary>
[TailwindModifiers(typeof(GradientBuilder))]
public static partial class Gradient
{
    /// <summary>
    /// Executes the to operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static GradientBuilder To(string value) => new($"bg-gradient-to-{value}");
    /// <summary>
    /// Executes the from operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static GradientBuilder From(string value) => new($"from-{value}");
    /// <summary>
    /// Executes the via operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static GradientBuilder Via(string value) => new($"via-{value}");
    /// <summary>
    /// Executes the end operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static GradientBuilder End(string value) => new($"to-{value}");
}
