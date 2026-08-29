namespace Soenneker.Quark;

/// <summary>
/// Grid column span utility with fluent responsive chaining.
/// </summary>
[TailwindModifiers(typeof(ColumnSpanBuilder))]
public static partial class ColumnSpan
{
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is1 => new(ColumnSpanEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is2 => new(ColumnSpanEnum.Is2);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is3 => new(ColumnSpanEnum.Is3);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is4 => new(ColumnSpanEnum.Is4);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is5 => new(ColumnSpanEnum.Is5);
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is6 => new(ColumnSpanEnum.Is6);
    /// <summary>
    /// Spacing/sizing scale step `7` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 7` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is7 => new(ColumnSpanEnum.Is7);
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is8 => new(ColumnSpanEnum.Is8);
    /// <summary>
    /// Spacing/sizing scale step `9` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 9` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is9 => new(ColumnSpanEnum.Is9);
    /// <summary>
    /// Spacing/sizing scale step `10` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 10` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is10 => new(ColumnSpanEnum.Is10);
    /// <summary>
    /// Spacing/sizing scale step `11` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 11` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is11 => new(ColumnSpanEnum.Is11);
    /// <summary>
    /// Spacing/sizing scale step `12` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 12` for integer spacing utilities unless overridden).
    /// </summary>
    public static ColumnSpanBuilder Is12 => new(ColumnSpanEnum.Is12);
    /// <summary>
    /// “Full” extremum for this utility. For border radius this is `rounded-full` (`border-radius: 9999px`), producing pills/circles; for width/height often `100%` (`w-full` / `h-full`).
    /// </summary>
    public static ColumnSpanBuilder Full => new(ColumnSpanEnum.Full);

    /// <summary>
    /// Create from a numeric grid column span.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ColumnSpanBuilder Count(int value) => new($"col-span-{value}");
}
