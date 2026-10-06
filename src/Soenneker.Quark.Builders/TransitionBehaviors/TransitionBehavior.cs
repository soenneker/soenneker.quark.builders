namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for discrete-property transitions.
/// </summary>
[TailwindModifiers(typeof(TransitionBehaviorBuilder))]
public static partial class TransitionBehavior
{
    /// <summary>Adds <c>transition-normal</c>.</summary>
    public static TransitionBehaviorBuilder Normal => new("transition-normal");

    /// <summary>Adds <c>transition-discrete</c>.</summary>
    public static TransitionBehaviorBuilder Discrete => new("transition-discrete");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static TransitionBehaviorBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "transition-"));
}
