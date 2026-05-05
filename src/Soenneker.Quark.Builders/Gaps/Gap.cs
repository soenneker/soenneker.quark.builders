namespace Soenneker.Quark;

/// <summary>
/// Simplified gap utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
public static class Gap
{
    /// <summary>
    /// No gap (0).
    /// </summary>
    public static GapBuilder Is0 => new(GapScaleEnum.Is0Value);

    /// <summary>
    /// Size 1 gap (0.25rem).
    /// </summary>
    public static GapBuilder Is1 => new(GapScaleEnum.Is1Value);

    /// <summary>
    /// Size 2 gap (0.5rem).
    /// </summary>
    public static GapBuilder Is2 => new(GapScaleEnum.Is2Value);

    /// <summary>
    /// Size 3 gap (1rem).
    /// </summary>
    public static GapBuilder Is3 => new(GapScaleEnum.Is3Value);

    /// <summary>
    /// Size 4 gap (1.5rem).
    /// </summary>
    public static GapBuilder Is4 => new(GapScaleEnum.Is4Value);

    /// <summary>
    /// Size 5 gap (3rem).
    /// </summary>
    public static GapBuilder Is5 => new(GapScaleEnum.Is5Value);

    /// <summary>
    /// Size 6 gap.
    /// </summary>
    public static GapBuilder Is6 => new(GapScaleEnum.Is6Value);

    /// <summary>
    /// Size 8 gap.
    /// </summary>
    public static GapBuilder Is8 => new(GapScaleEnum.Is8Value);

    /// <summary>
    /// Size 10 gap.
    /// </summary>
    public static GapBuilder Is10 => new(GapScaleEnum.Is10Value);

    /// <summary>
    /// Size 12 gap.
    /// </summary>
    public static GapBuilder Is12 => new(GapScaleEnum.Is12Value);

    /// <summary>
    /// Create from an arbitrary Tailwind gap token (e.g. "1.5", "6", "8", "16", "20").
    /// </summary>
    public static GapBuilder Token(string value) => new($"gap-{value}");
}
