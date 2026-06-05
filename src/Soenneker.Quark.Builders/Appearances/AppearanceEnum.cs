using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the appearance enum.
/// </summary>
[EnumValue<string>]
public sealed partial class AppearanceEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly AppearanceEnum None = new("appearance-none");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly AppearanceEnum Auto = new("appearance-auto");
}
