namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical inlinesize, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("inline-", Responsive = true)]
public sealed class InlineSizeBuilder : FinalClassUtilityBuilder<InlineSizeBuilder>
{
    internal InlineSizeBuilder()
    {
    }

    internal InlineSizeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>inline-0</c>.</summary>
    public InlineSizeBuilder Is0 => ChainClass("inline-0");

    /// <summary>Adds <c>inline-0.5</c>.</summary>
    public InlineSizeBuilder Is0_5 => ChainClass("inline-0.5");

    /// <summary>Adds <c>inline-1</c>.</summary>
    public InlineSizeBuilder Is1 => ChainClass("inline-1");

    /// <summary>Adds <c>inline-1.5</c>.</summary>
    public InlineSizeBuilder Is1_5 => ChainClass("inline-1.5");

    /// <summary>Adds <c>inline-2</c>.</summary>
    public InlineSizeBuilder Is2 => ChainClass("inline-2");

    /// <summary>Adds <c>inline-2.5</c>.</summary>
    public InlineSizeBuilder Is2_5 => ChainClass("inline-2.5");

    /// <summary>Adds <c>inline-3</c>.</summary>
    public InlineSizeBuilder Is3 => ChainClass("inline-3");

    /// <summary>Adds <c>inline-3.5</c>.</summary>
    public InlineSizeBuilder Is3_5 => ChainClass("inline-3.5");

    /// <summary>Adds <c>inline-4</c>.</summary>
    public InlineSizeBuilder Is4 => ChainClass("inline-4");

    /// <summary>Adds <c>inline-5</c>.</summary>
    public InlineSizeBuilder Is5 => ChainClass("inline-5");

    /// <summary>Adds <c>inline-6</c>.</summary>
    public InlineSizeBuilder Is6 => ChainClass("inline-6");

    /// <summary>Adds <c>inline-8</c>.</summary>
    public InlineSizeBuilder Is8 => ChainClass("inline-8");

    /// <summary>Adds <c>inline-10</c>.</summary>
    public InlineSizeBuilder Is10 => ChainClass("inline-10");

    /// <summary>Adds <c>inline-12</c>.</summary>
    public InlineSizeBuilder Is12 => ChainClass("inline-12");

    /// <summary>Adds <c>inline-16</c>.</summary>
    public InlineSizeBuilder Is16 => ChainClass("inline-16");

    /// <summary>Adds <c>inline-20</c>.</summary>
    public InlineSizeBuilder Is20 => ChainClass("inline-20");

    /// <summary>Adds <c>inline-24</c>.</summary>
    public InlineSizeBuilder Is24 => ChainClass("inline-24");

    /// <summary>Adds <c>inline-32</c>.</summary>
    public InlineSizeBuilder Is32 => ChainClass("inline-32");

    /// <summary>Adds <c>inline-40</c>.</summary>
    public InlineSizeBuilder Is40 => ChainClass("inline-40");

    /// <summary>Adds <c>inline-48</c>.</summary>
    public InlineSizeBuilder Is48 => ChainClass("inline-48");

    /// <summary>Adds <c>inline-64</c>.</summary>
    public InlineSizeBuilder Is64 => ChainClass("inline-64");

    /// <summary>Adds <c>inline-96</c>.</summary>
    public InlineSizeBuilder Is96 => ChainClass("inline-96");

    /// <summary>Adds <c>inline-auto</c>.</summary>
    public InlineSizeBuilder Auto => ChainClass("inline-auto");

    /// <summary>Adds <c>inline-px</c>.</summary>
    public InlineSizeBuilder IsPx => ChainClass("inline-px");

    /// <summary>Adds <c>inline-full</c>.</summary>
    public InlineSizeBuilder IsFull => ChainClass("inline-full");

    /// <summary>Adds <c>inline-screen</c>.</summary>
    public InlineSizeBuilder IsScreen => ChainClass("inline-screen");

    /// <summary>Adds <c>inline-min</c>.</summary>
    public InlineSizeBuilder IsMin => ChainClass("inline-min");

    /// <summary>Adds <c>inline-max</c>.</summary>
    public InlineSizeBuilder IsMax => ChainClass("inline-max");

    /// <summary>Adds <c>inline-fit</c>.</summary>
    public InlineSizeBuilder IsFit => ChainClass("inline-fit");

    /// <summary>Adds <c>inline-1/2</c>.</summary>
    public InlineSizeBuilder Is1of2 => ChainClass("inline-1/2");

    /// <summary>Adds <c>inline-1/3</c>.</summary>
    public InlineSizeBuilder Is1of3 => ChainClass("inline-1/3");

    /// <summary>Adds <c>inline-2/3</c>.</summary>
    public InlineSizeBuilder Is2of3 => ChainClass("inline-2/3");

    /// <summary>Adds <c>inline-1/4</c>.</summary>
    public InlineSizeBuilder Is1of4 => ChainClass("inline-1/4");

    /// <summary>Adds <c>inline-3/4</c>.</summary>
    public InlineSizeBuilder Is3of4 => ChainClass("inline-3/4");

    /// <summary>Adds <c>inline-dvw</c>.</summary>
    public InlineSizeBuilder DynamicViewport => ChainClass("inline-dvw");

    /// <summary>Adds <c>inline-svw</c>.</summary>
    public InlineSizeBuilder SmallViewport => ChainClass("inline-svw");

    /// <summary>Adds <c>inline-lvw</c>.</summary>
    public InlineSizeBuilder LargeViewport => ChainClass("inline-lvw");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public InlineSizeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "inline-"));
}
