namespace Soenneker.Quark;

/// <summary>
/// Tailwind word break utility entry points.
/// </summary>
[TailwindModifiers(typeof(WordBreakBuilder))]
public static partial class WordBreak
{
    /// <summary>
    /// Uses normal line breaking.
    /// </summary>
    public static WordBreakBuilder Normal => new(WordBreakEnum.Normal);
    /// <summary>
    /// Breaks at any character.
    /// </summary>
    public static WordBreakBuilder All => new(WordBreakEnum.All);
    /// <summary>
    /// Prevents breaks in CJK text.
    /// </summary>
    public static WordBreakBuilder Keep => new(WordBreakEnum.Keep);
}
