using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the word break enum.
/// </summary>
[EnumValue<string>]
public sealed partial class WordBreakEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly WordBreakEnum Normal = new("break-normal");
    /// <summary>
    /// The all.
    /// </summary>
    public static readonly WordBreakEnum All = new("break-all");
    /// <summary>
    /// The keep.
    /// </summary>
    public static readonly WordBreakEnum Keep = new("break-keep");
}
