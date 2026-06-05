using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration thickness enum.
/// </summary>
[EnumValue<string>]
public sealed partial class DecorationThicknessEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly DecorationThicknessEnum Auto = new("decoration-auto");
    /// <summary>
    /// The from font.
    /// </summary>
    public static readonly DecorationThicknessEnum FromFont = new("decoration-from-font");
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly DecorationThicknessEnum Is0 = new("decoration-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly DecorationThicknessEnum Is1 = new("decoration-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly DecorationThicknessEnum Is2 = new("decoration-2");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly DecorationThicknessEnum Is4 = new("decoration-4");
    /// <summary>
    /// The is8.
    /// </summary>
    public static readonly DecorationThicknessEnum Is8 = new("decoration-8");
}
