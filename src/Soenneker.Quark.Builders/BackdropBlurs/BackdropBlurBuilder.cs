namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop blur filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-blur-", Responsive = true)]
public sealed class BackdropBlurBuilder : FinalClassUtilityBuilder<BackdropBlurBuilder>
{
    internal BackdropBlurBuilder()
    {
    }

    internal BackdropBlurBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-blur-none</c>.</summary>
    public BackdropBlurBuilder None => ChainClass("backdrop-blur-none");

    /// <summary>Adds <c>backdrop-blur-xs</c>.</summary>
    public BackdropBlurBuilder Xs => ChainClass("backdrop-blur-xs");

    /// <summary>Adds <c>backdrop-blur-sm</c>.</summary>
    public BackdropBlurBuilder Sm => ChainClass("backdrop-blur-sm");

    /// <summary>Adds <c>backdrop-blur-md</c>.</summary>
    public BackdropBlurBuilder Md => ChainClass("backdrop-blur-md");

    /// <summary>Adds <c>backdrop-blur-lg</c>.</summary>
    public BackdropBlurBuilder Lg => ChainClass("backdrop-blur-lg");

    /// <summary>Adds <c>backdrop-blur-xl</c>.</summary>
    public BackdropBlurBuilder Xl => ChainClass("backdrop-blur-xl");

    /// <summary>Adds <c>backdrop-blur-2xl</c>.</summary>
    public BackdropBlurBuilder TwoXl => ChainClass("backdrop-blur-2xl");

    /// <summary>Adds <c>backdrop-blur-3xl</c>.</summary>
    public BackdropBlurBuilder ThreeXl => ChainClass("backdrop-blur-3xl");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropBlurBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-blur-"));
}
