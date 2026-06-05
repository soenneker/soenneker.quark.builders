using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the transform enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TransformEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly TransformEnum None = new("transform-none");
    /// <summary>
    /// The gpu.
    /// </summary>
    public static readonly TransformEnum Gpu = new("transform-gpu");
    /// <summary>
    /// The cpu.
    /// </summary>
    public static readonly TransformEnum Cpu = new("transform-cpu");
}
