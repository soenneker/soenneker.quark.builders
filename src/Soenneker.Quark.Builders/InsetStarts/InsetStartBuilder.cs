namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical positioning, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("inset-s-", Responsive = true)]
public sealed class InsetStartBuilder : FinalClassUtilityBuilder<InsetStartBuilder>
{
    internal InsetStartBuilder()
    {
    }

    internal InsetStartBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>inset-s-0</c>.</summary>
    public InsetStartBuilder Is0 => ChainClass("inset-s-0");

    /// <summary>Adds <c>inset-s-0.5</c>.</summary>
    public InsetStartBuilder Is0_5 => ChainClass("inset-s-0.5");

    /// <summary>Adds <c>inset-s-1</c>.</summary>
    public InsetStartBuilder Is1 => ChainClass("inset-s-1");

    /// <summary>Adds <c>inset-s-1.5</c>.</summary>
    public InsetStartBuilder Is1_5 => ChainClass("inset-s-1.5");

    /// <summary>Adds <c>inset-s-2</c>.</summary>
    public InsetStartBuilder Is2 => ChainClass("inset-s-2");

    /// <summary>Adds <c>inset-s-2.5</c>.</summary>
    public InsetStartBuilder Is2_5 => ChainClass("inset-s-2.5");

    /// <summary>Adds <c>inset-s-3</c>.</summary>
    public InsetStartBuilder Is3 => ChainClass("inset-s-3");

    /// <summary>Adds <c>inset-s-3.5</c>.</summary>
    public InsetStartBuilder Is3_5 => ChainClass("inset-s-3.5");

    /// <summary>Adds <c>inset-s-4</c>.</summary>
    public InsetStartBuilder Is4 => ChainClass("inset-s-4");

    /// <summary>Adds <c>inset-s-5</c>.</summary>
    public InsetStartBuilder Is5 => ChainClass("inset-s-5");

    /// <summary>Adds <c>inset-s-6</c>.</summary>
    public InsetStartBuilder Is6 => ChainClass("inset-s-6");

    /// <summary>Adds <c>inset-s-8</c>.</summary>
    public InsetStartBuilder Is8 => ChainClass("inset-s-8");

    /// <summary>Adds <c>inset-s-10</c>.</summary>
    public InsetStartBuilder Is10 => ChainClass("inset-s-10");

    /// <summary>Adds <c>inset-s-12</c>.</summary>
    public InsetStartBuilder Is12 => ChainClass("inset-s-12");

    /// <summary>Adds <c>inset-s-16</c>.</summary>
    public InsetStartBuilder Is16 => ChainClass("inset-s-16");

    /// <summary>Adds <c>inset-s-20</c>.</summary>
    public InsetStartBuilder Is20 => ChainClass("inset-s-20");

    /// <summary>Adds <c>inset-s-24</c>.</summary>
    public InsetStartBuilder Is24 => ChainClass("inset-s-24");

    /// <summary>Adds <c>inset-s-32</c>.</summary>
    public InsetStartBuilder Is32 => ChainClass("inset-s-32");

    /// <summary>Adds <c>inset-s-40</c>.</summary>
    public InsetStartBuilder Is40 => ChainClass("inset-s-40");

    /// <summary>Adds <c>inset-s-48</c>.</summary>
    public InsetStartBuilder Is48 => ChainClass("inset-s-48");

    /// <summary>Adds <c>inset-s-64</c>.</summary>
    public InsetStartBuilder Is64 => ChainClass("inset-s-64");

    /// <summary>Adds <c>inset-s-96</c>.</summary>
    public InsetStartBuilder Is96 => ChainClass("inset-s-96");

    /// <summary>Adds <c>inset-s-auto</c>.</summary>
    public InsetStartBuilder Auto => ChainClass("inset-s-auto");

    /// <summary>Adds <c>inset-s-px</c>.</summary>
    public InsetStartBuilder Px => ChainClass("inset-s-px");

    /// <summary>Adds <c>inset-s-1/2</c>.</summary>
    public InsetStartBuilder Half => ChainClass("inset-s-1/2");

    /// <summary>Adds <c>inset-s-full</c>.</summary>
    public InsetStartBuilder Full => ChainClass("inset-s-full");

    /// <summary>Adds <c>-inset-s-1/2</c>.</summary>
    public InsetStartBuilder NegativeHalf => ChainClass("-inset-s-1/2");

    /// <summary>Adds <c>-inset-s-full</c>.</summary>
    public InsetStartBuilder NegativeFull => ChainClass("-inset-s-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public InsetStartBuilder Token(string value) => ChainClass(UtilityToken.WithSignedPrefix(value, "inset-s-"));
}
