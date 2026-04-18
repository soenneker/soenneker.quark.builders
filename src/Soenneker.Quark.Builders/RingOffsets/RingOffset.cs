namespace Soenneker.Quark;

public static class RingOffset
{
    public static RingOffsetBuilder Width(int value) => new($"ring-offset-{value}");
    public static RingOffsetBuilder Color(string value) => new($"ring-offset-{value}");
}
