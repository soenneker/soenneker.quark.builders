namespace Soenneker.Quark;

/// <summary>
/// Tailwind transform utility builder. Tailwind: transform-none, transform-gpu, transform-cpu.
/// </summary>
[TailwindPrefix("transform-", Responsive = true)]
public sealed class TransformBuilder : FinalClassUtilityBuilder<TransformBuilder>
{
    internal TransformBuilder()
    {
    }

    internal TransformBuilder(TransformEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal TransformBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Sets the transform to none.
    /// </summary>
    public TransformBuilder None => ChainClass(TransformEnum.NoneValue);
    /// <summary>
    /// Uses the GPU transform utility.
    /// </summary>
    public TransformBuilder Gpu => ChainClass(TransformEnum.GpuValue);
    /// <summary>
    /// Uses the CPU transform utility.
    /// </summary>
    public TransformBuilder Cpu => ChainClass(TransformEnum.CpuValue);

    /// <summary>
    /// Applies the transform value suffix after the `transform-` prefix, including arbitrary values.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public TransformBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "transform-"));

}
