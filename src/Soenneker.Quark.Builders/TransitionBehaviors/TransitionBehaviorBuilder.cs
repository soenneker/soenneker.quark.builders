namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for discrete-property transitions, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("transition-", Responsive = true)]
public sealed class TransitionBehaviorBuilder : FinalClassUtilityBuilder<TransitionBehaviorBuilder>
{
    internal TransitionBehaviorBuilder()
    {
    }

    internal TransitionBehaviorBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>transition-normal</c>.</summary>
    public TransitionBehaviorBuilder Normal => ChainClass("transition-normal");

    /// <summary>Adds <c>transition-discrete</c>.</summary>
    public TransitionBehaviorBuilder Discrete => ChainClass("transition-discrete");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>The current builder.</returns>
    public TransitionBehaviorBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "transition-"));
}
