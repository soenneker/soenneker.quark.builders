namespace Soenneker.Quark;

/// <summary>Builds clip paths using Tailwind arbitrary properties.</summary>
[TailwindPrefix("[clip-path:", Responsive = true)]
public sealed class ClipPathBuilder : FinalClassUtilityBuilder<ClipPathBuilder>
{
    internal ClipPathBuilder() {}
    internal ClipPathBuilder(string value) : base(value) {}

    /// <summary>Removes clipping.</summary>
    public ClipPathBuilder None => ChainClass("[clip-path:none]");

    /// <summary>Sets the clip path using the circle() function.</summary>
    /// <param name="value">The function arguments; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>The current builder.</returns>
    public ClipPathBuilder Circle(string value) => ChainClass(UtilityToken.ArbitraryProperty("clip-path", $"circle({value})"));

    /// <summary>Sets the clip path using the ellipse() function.</summary>
    /// <param name="value">The function arguments; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>The current builder.</returns>
    public ClipPathBuilder Ellipse(string value) => ChainClass(UtilityToken.ArbitraryProperty("clip-path", $"ellipse({value})"));

    /// <summary>Sets the clip path using the inset() function.</summary>
    /// <param name="value">The function arguments; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>The current builder.</returns>
    public ClipPathBuilder Inset(string value) => ChainClass(UtilityToken.ArbitraryProperty("clip-path", $"inset({value})"));

    /// <summary>Sets the clip path using the polygon() function.</summary>
    /// <param name="value">The function arguments; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>The current builder.</returns>
    public ClipPathBuilder Polygon(string value) => ChainClass(UtilityToken.ArbitraryProperty("clip-path", $"polygon({value})"));

    /// <summary>Sets the clip path using a CSS value.</summary>
    /// <param name="value">The CSS value; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>The current builder.</returns>
    public ClipPathBuilder Token(string value) => ChainClass(UtilityToken.ArbitraryProperty("clip-path", value));

}
