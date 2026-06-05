using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the underline offset enum.
/// </summary>
[EnumValue<string>]
public sealed partial class UnderlineOffsetEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly UnderlineOffsetEnum Auto = new("underline-offset-auto");
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly UnderlineOffsetEnum Is0 = new("underline-offset-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly UnderlineOffsetEnum Is1 = new("underline-offset-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly UnderlineOffsetEnum Is2 = new("underline-offset-2");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly UnderlineOffsetEnum Is4 = new("underline-offset-4");
    /// <summary>
    /// The is8.
    /// </summary>
    public static readonly UnderlineOffsetEnum Is8 = new("underline-offset-8");
}
