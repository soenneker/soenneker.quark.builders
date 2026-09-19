namespace Soenneker.Quark;

/// <summary>Builds clip paths using Tailwind arbitrary properties.</summary>
[TailwindModifiers(typeof(ClipPathBuilder))]
public static partial class ClipPath
{
    /// <summary>Removes clipping.</summary>
    public static ClipPathBuilder None => new("[clip-path:none]");

    /// <summary>Sets the clip path using the circle() function.</summary>
    /// <param name="value">The function arguments; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>A new builder.</returns>
    public static ClipPathBuilder Circle(string value) => new(UtilityToken.ArbitraryProperty("clip-path", $"circle({value})"));

    /// <summary>Sets the clip path using the ellipse() function.</summary>
    /// <param name="value">The function arguments; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>A new builder.</returns>
    public static ClipPathBuilder Ellipse(string value) => new(UtilityToken.ArbitraryProperty("clip-path", $"ellipse({value})"));

    /// <summary>Sets the clip path using the inset() function.</summary>
    /// <param name="value">The function arguments; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>A new builder.</returns>
    public static ClipPathBuilder Inset(string value) => new(UtilityToken.ArbitraryProperty("clip-path", $"inset({value})"));

    /// <summary>Sets the clip path using the polygon() function.</summary>
    /// <param name="value">The function arguments; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>A new builder.</returns>
    public static ClipPathBuilder Polygon(string value) => new(UtilityToken.ArbitraryProperty("clip-path", $"polygon({value})"));

    /// <summary>Sets the clip path using a CSS value.</summary>
    /// <param name="value">The CSS value; use underscores for spaces in Tailwind tokens.</param>
    /// <returns>A new builder.</returns>
    public static ClipPathBuilder Token(string value) => new(UtilityToken.ArbitraryProperty("clip-path", value));

}
