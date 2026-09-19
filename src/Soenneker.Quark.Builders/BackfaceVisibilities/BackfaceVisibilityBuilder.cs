namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backface visibility, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backface-", Responsive = true)]
public sealed class BackfaceVisibilityBuilder : FinalClassUtilityBuilder<BackfaceVisibilityBuilder>
{
    internal BackfaceVisibilityBuilder()
    {
    }

    internal BackfaceVisibilityBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backface-visible</c>.</summary>
    public BackfaceVisibilityBuilder Visible => ChainClass("backface-visible");

    /// <summary>Adds <c>backface-hidden</c>.</summary>
    public BackfaceVisibilityBuilder Hidden => ChainClass("backface-hidden");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackfaceVisibilityBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backface-"));
}
