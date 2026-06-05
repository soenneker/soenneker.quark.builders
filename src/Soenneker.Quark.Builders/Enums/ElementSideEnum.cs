using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the element side enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ElementSideEnum
{
    /// <summary>
    /// The all.
    /// </summary>
    public static readonly ElementSideEnum All = new("");
    /// <summary>
    /// The top.
    /// </summary>
    public static readonly ElementSideEnum Top = new("t");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly ElementSideEnum End = new("e");
    /// <summary>
    /// The bottom.
    /// </summary>
    public static readonly ElementSideEnum Bottom = new("b");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly ElementSideEnum Start = new("s");
    /// <summary>
    /// The right physical.
    /// </summary>
    public static readonly ElementSideEnum RightPhysical = new("r");
    /// <summary>
    /// The left physical.
    /// </summary>
    public static readonly ElementSideEnum LeftPhysical = new("l");
    /// <summary>
    /// The horizontal.
    /// </summary>
    public static readonly ElementSideEnum Horizontal = new("x");
    /// <summary>
    /// The vertical.
    /// </summary>
    public static readonly ElementSideEnum Vertical = new("y");

    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public static ElementSideEnum Right => RightPhysical;
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public static ElementSideEnum Left => LeftPhysical;
    /// <summary>
    /// Gets or sets left right.
    /// </summary>
    public static ElementSideEnum LeftRight => Horizontal;
    /// <summary>
    /// Gets or sets top bottom.
    /// </summary>
    public static ElementSideEnum TopBottom => Vertical;
    /// <summary>
    /// Gets or sets inline start.
    /// </summary>
    public static ElementSideEnum InlineStart => Start;
    /// <summary>
    /// Gets or sets inline end.
    /// </summary>
    public static ElementSideEnum InlineEnd => End;

    /// <summary>
    /// The right value.
    /// </summary>
    public const string RightValue = "r";
    /// <summary>
    /// The left value.
    /// </summary>
    public const string LeftValue = "l";
    /// <summary>
    /// The left right value.
    /// </summary>
    public const string LeftRightValue = "x";
    /// <summary>
    /// The top bottom value.
    /// </summary>
    public const string TopBottomValue = "y";
    /// <summary>
    /// The inline start value.
    /// </summary>
    public const string InlineStartValue = "s";
    /// <summary>
    /// The inline end value.
    /// </summary>
    public const string InlineEndValue = "e";
}
