namespace Soenneker.Quark;

/// <summary>
/// Represents the ring offset.
/// </summary>
[TailwindModifiers(typeof(RingOffsetBuilder))]
public static partial class RingOffset
{
    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public static RingOffsetBuilder Primary => new RingOffsetBuilder(string.Empty).Primary;
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public static RingOffsetBuilder Secondary => new RingOffsetBuilder(string.Empty).Secondary;
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public static RingOffsetBuilder Destructive => new RingOffsetBuilder(string.Empty).Destructive;
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public static RingOffsetBuilder Muted => new RingOffsetBuilder(string.Empty).Muted;
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public static RingOffsetBuilder Accent => new RingOffsetBuilder(string.Empty).Accent;
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public static RingOffsetBuilder Popover => new RingOffsetBuilder(string.Empty).Popover;
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public static RingOffsetBuilder Card => new RingOffsetBuilder(string.Empty).Card;
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public static RingOffsetBuilder Background => new RingOffsetBuilder(string.Empty).Background;
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public static RingOffsetBuilder Border => new RingOffsetBuilder(string.Empty).Border;
    /// <summary>
    /// Gets or sets input.
    /// </summary>
    public static RingOffsetBuilder Input => new RingOffsetBuilder(string.Empty).Input;
    /// <summary>
    /// Gets or sets ring.
    /// </summary>
    public static RingOffsetBuilder Ring => new RingOffsetBuilder(string.Empty).Ring;
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public static RingOffsetBuilder White => new RingOffsetBuilder(string.Empty).White;
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public static RingOffsetBuilder Black => new RingOffsetBuilder(string.Empty).Black;
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public static RingOffsetBuilder Transparent => new RingOffsetBuilder(string.Empty).Transparent;
    /// <summary>
    /// Adds the width Ring Offset utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RingOffsetBuilder Width(int value) => new RingOffsetBuilder(string.Empty).Width(value);
    /// <summary>
    /// Adds the width Ring Offset utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RingOffsetBuilder Width(string value) => new RingOffsetBuilder(string.Empty).Width(value);
    /// <summary>
    /// Adds the color Ring Offset utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RingOffsetBuilder Color(string value) => new RingOffsetBuilder(string.Empty).Color(value);
    /// <summary>
    /// Adds the utility Ring Offset utility to the class list.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RingOffsetBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("ring-offset-", utility));
}
