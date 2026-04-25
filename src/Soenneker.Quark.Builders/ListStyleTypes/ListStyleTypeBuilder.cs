

namespace Soenneker.Quark;

/// <summary>
/// Builder for CSS list-style-type property.
/// </summary>
[TailwindPrefix("list-", Responsive = false)]
public sealed class ListStyleTypeBuilder : CssBuilderBase
{
    private readonly ListStyleTypeValue _value;

    internal ListStyleTypeBuilder(ListStyleTypeValue value)
    {
        _value = value;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// Tailwind exposes the common values as utilities and supports other
    /// list-style-type values through arbitrary utilities.
    /// </summary>
    /// <returns>The Tailwind utility class string.</returns>
    public override string ToClass()
    {
        return _value.Value switch
        {
            "none" => "list-none",
            "disc" => "list-disc",
            "decimal" => "list-decimal",
            var value when value.Length > 0 => $"list-[{value}]",
            _ => string.Empty
        };
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this list style type builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString() => ToClass();
}

