namespace Soenneker.Quark;

/// <summary>
/// Interface for CSS builders that can generate CSS classes and styles.
/// </summary>
public interface ICssBuilder
{
    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The requested text.</returns>
    string ToClass();

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The requested text.</returns>
    string ToStyle();
}
