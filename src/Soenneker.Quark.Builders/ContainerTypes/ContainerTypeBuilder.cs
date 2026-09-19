namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for query container declarations, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("@container", Responsive = true)]
public sealed class ContainerTypeBuilder : FinalClassUtilityBuilder<ContainerTypeBuilder>
{
    internal ContainerTypeBuilder()
    {
    }

    internal ContainerTypeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>@container</c>.</summary>
    public ContainerTypeBuilder InlineSize => ChainClass("@container");

    /// <summary>Adds <c>@container-size</c>.</summary>
    public ContainerTypeBuilder Size => ChainClass("@container-size");

    /// <summary>Adds <c>@container-normal</c>.</summary>
    public ContainerTypeBuilder Normal => ChainClass("@container-normal");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ContainerTypeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, ""));
    /// <summary>Declares a named query container.</summary>
    /// <param name="name">The Tailwind container name.</param>
    /// <returns>The current builder.</returns>
    public ContainerTypeBuilder InlineSizeNamed(string name) => ChainClass("@container/" + name);

    /// <summary>Declares a named query container.</summary>
    /// <param name="name">The Tailwind container name.</param>
    /// <returns>The current builder.</returns>
    public ContainerTypeBuilder SizeNamed(string name) => ChainClass("@container-size/" + name);

}
