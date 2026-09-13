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
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public TransformBuilder Token(string value) => ChainValue(UtilityToken.WithPrefix(value, "transform-"));

}
