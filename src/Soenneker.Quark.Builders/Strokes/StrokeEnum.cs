using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the stroke enum.
/// </summary>
[EnumValue<string>]
public sealed partial class StrokeEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly StrokeEnum None = new("stroke-none");
    /// <summary>
    /// The current.
    /// </summary>
    public static readonly StrokeEnum Current = new("stroke-current");
}
