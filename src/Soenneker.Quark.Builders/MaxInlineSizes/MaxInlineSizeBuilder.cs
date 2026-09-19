namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical maxinlinesize, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("max-inline-", Responsive = true)]
public sealed class MaxInlineSizeBuilder : FinalClassUtilityBuilder<MaxInlineSizeBuilder>
{
    internal MaxInlineSizeBuilder()
    {
    }

    internal MaxInlineSizeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>max-inline-0</c>.</summary>
    public MaxInlineSizeBuilder Is0 => ChainClass("max-inline-0");

    /// <summary>Adds <c>max-inline-0.5</c>.</summary>
    public MaxInlineSizeBuilder Is0_5 => ChainClass("max-inline-0.5");

    /// <summary>Adds <c>max-inline-1</c>.</summary>
    public MaxInlineSizeBuilder Is1 => ChainClass("max-inline-1");

    /// <summary>Adds <c>max-inline-1.5</c>.</summary>
    public MaxInlineSizeBuilder Is1_5 => ChainClass("max-inline-1.5");

    /// <summary>Adds <c>max-inline-2</c>.</summary>
    public MaxInlineSizeBuilder Is2 => ChainClass("max-inline-2");

    /// <summary>Adds <c>max-inline-2.5</c>.</summary>
    public MaxInlineSizeBuilder Is2_5 => ChainClass("max-inline-2.5");

    /// <summary>Adds <c>max-inline-3</c>.</summary>
    public MaxInlineSizeBuilder Is3 => ChainClass("max-inline-3");

    /// <summary>Adds <c>max-inline-3.5</c>.</summary>
    public MaxInlineSizeBuilder Is3_5 => ChainClass("max-inline-3.5");

    /// <summary>Adds <c>max-inline-4</c>.</summary>
    public MaxInlineSizeBuilder Is4 => ChainClass("max-inline-4");

    /// <summary>Adds <c>max-inline-5</c>.</summary>
    public MaxInlineSizeBuilder Is5 => ChainClass("max-inline-5");

    /// <summary>Adds <c>max-inline-6</c>.</summary>
    public MaxInlineSizeBuilder Is6 => ChainClass("max-inline-6");

    /// <summary>Adds <c>max-inline-8</c>.</summary>
    public MaxInlineSizeBuilder Is8 => ChainClass("max-inline-8");

    /// <summary>Adds <c>max-inline-10</c>.</summary>
    public MaxInlineSizeBuilder Is10 => ChainClass("max-inline-10");

    /// <summary>Adds <c>max-inline-12</c>.</summary>
    public MaxInlineSizeBuilder Is12 => ChainClass("max-inline-12");

    /// <summary>Adds <c>max-inline-16</c>.</summary>
    public MaxInlineSizeBuilder Is16 => ChainClass("max-inline-16");

    /// <summary>Adds <c>max-inline-20</c>.</summary>
    public MaxInlineSizeBuilder Is20 => ChainClass("max-inline-20");

    /// <summary>Adds <c>max-inline-24</c>.</summary>
    public MaxInlineSizeBuilder Is24 => ChainClass("max-inline-24");

    /// <summary>Adds <c>max-inline-32</c>.</summary>
    public MaxInlineSizeBuilder Is32 => ChainClass("max-inline-32");

    /// <summary>Adds <c>max-inline-40</c>.</summary>
    public MaxInlineSizeBuilder Is40 => ChainClass("max-inline-40");

    /// <summary>Adds <c>max-inline-48</c>.</summary>
    public MaxInlineSizeBuilder Is48 => ChainClass("max-inline-48");

    /// <summary>Adds <c>max-inline-64</c>.</summary>
    public MaxInlineSizeBuilder Is64 => ChainClass("max-inline-64");

    /// <summary>Adds <c>max-inline-96</c>.</summary>
    public MaxInlineSizeBuilder Is96 => ChainClass("max-inline-96");

    /// <summary>Adds <c>max-inline-px</c>.</summary>
    public MaxInlineSizeBuilder IsPx => ChainClass("max-inline-px");

    /// <summary>Adds <c>max-inline-full</c>.</summary>
    public MaxInlineSizeBuilder IsFull => ChainClass("max-inline-full");

    /// <summary>Adds <c>max-inline-screen</c>.</summary>
    public MaxInlineSizeBuilder IsScreen => ChainClass("max-inline-screen");

    /// <summary>Adds <c>max-inline-min</c>.</summary>
    public MaxInlineSizeBuilder IsMin => ChainClass("max-inline-min");

    /// <summary>Adds <c>max-inline-max</c>.</summary>
    public MaxInlineSizeBuilder IsMax => ChainClass("max-inline-max");

    /// <summary>Adds <c>max-inline-fit</c>.</summary>
    public MaxInlineSizeBuilder IsFit => ChainClass("max-inline-fit");

    /// <summary>Adds <c>max-inline-1/2</c>.</summary>
    public MaxInlineSizeBuilder Is1of2 => ChainClass("max-inline-1/2");

    /// <summary>Adds <c>max-inline-1/3</c>.</summary>
    public MaxInlineSizeBuilder Is1of3 => ChainClass("max-inline-1/3");

    /// <summary>Adds <c>max-inline-2/3</c>.</summary>
    public MaxInlineSizeBuilder Is2of3 => ChainClass("max-inline-2/3");

    /// <summary>Adds <c>max-inline-1/4</c>.</summary>
    public MaxInlineSizeBuilder Is1of4 => ChainClass("max-inline-1/4");

    /// <summary>Adds <c>max-inline-3/4</c>.</summary>
    public MaxInlineSizeBuilder Is3of4 => ChainClass("max-inline-3/4");

    /// <summary>Adds <c>max-inline-dvw</c>.</summary>
    public MaxInlineSizeBuilder DynamicViewport => ChainClass("max-inline-dvw");

    /// <summary>Adds <c>max-inline-svw</c>.</summary>
    public MaxInlineSizeBuilder SmallViewport => ChainClass("max-inline-svw");

    /// <summary>Adds <c>max-inline-lvw</c>.</summary>
    public MaxInlineSizeBuilder LargeViewport => ChainClass("max-inline-lvw");

    /// <summary>Adds <c>max-inline-none</c>.</summary>
    public MaxInlineSizeBuilder None => ChainClass("max-inline-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaxInlineSizeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "max-inline-"));
}
