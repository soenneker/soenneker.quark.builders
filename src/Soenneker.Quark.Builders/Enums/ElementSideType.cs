using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ElementSideType
{
    public static readonly ElementSideType All = new("");
    public static readonly ElementSideType Top = new("t");
    public static readonly ElementSideType End = new("e");
    public static readonly ElementSideType Bottom = new("b");
    public static readonly ElementSideType Start = new("s");
    public static readonly ElementSideType Horizontal = new("x");
    public static readonly ElementSideType Vertical = new("y");

    public static ElementSideType Right => End;
    public static ElementSideType Left => Start;
    public static ElementSideType LeftRight => Horizontal;
    public static ElementSideType TopBottom => Vertical;
    public static ElementSideType InlineStart => Start;
    public static ElementSideType InlineEnd => End;

    public const string RightValue = "e";
    public const string LeftValue = "s";
    public const string LeftRightValue = "x";
    public const string TopBottomValue = "y";
    public const string InlineStartValue = "s";
    public const string InlineEndValue = "e";
}
