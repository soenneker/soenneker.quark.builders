namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical positioning, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("inset-e-", Responsive = true)]
public sealed class InsetEndBuilder : FinalClassUtilityBuilder<InsetEndBuilder>
{
    internal InsetEndBuilder()
    {
    }

    internal InsetEndBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>inset-e-0</c>.</summary>
    public InsetEndBuilder Is0 => ChainClass("inset-e-0");

    /// <summary>Adds <c>inset-e-0.5</c>.</summary>
    public InsetEndBuilder Is0_5 => ChainClass("inset-e-0.5");

    /// <summary>Adds <c>inset-e-1</c>.</summary>
    public InsetEndBuilder Is1 => ChainClass("inset-e-1");

    /// <summary>Adds <c>inset-e-1.5</c>.</summary>
    public InsetEndBuilder Is1_5 => ChainClass("inset-e-1.5");

    /// <summary>Adds <c>inset-e-2</c>.</summary>
    public InsetEndBuilder Is2 => ChainClass("inset-e-2");

    /// <summary>Adds <c>inset-e-2.5</c>.</summary>
    public InsetEndBuilder Is2_5 => ChainClass("inset-e-2.5");

    /// <summary>Adds <c>inset-e-3</c>.</summary>
    public InsetEndBuilder Is3 => ChainClass("inset-e-3");

    /// <summary>Adds <c>inset-e-3.5</c>.</summary>
    public InsetEndBuilder Is3_5 => ChainClass("inset-e-3.5");

    /// <summary>Adds <c>inset-e-4</c>.</summary>
    public InsetEndBuilder Is4 => ChainClass("inset-e-4");

    /// <summary>Adds <c>inset-e-5</c>.</summary>
    public InsetEndBuilder Is5 => ChainClass("inset-e-5");

    /// <summary>Adds <c>inset-e-6</c>.</summary>
    public InsetEndBuilder Is6 => ChainClass("inset-e-6");

    /// <summary>Adds <c>inset-e-8</c>.</summary>
    public InsetEndBuilder Is8 => ChainClass("inset-e-8");

    /// <summary>Adds <c>inset-e-10</c>.</summary>
    public InsetEndBuilder Is10 => ChainClass("inset-e-10");

    /// <summary>Adds <c>inset-e-12</c>.</summary>
    public InsetEndBuilder Is12 => ChainClass("inset-e-12");

    /// <summary>Adds <c>inset-e-16</c>.</summary>
    public InsetEndBuilder Is16 => ChainClass("inset-e-16");

    /// <summary>Adds <c>inset-e-20</c>.</summary>
    public InsetEndBuilder Is20 => ChainClass("inset-e-20");

    /// <summary>Adds <c>inset-e-24</c>.</summary>
    public InsetEndBuilder Is24 => ChainClass("inset-e-24");

    /// <summary>Adds <c>inset-e-32</c>.</summary>
    public InsetEndBuilder Is32 => ChainClass("inset-e-32");

    /// <summary>Adds <c>inset-e-40</c>.</summary>
    public InsetEndBuilder Is40 => ChainClass("inset-e-40");

    /// <summary>Adds <c>inset-e-48</c>.</summary>
    public InsetEndBuilder Is48 => ChainClass("inset-e-48");

    /// <summary>Adds <c>inset-e-64</c>.</summary>
    public InsetEndBuilder Is64 => ChainClass("inset-e-64");

    /// <summary>Adds <c>inset-e-96</c>.</summary>
    public InsetEndBuilder Is96 => ChainClass("inset-e-96");

    /// <summary>Adds <c>inset-e-auto</c>.</summary>
    public InsetEndBuilder Auto => ChainClass("inset-e-auto");

    /// <summary>Adds <c>inset-e-px</c>.</summary>
    public InsetEndBuilder Px => ChainClass("inset-e-px");

    /// <summary>Adds <c>inset-e-1/2</c>.</summary>
    public InsetEndBuilder Half => ChainClass("inset-e-1/2");

    /// <summary>Adds <c>inset-e-full</c>.</summary>
    public InsetEndBuilder Full => ChainClass("inset-e-full");

    /// <summary>Adds <c>-inset-e-1/2</c>.</summary>
    public InsetEndBuilder NegativeHalf => ChainClass("-inset-e-1/2");

    /// <summary>Adds <c>-inset-e-full</c>.</summary>
    public InsetEndBuilder NegativeFull => ChainClass("-inset-e-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public InsetEndBuilder Token(string value) => ChainClass(UtilityToken.WithSignedPrefix(value, "inset-e-"));
}
