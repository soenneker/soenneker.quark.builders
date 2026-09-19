namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for mask repetition, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-", Responsive = true)]
public sealed class MaskRepeatBuilder : FinalClassUtilityBuilder<MaskRepeatBuilder>
{
    internal MaskRepeatBuilder()
    {
    }

    internal MaskRepeatBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-repeat</c>.</summary>
    public MaskRepeatBuilder Repeat => ChainClass("mask-repeat");

    /// <summary>Adds <c>mask-no-repeat</c>.</summary>
    public MaskRepeatBuilder NoRepeat => ChainClass("mask-no-repeat");

    /// <summary>Adds <c>mask-repeat-x</c>.</summary>
    public MaskRepeatBuilder RepeatX => ChainClass("mask-repeat-x");

    /// <summary>Adds <c>mask-repeat-y</c>.</summary>
    public MaskRepeatBuilder RepeatY => ChainClass("mask-repeat-y");

    /// <summary>Adds <c>mask-repeat-round</c>.</summary>
    public MaskRepeatBuilder Round => ChainClass("mask-repeat-round");

    /// <summary>Adds <c>mask-repeat-space</c>.</summary>
    public MaskRepeatBuilder Space => ChainClass("mask-repeat-space");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskRepeatBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-"));
}
