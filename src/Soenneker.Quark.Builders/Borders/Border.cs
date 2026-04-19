namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned border width utility.
/// </summary>
public static class Border
{
    /// <summary>
    /// Tailwind default border width utility with no numeric suffix.
    /// </summary>
    public static BorderBuilder Default => new(string.Empty, allowEmpty: true);
    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public static BorderBuilder Is0 => new(BorderScaleEnum.Is0Value);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public static BorderBuilder Is1 => new(BorderScaleEnum.Is1Value, allowEmpty: true);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public static BorderBuilder Is2 => new(BorderScaleEnum.Is2Value);
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public static BorderBuilder Is3 => new(BorderScaleEnum.Is3Value);
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public static BorderBuilder Is4 => new(BorderScaleEnum.Is4Value);
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public static BorderBuilder Is5 => new(BorderScaleEnum.Is5Value);

    /// <summary>
    /// Creates a border width utility from an arbitrary Tailwind token.
    /// </summary>
    public static BorderBuilder Token(string value) => new(value);
}
