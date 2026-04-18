using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ElementSideEnum
{
    public static readonly ElementSideEnum All = new("");
    public static readonly ElementSideEnum Top = new("t");
    public static readonly ElementSideEnum End = new("e");
    public static readonly ElementSideEnum Bottom = new("b");
    public static readonly ElementSideEnum Start = new("s");
    public static readonly ElementSideEnum Horizontal = new("x");
    public static readonly ElementSideEnum Vertical = new("y");

    public static ElementSideEnum Right => End;
    public static ElementSideEnum Left => Start;
    public static ElementSideEnum LeftRight => Horizontal;
    public static ElementSideEnum TopBottom => Vertical;
    public static ElementSideEnum InlineStart => Start;
    public static ElementSideEnum InlineEnd => End;

    public const string RightValue = "e";
    public const string LeftValue = "s";
    public const string LeftRightValue = "x";
    public const string TopBottomValue = "y";
    public const string InlineStartValue = "s";
    public const string InlineEndValue = "e";
}
