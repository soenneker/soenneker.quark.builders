using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the text break enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TextBreakEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly TextBreakEnum Normal = new("break-normal");
    /// <summary>
    /// The words.
    /// </summary>
    public static readonly TextBreakEnum Words = new("break-words");
    /// <summary>
    /// The all.
    /// </summary>
    public static readonly TextBreakEnum All = new("break-all");
    /// <summary>
    /// The keep.
    /// </summary>
    public static readonly TextBreakEnum Keep = new("break-keep");
}
