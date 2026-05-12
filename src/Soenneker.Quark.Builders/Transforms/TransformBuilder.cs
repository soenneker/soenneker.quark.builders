namespace Soenneker.Quark;

/// <summary>
/// Tailwind transform utility builder. Tailwind: transform-none, transform-gpu, transform-cpu.
/// </summary>
[TailwindPrefix("transform-", Responsive = true)]
public sealed class TransformBuilder : ResponsiveUtilityBuilder<TransformBuilder>
{
    internal TransformBuilder()
    {
    }

    internal TransformBuilder(TransformEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal TransformBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Sets the transform to none.
    /// </summary>
    public TransformBuilder None => ChainValue(TransformEnum.NoneValue);
    /// <summary>
    /// Uses the GPU transform utility.
    /// </summary>
    public TransformBuilder Gpu => ChainValue(TransformEnum.GpuValue);
    /// <summary>
    /// Uses the CPU transform utility.
    /// </summary>
    public TransformBuilder Cpu => ChainValue(TransformEnum.CpuValue);

    /// <summary>
    /// Applies the transform value suffix after the `transform-` prefix, including arbitrary values.
    /// </summary>
    public TransformBuilder Token(string value) => ChainValue("transform-" + value);

}
