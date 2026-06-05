using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration line enum.
/// </summary>
[EnumValue<string>]
public sealed partial class DecorationLineEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly DecorationLineEnum None = new("no-underline");
    /// <summary>
    /// The underline.
    /// </summary>
    public static readonly DecorationLineEnum Underline = new("underline");
    /// <summary>
    /// The line through.
    /// </summary>
    public static readonly DecorationLineEnum LineThrough = new("line-through");
    /// <summary>
    /// The overline.
    /// </summary>
    public static readonly DecorationLineEnum Overline = new("overline");
}
