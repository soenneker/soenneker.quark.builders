using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the truncate enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TruncateEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly TruncateEnum Default = new("truncate");
}
