namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical positioning, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("inset-be-", Responsive = true)]
public sealed class InsetBlockEndBuilder : FinalClassUtilityBuilder<InsetBlockEndBuilder>
{
    internal InsetBlockEndBuilder()
    {
    }

    internal InsetBlockEndBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>inset-be-0</c>.</summary>
    public InsetBlockEndBuilder Is0 => ChainClass("inset-be-0");

    /// <summary>Adds <c>inset-be-0.5</c>.</summary>
    public InsetBlockEndBuilder Is0_5 => ChainClass("inset-be-0.5");

    /// <summary>Adds <c>inset-be-1</c>.</summary>
    public InsetBlockEndBuilder Is1 => ChainClass("inset-be-1");

    /// <summary>Adds <c>inset-be-1.5</c>.</summary>
    public InsetBlockEndBuilder Is1_5 => ChainClass("inset-be-1.5");

    /// <summary>Adds <c>inset-be-2</c>.</summary>
    public InsetBlockEndBuilder Is2 => ChainClass("inset-be-2");

    /// <summary>Adds <c>inset-be-2.5</c>.</summary>
    public InsetBlockEndBuilder Is2_5 => ChainClass("inset-be-2.5");

    /// <summary>Adds <c>inset-be-3</c>.</summary>
    public InsetBlockEndBuilder Is3 => ChainClass("inset-be-3");

    /// <summary>Adds <c>inset-be-3.5</c>.</summary>
    public InsetBlockEndBuilder Is3_5 => ChainClass("inset-be-3.5");

    /// <summary>Adds <c>inset-be-4</c>.</summary>
    public InsetBlockEndBuilder Is4 => ChainClass("inset-be-4");

    /// <summary>Adds <c>inset-be-5</c>.</summary>
    public InsetBlockEndBuilder Is5 => ChainClass("inset-be-5");

    /// <summary>Adds <c>inset-be-6</c>.</summary>
    public InsetBlockEndBuilder Is6 => ChainClass("inset-be-6");

    /// <summary>Adds <c>inset-be-8</c>.</summary>
    public InsetBlockEndBuilder Is8 => ChainClass("inset-be-8");

    /// <summary>Adds <c>inset-be-10</c>.</summary>
    public InsetBlockEndBuilder Is10 => ChainClass("inset-be-10");

    /// <summary>Adds <c>inset-be-12</c>.</summary>
    public InsetBlockEndBuilder Is12 => ChainClass("inset-be-12");

    /// <summary>Adds <c>inset-be-16</c>.</summary>
    public InsetBlockEndBuilder Is16 => ChainClass("inset-be-16");

    /// <summary>Adds <c>inset-be-20</c>.</summary>
    public InsetBlockEndBuilder Is20 => ChainClass("inset-be-20");

    /// <summary>Adds <c>inset-be-24</c>.</summary>
    public InsetBlockEndBuilder Is24 => ChainClass("inset-be-24");

    /// <summary>Adds <c>inset-be-32</c>.</summary>
    public InsetBlockEndBuilder Is32 => ChainClass("inset-be-32");

    /// <summary>Adds <c>inset-be-40</c>.</summary>
    public InsetBlockEndBuilder Is40 => ChainClass("inset-be-40");

    /// <summary>Adds <c>inset-be-48</c>.</summary>
    public InsetBlockEndBuilder Is48 => ChainClass("inset-be-48");

    /// <summary>Adds <c>inset-be-64</c>.</summary>
    public InsetBlockEndBuilder Is64 => ChainClass("inset-be-64");

    /// <summary>Adds <c>inset-be-96</c>.</summary>
    public InsetBlockEndBuilder Is96 => ChainClass("inset-be-96");

    /// <summary>Adds <c>inset-be-auto</c>.</summary>
    public InsetBlockEndBuilder Auto => ChainClass("inset-be-auto");

    /// <summary>Adds <c>inset-be-px</c>.</summary>
    public InsetBlockEndBuilder Px => ChainClass("inset-be-px");

    /// <summary>Adds <c>inset-be-1/2</c>.</summary>
    public InsetBlockEndBuilder Half => ChainClass("inset-be-1/2");

    /// <summary>Adds <c>inset-be-full</c>.</summary>
    public InsetBlockEndBuilder Full => ChainClass("inset-be-full");

    /// <summary>Adds <c>-inset-be-1/2</c>.</summary>
    public InsetBlockEndBuilder NegativeHalf => ChainClass("-inset-be-1/2");

    /// <summary>Adds <c>-inset-be-full</c>.</summary>
    public InsetBlockEndBuilder NegativeFull => ChainClass("-inset-be-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public InsetBlockEndBuilder Token(string value) => ChainClass(UtilityToken.WithSignedPrefix(value, "inset-be-"));
}
