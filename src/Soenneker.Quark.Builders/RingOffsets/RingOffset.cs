namespace Soenneker.Quark;

public static class RingOffset
{
    public static RingOffsetBuilder Primary => new RingOffsetBuilder(string.Empty).Primary;
    public static RingOffsetBuilder Secondary => new RingOffsetBuilder(string.Empty).Secondary;
    public static RingOffsetBuilder Destructive => new RingOffsetBuilder(string.Empty).Destructive;
    public static RingOffsetBuilder Muted => new RingOffsetBuilder(string.Empty).Muted;
    public static RingOffsetBuilder Accent => new RingOffsetBuilder(string.Empty).Accent;
    public static RingOffsetBuilder Popover => new RingOffsetBuilder(string.Empty).Popover;
    public static RingOffsetBuilder Card => new RingOffsetBuilder(string.Empty).Card;
    public static RingOffsetBuilder Background => new RingOffsetBuilder(string.Empty).Background;
    public static RingOffsetBuilder Border => new RingOffsetBuilder(string.Empty).Border;
    public static RingOffsetBuilder Input => new RingOffsetBuilder(string.Empty).Input;
    public static RingOffsetBuilder Ring => new RingOffsetBuilder(string.Empty).Ring;
    public static RingOffsetBuilder White => new RingOffsetBuilder(string.Empty).White;
    public static RingOffsetBuilder Black => new RingOffsetBuilder(string.Empty).Black;
    public static RingOffsetBuilder Transparent => new RingOffsetBuilder(string.Empty).Transparent;
    public static RingOffsetBuilder Width(int value) => new RingOffsetBuilder(string.Empty).Width(value);
    public static RingOffsetBuilder Width(string value) => new RingOffsetBuilder(string.Empty).Width(value);
    public static RingOffsetBuilder Color(string value) => new RingOffsetBuilder(string.Empty).Color(value);
    public static RingOffsetBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("ring-offset-", utility));
}
