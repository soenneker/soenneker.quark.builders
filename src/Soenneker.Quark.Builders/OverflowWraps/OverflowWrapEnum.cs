using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the overflow wrap enum.
/// </summary>
[EnumValue<string>]
public sealed partial class OverflowWrapEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly OverflowWrapEnum Normal = new("wrap-normal");
    /// <summary>
    /// The anywhere.
    /// </summary>
    public static readonly OverflowWrapEnum Anywhere = new("wrap-anywhere");
    /// <summary>
    /// The break word.
    /// </summary>
    public static readonly OverflowWrapEnum BreakWord = new("wrap-break-word");
}
