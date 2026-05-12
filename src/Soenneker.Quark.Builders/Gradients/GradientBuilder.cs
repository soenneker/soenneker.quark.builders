namespace Soenneker.Quark;

[TailwindPrefix("bg-gradient-to-", Responsive = true)]
public sealed class GradientBuilder : FinalClassUtilityBuilder<GradientBuilder>
{
    internal GradientBuilder()
    {
    }

    internal GradientBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    public GradientBuilder To(string value) => ChainClass($"bg-gradient-to-{value}");
    public GradientBuilder From(string value) => ChainClass($"from-{value}");
    public GradientBuilder Via(string value) => ChainClass($"via-{value}");
    public GradientBuilder End(string value) => ChainClass($"to-{value}");
}
