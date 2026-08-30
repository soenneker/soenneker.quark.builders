namespace Soenneker.Quark;

/// <summary>
/// Interface for CSS builders that can generate CSS classes and styles.
/// </summary>
public interface ICssBuilder
{
    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The space-delimited utility classes represented by the builder.</returns>
    string ToClass();

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The inline style declarations represented by the builder, or an empty string when it emits classes only.</returns>
    string ToStyle();
}
