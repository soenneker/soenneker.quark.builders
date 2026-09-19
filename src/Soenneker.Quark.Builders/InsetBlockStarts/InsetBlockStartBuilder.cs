namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical positioning, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("inset-bs-", Responsive = true)]
public sealed class InsetBlockStartBuilder : FinalClassUtilityBuilder<InsetBlockStartBuilder>
{
    internal InsetBlockStartBuilder()
    {
    }

    internal InsetBlockStartBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>inset-bs-0</c>.</summary>
    public InsetBlockStartBuilder Is0 => ChainClass("inset-bs-0");

    /// <summary>Adds <c>inset-bs-0.5</c>.</summary>
    public InsetBlockStartBuilder Is0_5 => ChainClass("inset-bs-0.5");

    /// <summary>Adds <c>inset-bs-1</c>.</summary>
    public InsetBlockStartBuilder Is1 => ChainClass("inset-bs-1");

    /// <summary>Adds <c>inset-bs-1.5</c>.</summary>
    public InsetBlockStartBuilder Is1_5 => ChainClass("inset-bs-1.5");

    /// <summary>Adds <c>inset-bs-2</c>.</summary>
    public InsetBlockStartBuilder Is2 => ChainClass("inset-bs-2");

    /// <summary>Adds <c>inset-bs-2.5</c>.</summary>
    public InsetBlockStartBuilder Is2_5 => ChainClass("inset-bs-2.5");

    /// <summary>Adds <c>inset-bs-3</c>.</summary>
    public InsetBlockStartBuilder Is3 => ChainClass("inset-bs-3");

    /// <summary>Adds <c>inset-bs-3.5</c>.</summary>
    public InsetBlockStartBuilder Is3_5 => ChainClass("inset-bs-3.5");

    /// <summary>Adds <c>inset-bs-4</c>.</summary>
    public InsetBlockStartBuilder Is4 => ChainClass("inset-bs-4");

    /// <summary>Adds <c>inset-bs-5</c>.</summary>
    public InsetBlockStartBuilder Is5 => ChainClass("inset-bs-5");

    /// <summary>Adds <c>inset-bs-6</c>.</summary>
    public InsetBlockStartBuilder Is6 => ChainClass("inset-bs-6");

    /// <summary>Adds <c>inset-bs-8</c>.</summary>
    public InsetBlockStartBuilder Is8 => ChainClass("inset-bs-8");

    /// <summary>Adds <c>inset-bs-10</c>.</summary>
    public InsetBlockStartBuilder Is10 => ChainClass("inset-bs-10");

    /// <summary>Adds <c>inset-bs-12</c>.</summary>
    public InsetBlockStartBuilder Is12 => ChainClass("inset-bs-12");

    /// <summary>Adds <c>inset-bs-16</c>.</summary>
    public InsetBlockStartBuilder Is16 => ChainClass("inset-bs-16");

    /// <summary>Adds <c>inset-bs-20</c>.</summary>
    public InsetBlockStartBuilder Is20 => ChainClass("inset-bs-20");

    /// <summary>Adds <c>inset-bs-24</c>.</summary>
    public InsetBlockStartBuilder Is24 => ChainClass("inset-bs-24");

    /// <summary>Adds <c>inset-bs-32</c>.</summary>
    public InsetBlockStartBuilder Is32 => ChainClass("inset-bs-32");

    /// <summary>Adds <c>inset-bs-40</c>.</summary>
    public InsetBlockStartBuilder Is40 => ChainClass("inset-bs-40");

    /// <summary>Adds <c>inset-bs-48</c>.</summary>
    public InsetBlockStartBuilder Is48 => ChainClass("inset-bs-48");

    /// <summary>Adds <c>inset-bs-64</c>.</summary>
    public InsetBlockStartBuilder Is64 => ChainClass("inset-bs-64");

    /// <summary>Adds <c>inset-bs-96</c>.</summary>
    public InsetBlockStartBuilder Is96 => ChainClass("inset-bs-96");

    /// <summary>Adds <c>inset-bs-auto</c>.</summary>
    public InsetBlockStartBuilder Auto => ChainClass("inset-bs-auto");

    /// <summary>Adds <c>inset-bs-px</c>.</summary>
    public InsetBlockStartBuilder Px => ChainClass("inset-bs-px");

    /// <summary>Adds <c>inset-bs-1/2</c>.</summary>
    public InsetBlockStartBuilder Half => ChainClass("inset-bs-1/2");

    /// <summary>Adds <c>inset-bs-full</c>.</summary>
    public InsetBlockStartBuilder Full => ChainClass("inset-bs-full");

    /// <summary>Adds <c>-inset-bs-1/2</c>.</summary>
    public InsetBlockStartBuilder NegativeHalf => ChainClass("-inset-bs-1/2");

    /// <summary>Adds <c>-inset-bs-full</c>.</summary>
    public InsetBlockStartBuilder NegativeFull => ChainClass("-inset-bs-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public InsetBlockStartBuilder Token(string value) => ChainClass(UtilityToken.WithSignedPrefix(value, "inset-bs-"));
}
