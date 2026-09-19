namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for text shadows, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("text-shadow-", Responsive = true)]
public sealed class TextShadowBuilder : FinalClassUtilityBuilder<TextShadowBuilder>
{
    internal TextShadowBuilder()
    {
    }

    internal TextShadowBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>text-shadow-none</c>.</summary>
    public TextShadowBuilder None => ChainClass("text-shadow-none");

    /// <summary>Adds <c>text-shadow-2xs</c>.</summary>
    public TextShadowBuilder TwoXs => ChainClass("text-shadow-2xs");

    /// <summary>Adds <c>text-shadow-xs</c>.</summary>
    public TextShadowBuilder Xs => ChainClass("text-shadow-xs");

    /// <summary>Adds <c>text-shadow-sm</c>.</summary>
    public TextShadowBuilder Sm => ChainClass("text-shadow-sm");

    /// <summary>Adds <c>text-shadow-md</c>.</summary>
    public TextShadowBuilder Md => ChainClass("text-shadow-md");

    /// <summary>Adds <c>text-shadow-lg</c>.</summary>
    public TextShadowBuilder Lg => ChainClass("text-shadow-lg");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public TextShadowBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "text-shadow-"));
}
