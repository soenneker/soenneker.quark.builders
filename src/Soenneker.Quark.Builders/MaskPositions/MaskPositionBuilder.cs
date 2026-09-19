namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for mask positioning, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-", Responsive = true)]
public sealed class MaskPositionBuilder : FinalClassUtilityBuilder<MaskPositionBuilder>
{
    internal MaskPositionBuilder()
    {
    }

    internal MaskPositionBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-center</c>.</summary>
    public MaskPositionBuilder Center => ChainClass("mask-center");

    /// <summary>Adds <c>mask-top</c>.</summary>
    public MaskPositionBuilder Top => ChainClass("mask-top");

    /// <summary>Adds <c>mask-top-right</c>.</summary>
    public MaskPositionBuilder TopRight => ChainClass("mask-top-right");

    /// <summary>Adds <c>mask-right</c>.</summary>
    public MaskPositionBuilder Right => ChainClass("mask-right");

    /// <summary>Adds <c>mask-bottom-right</c>.</summary>
    public MaskPositionBuilder BottomRight => ChainClass("mask-bottom-right");

    /// <summary>Adds <c>mask-bottom</c>.</summary>
    public MaskPositionBuilder Bottom => ChainClass("mask-bottom");

    /// <summary>Adds <c>mask-bottom-left</c>.</summary>
    public MaskPositionBuilder BottomLeft => ChainClass("mask-bottom-left");

    /// <summary>Adds <c>mask-left</c>.</summary>
    public MaskPositionBuilder Left => ChainClass("mask-left");

    /// <summary>Adds <c>mask-top-left</c>.</summary>
    public MaskPositionBuilder TopLeft => ChainClass("mask-top-left");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskPositionBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-"));
}
