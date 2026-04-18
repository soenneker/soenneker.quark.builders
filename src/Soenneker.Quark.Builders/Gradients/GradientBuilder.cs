namespace Soenneker.Quark;

[TailwindPrefix("bg-gradient-to-", Responsive = true)]
public sealed class GradientBuilder : FinalClassUtilityBuilder<GradientBuilder>
{
    internal GradientBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    public GradientBuilder To(string value) => ChainClass($"bg-gradient-to-{value}");
    public GradientBuilder From(string value) => ChainClass($"from-{value}");
    public GradientBuilder Via(string value) => ChainClass($"via-{value}");
    public GradientBuilder End(string value) => ChainClass($"to-{value}");

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint. In Tailwind’s mobile‑first model, unprefixed utilities apply from 0px unless a larger breakpoint overrides them.
    /// </summary>
    public GradientBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public GradientBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public GradientBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public GradientBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public GradientBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public GradientBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
