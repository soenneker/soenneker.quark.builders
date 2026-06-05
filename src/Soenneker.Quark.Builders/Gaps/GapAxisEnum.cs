using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the gap axis enum.
/// </summary>
[EnumValue<string>]
public sealed partial class GapAxisEnum
{
    /// <summary>
    /// The all.
    /// </summary>
    public static readonly GapAxisEnum All = new("gap-");
    /// <summary>
    /// The x.
    /// </summary>
    public static readonly GapAxisEnum X = new("gap-x-");
    /// <summary>
    /// The y.
    /// </summary>
    public static readonly GapAxisEnum Y = new("gap-y-");
}
