
namespace Soenneker.Quark;

/// <summary>
/// Tailwind transform utility. Tailwind: transform-none, transform-gpu, transform-cpu.
/// </summary>
public static class Transform
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
    public static TransformBuilder Token(string value) => new("transform-" + value);
}
