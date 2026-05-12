
namespace Soenneker.Quark;

/// <summary>
/// Simplified truncate utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(TruncateBuilder))]
public static partial class Truncate
{
    /// <summary>
    /// Tailwind truncate utility.
    /// </summary>
    public static TruncateBuilder Default => new TruncateBuilder().Default;
}
