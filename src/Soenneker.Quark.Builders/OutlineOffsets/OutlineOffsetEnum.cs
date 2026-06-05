using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the outline offset enum.
/// </summary>
[EnumValue<string>]
public sealed partial class OutlineOffsetEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly OutlineOffsetEnum Is0 = new("outline-offset-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly OutlineOffsetEnum Is1 = new("outline-offset-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly OutlineOffsetEnum Is2 = new("outline-offset-2");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly OutlineOffsetEnum Is4 = new("outline-offset-4");
    /// <summary>
    /// The is8.
    /// </summary>
    public static readonly OutlineOffsetEnum Is8 = new("outline-offset-8");
}
