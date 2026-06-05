
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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static TransformBuilder Token(string value) => new("transform-" + value);
}
