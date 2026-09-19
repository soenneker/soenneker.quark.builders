namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for inset ring width, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("inset-ring-", Responsive = true)]
public sealed class InsetRingBuilder : FinalClassUtilityBuilder<InsetRingBuilder>
{
    internal InsetRingBuilder()
    {
    }

    internal InsetRingBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>inset-ring-0</c>.</summary>
    public InsetRingBuilder Is0 => ChainClass("inset-ring-0");

    /// <summary>Adds <c>inset-ring-1</c>.</summary>
    public InsetRingBuilder Is1 => ChainClass("inset-ring-1");

    /// <summary>Adds <c>inset-ring-2</c>.</summary>
    public InsetRingBuilder Is2 => ChainClass("inset-ring-2");

    /// <summary>Adds <c>inset-ring-4</c>.</summary>
    public InsetRingBuilder Is4 => ChainClass("inset-ring-4");

    /// <summary>Adds <c>inset-ring-8</c>.</summary>
    public InsetRingBuilder Is8 => ChainClass("inset-ring-8");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public InsetRingBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "inset-ring-"));
}
