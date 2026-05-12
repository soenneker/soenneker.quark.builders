namespace Soenneker.Quark;

/// <summary>
/// Static utility for isolation. Tailwind: isolation-auto, isolation-isolate.
/// </summary>
[TailwindModifiers(typeof(IsolationBuilder))]
public static partial class Isolation
{
    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static IsolationBuilder Auto => new(IsolationEnum.Auto);
    /// <summary>
    /// Fluent step for `Isolate` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static IsolationBuilder Isolate => new(IsolationEnum.Isolate);
}
