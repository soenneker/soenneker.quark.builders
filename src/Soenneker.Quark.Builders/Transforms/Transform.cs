
namespace Soenneker.Quark;

/// <summary>
/// Tailwind transform utility. Tailwind: transform-none, transform-gpu, transform-cpu.
/// </summary>
[TailwindModifiers(typeof(TransformBuilder))]
public static partial class Transform
{
    /// <summary>
    /// No transform (none).
    /// </summary>
    public static TransformBuilder None => new(TransformEnum.None);

    /// <summary>
    /// Uses the GPU transform utility.
    /// </summary>
    public static TransformBuilder Gpu => new(TransformEnum.Gpu);

    /// <summary>
    /// Uses the CPU transform utility.
    /// </summary>
    public static TransformBuilder Cpu => new(TransformEnum.Cpu);
    /// <summary>
    /// Adds an arbitrary transform utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static TransformBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "transform-"));
}
