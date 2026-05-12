
namespace Soenneker.Quark;

/// <summary>
/// Simplified screen reader utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(ScreenReaderBuilder))]
public static partial class ScreenReader
{
    /// <summary>
    /// Screen reader only (sr-only).
    /// </summary>
    public static ScreenReaderBuilder Only => new(ScreenReaderEnum.Only);
}
