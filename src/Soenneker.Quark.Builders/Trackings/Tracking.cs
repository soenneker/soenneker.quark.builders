namespace Soenneker.Quark;

public static class Tracking
{
    public static TrackingBuilder Tighter => new(TrackingEnum.Tighter);
    public static TrackingBuilder Tight => new(TrackingEnum.Tight);
    public static TrackingBuilder Normal => new(TrackingEnum.Normal);
    public static TrackingBuilder Wide => new(TrackingEnum.Wide);
    public static TrackingBuilder Wider => new(TrackingEnum.Wider);
    public static TrackingBuilder Widest => new(TrackingEnum.Widest);
    public static TrackingBuilder Token(string value) => new("tracking-" + value);
}
