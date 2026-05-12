namespace Soenneker.Quark;

/// <summary>
/// Tailwind text break utility entry points.
/// </summary>
[TailwindModifiers(typeof(TextBreakBuilder))]
public static partial class TextBreak
{
    /// <summary>
    /// Uses normal line breaking.
    /// </summary>
    public static TextBreakBuilder Normal => new(TextBreakEnum.Normal);
    /// <summary>
    /// Breaks words when needed.
    /// </summary>
    public static TextBreakBuilder Words => new(TextBreakEnum.Words);
    /// <summary>
    /// Breaks at any character.
    /// </summary>
    public static TextBreakBuilder All => new(TextBreakEnum.All);
    /// <summary>
    /// Prevents breaks in CJK text.
    /// </summary>
    public static TextBreakBuilder Keep => new(TextBreakEnum.Keep);
}
