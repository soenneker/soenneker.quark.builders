namespace Soenneker.Quark;

public static class Align
{
    public static AlignBuilder ItemsStart => new AlignBuilder().ItemsStart;
    public static AlignBuilder ItemsEnd => new AlignBuilder().ItemsEnd;
    public static AlignBuilder ItemsCenter => new AlignBuilder().ItemsCenter;
    public static AlignBuilder ItemsBaseline => new AlignBuilder().ItemsBaseline;
    public static AlignBuilder ItemsStretch => new AlignBuilder().ItemsStretch;
    public static AlignBuilder JustifyStart => new AlignBuilder().JustifyStart;
    public static AlignBuilder JustifyEnd => new AlignBuilder().JustifyEnd;
    public static AlignBuilder JustifyCenter => new AlignBuilder().JustifyCenter;
    public static AlignBuilder JustifyBetween => new AlignBuilder().JustifyBetween;
    public static AlignBuilder JustifyAround => new AlignBuilder().JustifyAround;
    public static AlignBuilder JustifyEvenly => new AlignBuilder().JustifyEvenly;
    public static AlignBuilder SelfStart => new AlignBuilder().SelfStart;
    public static AlignBuilder SelfEnd => new AlignBuilder().SelfEnd;
    public static AlignBuilder SelfCenter => new AlignBuilder().SelfCenter;
    public static AlignBuilder SelfStretch => new AlignBuilder().SelfStretch;
    public static AlignBuilder Token(string value) => new AlignBuilder().Token(value);
}
