namespace Soenneker.Quark;

/// <summary>
/// Represents the gradient.
/// </summary>
[TailwindModifiers(typeof(GradientBuilder))]
public static partial class Gradient
{
    /// <summary>
    /// Adds the to Gradient utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GradientBuilder To(string value) => new($"bg-gradient-to-{value}");
    /// <summary>
    /// Adds the from Gradient utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GradientBuilder From(string value) => new($"from-{value}");
    /// <summary>
    /// Adds the via Gradient utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GradientBuilder Via(string value) => new($"via-{value}");
    /// <summary>
    /// Adds the end Gradient utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static GradientBuilder End(string value) => new($"to-{value}");
}
