
namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating position offset builders with predefined values.
/// </summary>
public static class PositionOffset
{
    /// <summary>
    /// Gets a position offset builder with top 0 (0% from top).
    /// </summary>
    public static PositionOffsetBuilder Top0 => new(PositionOffsetEnum.Top0);
    /// <summary>
    /// Gets a position offset builder with top 50 (50% from top).
    /// </summary>
    public static PositionOffsetBuilder Top50 => new(PositionOffsetEnum.Top50);
    /// <summary>
    /// Gets a position offset builder with top 100 (100% from top).
    /// </summary>
    public static PositionOffsetBuilder Top100 => new(PositionOffsetEnum.Top100);

    /// <summary>
    /// Gets a position offset builder with bottom 0 (0% from bottom).
    /// </summary>
    public static PositionOffsetBuilder Bottom0 => new(PositionOffsetEnum.Bottom0);
    /// <summary>
    /// Gets a position offset builder with bottom 50 (50% from bottom).
    /// </summary>
    public static PositionOffsetBuilder Bottom50 => new(PositionOffsetEnum.Bottom50);
    /// <summary>
    /// Gets a position offset builder with bottom 100 (100% from bottom).
    /// </summary>
    public static PositionOffsetBuilder Bottom100 => new(PositionOffsetEnum.Bottom100);

    /// <summary>
    /// Gets a position offset builder with start 0 (0% from start).
    /// </summary>
    public static PositionOffsetBuilder Start0 => new(PositionOffsetEnum.Start0);
    /// <summary>
    /// Gets a position offset builder with start 50 (50% from start).
    /// </summary>
    public static PositionOffsetBuilder Start50 => new(PositionOffsetEnum.Start50);
    /// <summary>
    /// Gets a position offset builder with start 100 (100% from start).
    /// </summary>
    public static PositionOffsetBuilder Start100 => new(PositionOffsetEnum.Start100);

    /// <summary>
    /// Gets a position offset builder with end 0 (0% from end).
    /// </summary>
    public static PositionOffsetBuilder End0 => new(PositionOffsetEnum.End0);
    /// <summary>
    /// Gets a position offset builder with end 50 (50% from end).
    /// </summary>
    public static PositionOffsetBuilder End50 => new(PositionOffsetEnum.End50);
    /// <summary>
    /// Gets a position offset builder with end 100 (100% from end).
    /// </summary>
    public static PositionOffsetBuilder End100 => new(PositionOffsetEnum.End100);

    /// <summary>
    /// Gets a position offset builder that translates to middle (centered both horizontally and vertically).
    /// </summary>
    public static PositionOffsetBuilder TranslateMiddle => new(PositionOffsetEnum.TranslateMiddle);
    /// <summary>
    /// Gets a position offset builder that translates to middle-x (centered horizontally).
    /// </summary>
    public static PositionOffsetBuilder TranslateMiddleX => new(PositionOffsetEnum.TranslateMiddleX);
    /// <summary>
    /// Gets a position offset builder that translates to middle-y (centered vertically).
    /// </summary>
    public static PositionOffsetBuilder TranslateMiddleY => new(PositionOffsetEnum.TranslateMiddleY);
}
