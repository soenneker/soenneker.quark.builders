using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the caret color enum.
/// </summary>
[EnumValue<string>]
public sealed partial class CaretColorEnum
{
    /// <summary>
    /// The primary.
    /// </summary>
    public static readonly CaretColorEnum Primary = new("caret-primary");
    /// <summary>
    /// The transparent.
    /// </summary>
    public static readonly CaretColorEnum Transparent = new("caret-transparent");
    /// <summary>
    /// The current.
    /// </summary>
    public static readonly CaretColorEnum Current = new("caret-current");
}
