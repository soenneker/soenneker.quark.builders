using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the fill enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FillEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly FillEnum None = new("fill-none");
    /// <summary>
    /// The current.
    /// </summary>
    public static readonly FillEnum Current = new("fill-current");
}
