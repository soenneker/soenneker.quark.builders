namespace Soenneker.Quark;

/// <summary>
/// Grid row span utility with fluent responsive chaining.
/// </summary>
public static class RowSpan
{
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static RowSpanBuilder Is1 => new(RowSpanEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static RowSpanBuilder Is2 => new(RowSpanEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static RowSpanBuilder Is3 => new(RowSpanEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static RowSpanBuilder Is4 => new(RowSpanEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static RowSpanBuilder Is5 => new(RowSpanEnum.Is5);
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public static RowSpanBuilder Is6 => new(RowSpanEnum.Is6);
    /// <summary>
    /// “Full” extremum for this utility. For border radius this is `rounded-full` (`border-radius: 9999px`), producing pills/circles; for width/height often `100%` (`w-full` / `h-full`).
    /// </summary>
    public static RowSpanBuilder Full => new(RowSpanEnum.Full);

    /// <summary>
    /// Create from a numeric grid row span.
    /// </summary>
    public static RowSpanBuilder Count(int value) => new($"row-span-{value}");
}
